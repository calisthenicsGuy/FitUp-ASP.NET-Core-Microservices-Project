namespace FitUp.ExercisesService.DataModel.Models
{
    using System.ComponentModel.DataAnnotations;
    using FitUp.DataModel.Helpers.Models;

    using static FitUp.ExercisesService.DataModel.Helpers.Constants.DataValidation.Equipment;

    public class Equipment : BaseInfoModel<int>
    {
        public Equipment()
        {
            this.ExerciseEquipments = new HashSet<ExerciseEquipment>();
        }

        [MaxLength(TypeMaxLength)]
        public string Type { get; set; }

        public virtual ICollection<ExerciseEquipment> ExerciseEquipments { get; set; }
    }
}
