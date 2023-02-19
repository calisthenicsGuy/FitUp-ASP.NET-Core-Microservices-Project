namespace FitUp.ProgramsService.DataModel.Data
{
    using FitUp.DataModel.Data;
    using FitUp.ProgramsService.DataModel.Models;
    using Microsoft.EntityFrameworkCore;

    public class ProgramsServiceDbContext : FitUpDbContext
    {
        public ProgramsServiceDbContext()
            : base("programs-microservice-settings.json", typeof(ProgramsServiceDbContext))
        {
        }

        public DbSet<Exercise> Exercises { get; set; }
    }
}
