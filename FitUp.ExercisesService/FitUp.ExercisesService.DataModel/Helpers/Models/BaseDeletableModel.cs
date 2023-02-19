namespace FitUp.ExercisesService.DataModel.Helpers.Models
{
    using FitUp.ExercisesService.DataModel.Helpers.Models.Interfaces;

    public class BaseDeletableModel<TKey> : IBaseModel<TKey>, IDeletableModel
    {
        public TKey Id { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
