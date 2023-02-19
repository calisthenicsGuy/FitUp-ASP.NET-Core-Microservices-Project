namespace FitUp.DataModel.Data
{
    using System.Reflection;
    using FitUp.DataModel.Helpers.Models.Interfaces;
    using Microsoft.EntityFrameworkCore;

    public class FitUpDbContext : DbContext
    {
        private static readonly MethodInfo SetIsDeletedQueryFilterMethod = 
            DbContextType.GetMethod(nameof(SetIsDeletedQueryFilter), BindingFlags.NonPublic | BindingFlags.Static);

        private string microserviceFileBaneSettings;

        public FitUpDbContext(string microserviceFileNameSettings, Type dbContextType)
        {
            DbContextType = dbContextType;
            this.MicroserviceFileNameSettings = microserviceFileNameSettings;
        }

        public static Type DbContextType { get; set; }

        public string MicroserviceFileNameSettings
        {
            get => this.microserviceFileBaneSettings;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Microservice file name for settings cannot be null white space.");
                }

                if (!value.Contains(".json"))
                {
                    value = value + ".json";
                }

                this.microserviceFileBaneSettings = value;
            }
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
            => this.SaveChangesAsync(true, cancellationToken);

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
            => base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                AppSettings appSettings = new AppSettings(this.MicroserviceFileNameSettings);

                optionsBuilder.UseSqlServer(appSettings.DefaultConnection());
            }

            base.OnConfiguring(optionsBuilder);
        }

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
