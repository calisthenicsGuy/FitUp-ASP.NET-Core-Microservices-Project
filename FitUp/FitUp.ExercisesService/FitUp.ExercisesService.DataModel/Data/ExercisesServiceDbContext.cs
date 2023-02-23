namespace FitUp.ExercisesService.DataModel.Data
{
    using FitUp.ExercisesService.DataModel.Data.Configurations;
    using FitUp.ExercisesService.DataModel.Models;
    using Microsoft.EntityFrameworkCore;

    public class ExercisesServiceDbContext : DbContext
    {
        private const string EXERCISES_APP_SETTINGS_FILE_NAME = "exercises-microservice-settings.json";

        public ExercisesServiceDbContext()
        {
        }

        public DbSet<Exercise> Exercises { get; set; }

        public DbSet<MuscleGroup> MuscleGroups { get; set; }

        public DbSet<Equipment> Equipments { get; set; }

        public DbSet<ExerciseMuscleGroup> ExerciseMuscleGroups { get; set; }

        public DbSet<ExerciseEquipment> ExerciseEquipments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                ExercisesAppSettings appSettings = new ExercisesAppSettings(EXERCISES_APP_SETTINGS_FILE_NAME);

                optionsBuilder.UseSqlServer(appSettings.DefaultConnection);
            }

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ExerciseMuscleGroupConfiguration());
            modelBuilder.ApplyConfiguration(new ExerciseEquipmentConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
