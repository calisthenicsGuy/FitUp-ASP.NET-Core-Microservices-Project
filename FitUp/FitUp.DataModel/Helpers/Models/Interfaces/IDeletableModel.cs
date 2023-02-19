namespace FitUp.DataModel.Helpers.Models.Interfaces
{
    public interface IDeletableModel
    {
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
