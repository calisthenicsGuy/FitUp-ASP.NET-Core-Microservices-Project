namespace FitUp.ProgramsService.DataModel.Data
{
    using FitUp.DataModel.Data;
    using FitUp.ProgramsService.DataModel.Models;
    using Microsoft.EntityFrameworkCore;

    public class ProgramsServiceDbContext : FitUpDbContext
    {
        private const string PROGRAMS_APP_SETTINGS_FILE_NAME = "programs-microservice-settings.json";

        public ProgramsServiceDbContext()
            : base(typeof(ProgramsServiceDbContext))
        {
        }

        public DbSet<Exercise> Exercises { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                ProgramsAppSettings appSettings = new ProgramsAppSettings(PROGRAMS_APP_SETTINGS_FILE_NAME);

                optionsBuilder.UseSqlServer(appSettings.DefaultConnection);
            }

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
