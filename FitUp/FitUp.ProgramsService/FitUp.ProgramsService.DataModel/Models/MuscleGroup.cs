namespace FitUp.ProgramsService.DataModel.Models
{
    using System.ComponentModel.DataAnnotations;
    using FitUp.DataModel.Helpers.Models;

    using static FitUp.DataModel.Helpers.Constants.DataValidation.MuscleGroup;

    public class MuscleGroup : BaseInfoModel<int>
    {
        public MuscleGroup()
        {
            this.ExerciseMuscleGroups = new HashSet<ExerciseMuscleGroup>();
        }

        [MaxLength(NameMaxLength)]
        public string Name { get; set; }

        public byte[] Image { get; set; }

        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; }

        public virtual ICollection<ExerciseMuscleGroup> ExerciseMuscleGroups { get; set; }
    }
}
