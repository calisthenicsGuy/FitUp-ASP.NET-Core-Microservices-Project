namespace FitUp.DataModel.Helpers.Models
{
    using FitUp.DataModel.Helpers.Models.Interfaces;

    public class BaseModel<TKey> : IBaseModel<TKey>
    {
        public TKey Id { get; set; }
    }
}
