namespace FitUp.ExercisesService.DataModel.Data
{
    using FitUp.DataModel.Data;
    using FitUp.ExercisesService.DataModel.Data.Configurations;
    using FitUp.ExercisesService.DataModel.Models;
    using Microsoft.EntityFrameworkCore;

    public class ExercisesServiceDbContext : FitUpDbContext
    {
        public ExercisesServiceDbContext()
            : base("exercises-microservice-settings.json", typeof(ExercisesServiceDbContext))
        {
        }

        public DbSet<Exercise> Exercises { get; set; }

        public DbSet<MuscleGroup> MuscleGroups { get; set; }

        public DbSet<ExerciseMuscleGroup> ExerciseMuscleGroups { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ExerciseMuscleGroupConfiguration());
            modelBuilder.ApplyConfiguration(new ExerciseEquipmentConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
