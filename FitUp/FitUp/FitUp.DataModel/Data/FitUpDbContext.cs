namespace FitUp.DataModel.Data
{
    using System.Reflection;
    using FitUp.DataModel.Helpers.Models.Interfaces;
    using Microsoft.EntityFrameworkCore;

    public class FitUpDbContext : DbContext
    {
        private static readonly MethodInfo SetIsDeletedQueryFilterMethod = 
            DbContextType.GetMethod(nameof(SetIsDeletedQueryFilter), BindingFlags.NonPublic | BindingFlags.Static);

        public FitUpDbContext(Type dbContextType)
        {
            DbContextType = dbContextType;
        }

        public static Type DbContextType { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
            => this.SaveChangesAsync(true, cancellationToken);

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
            => base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var entityTypes = modelBuilder.Model.GetEntityTypes().ToList();

            // Set global query filter for not deleted entities only
            var deletableEntityTypes = entityTypes
                .Where(et => et.ClrType != null && typeof(IDeletableModel).IsAssignableFrom(et.ClrType));
            foreach (var deletableEntityType in deletableEntityTypes)
            {
                var method = SetIsDeletedQueryFilterMethod.MakeGenericMethod(deletableEntityType.ClrType);
                method.Invoke(null, new object[] { modelBuilder });
            }

            // Disable cascade delete
            var foreignKeys = entityTypes
                .SelectMany(e => e.GetForeignKeys().Where(f => f.DeleteBehavior == DeleteBehavior.Cascade));
            foreach (var foreignKey in foreignKeys)
            {
                foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }

        protected static void SetIsDeletedQueryFilter<T>(ModelBuilder builder)
            where T : class, IDeletableModel
        {
            builder.Entity<T>().HasQueryFilter(e => !e.IsDeleted);
        }
    }
}
