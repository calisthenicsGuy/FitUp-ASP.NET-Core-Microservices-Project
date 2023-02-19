namespace FitUp.ExercisesService.DataModel.Data.Configurations
{
    using FitUp.ExercisesService.DataModel.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class ExerciseEquipmentConfiguration : IEntityTypeConfiguration<ExerciseEquipment>
    {
        public void Configure(EntityTypeBuilder<ExerciseEquipment> exerciseEquipmentsBuilder)
        {
            exerciseEquipmentsBuilder
                .HasKey(x => new { x.ExerciseId, x.EquipmentId });

            exerciseEquipmentsBuilder
                .HasOne(e => e.Exercise)
                .WithMany(e => e.ExerciseEquipments)
                .HasForeignKey(e => e.ExerciseId)
                .OnDelete(DeleteBehavior.Restrict);

            exerciseEquipmentsBuilder
                .HasOne(e => e.Equipment)
                .WithMany(e => e.ExerciseEquipments)
                .HasForeignKey(e => e.EquipmentId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
