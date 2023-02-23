namespace FitUp.ProgramsService.DataModel.Models
{
    using System.ComponentModel.DataAnnotations;
    using FitUp.DataModel.Helpers.Models;
    using FitUp.ExercisesService.DataModel.Models;
    using FitUp.ProgramsService.DataModel.Models.Enums;
    using static FitUp.ProgramsService.DataModel.Helpers.Constants.DataValidation.Exercise;

    public class Exercise : FullModel<int>
    {
        [MaxLength(NameMaxLength)]
        public string Name { get; set; }

        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; }

        public byte[] Video { get; set; }

        public int Sets { get; set; }

        public string RepRange { get; set; }

        public DifficultLevel DifficultLevel { get; set; }

        public virtual ICollection<ExerciseMuscleGroup> ExerciseMuscleGroups { get; set; }

        public virtual ICollection<ExerciseEquipment> ExerciseEquipments { get; set; }
    }
}
