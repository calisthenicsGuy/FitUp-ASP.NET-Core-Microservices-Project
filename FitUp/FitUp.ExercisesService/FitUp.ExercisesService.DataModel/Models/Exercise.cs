namespace FitUp.ExercisesService.DataModel.Models
{
    using System.ComponentModel.DataAnnotations;
    using FitUp.DataModel.Helpers.Models;
    using FitUp.ExercisesService.DataModel.Models.Enums;

    using static FitUp.DataModel.Helpers.Constants.DataValidation.Exercise;

    public class Exercise : FullModel<int>
    {
        public Exercise()
        {
            this.ExerciseMuscleGroups = new HashSet<ExerciseMuscleGroup>();
            this.ExerciseEquipments = new HashSet<ExerciseEquipment>();
        }

        [MaxLength(NameMaxLength)]
        public string Name { get; set; }

        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; }

        public byte[] Video { get; set; }

        public DifficultLevel DifficultLevel { get; set; }

        public virtual ICollection<ExerciseMuscleGroup> ExerciseMuscleGroups { get; set; }

        public virtual ICollection<ExerciseEquipment> ExerciseEquipments { get; set; }
    }
}
