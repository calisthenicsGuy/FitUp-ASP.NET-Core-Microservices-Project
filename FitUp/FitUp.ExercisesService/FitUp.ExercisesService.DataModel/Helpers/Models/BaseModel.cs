namespace FitUp.ExercisesService.DataModel.Helpers.Models
{
    using FitUp.ExercisesService.DataModel.Helpers.Models.Interfaces;

    public class BaseModel<TKey> : IBaseModel<TKey>
    {
        public TKey Id { get; set; }
    }
}
