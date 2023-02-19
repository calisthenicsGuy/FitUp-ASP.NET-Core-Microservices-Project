namespace FitUp.ExercisesService.DataModel.Data.Configurations
{
    using FitUp.ExercisesService.DataModel.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class ExerciseMuscleGroupConfiguration : IEntityTypeConfiguration<ExerciseMuscleGroup>
    {
        public void Configure(EntityTypeBuilder<ExerciseMuscleGroup> exerciseMuscleGroupBuilder)
        {
            exerciseMuscleGroupBuilder
                .HasKey(x => new { x.ExerciseId, x.MuscleGroupId });

            exerciseMuscleGroupBuilder
                .HasOne(e => e.Exercise)
                .WithMany(e => e.ExerciseMuscleGroups)
                .HasForeignKey(e => e.ExerciseId)
                .OnDelete(DeleteBehavior.Restrict);

            exerciseMuscleGroupBuilder
               .HasOne(m => m.MuscleGroup)
               .WithMany(m => m.ExerciseMuscleGroups)
               .HasForeignKey(e => e.MuscleGroupId)
               .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
