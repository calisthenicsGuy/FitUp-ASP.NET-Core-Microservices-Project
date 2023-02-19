namespace FitUp.ExercisesService.DataModel.Models
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    using FitUp.DataModel.Helpers.Models.Interfaces;

    public class ExerciseMuscleGroup : IInfoModel
    {
        [ForeignKey(nameof(Exercise))]
        public int ExerciseId { get; set; }

        public Exercise Exercise { get; set; }

        [ForeignKey(nameof(MuscleGroup))]
        public int MuscleGroupId { get; set; }

        public MuscleGroup MuscleGroup { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }
    }
}
