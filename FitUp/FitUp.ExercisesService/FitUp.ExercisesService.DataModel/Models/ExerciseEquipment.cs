namespace FitUp.ExercisesService.DataModel.Models
{
    using System.ComponentModel.DataAnnotations.Schema;
    using FitUp.DataModel.Helpers.Models.Interfaces;

    public class ExerciseEquipment : IInfoModel
    {
        [ForeignKey(nameof(Exercise))]
        public int ExerciseId { get; set; }

        public Exercise Exercise { get; set; }

        [ForeignKey(nameof(Equipment))]
        public int EquipmentId { get; set; }

        public Equipment Equipment { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }
    }
}
