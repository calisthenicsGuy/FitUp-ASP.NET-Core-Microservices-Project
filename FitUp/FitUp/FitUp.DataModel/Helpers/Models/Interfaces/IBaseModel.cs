namespace FitUp.DataModel.Helpers.Models.Interfaces
{
    using System.ComponentModel.DataAnnotations;

    public interface IBaseModel<TKey>
    {
        [Key]
        public TKey Id { get; set; }
    }
}
