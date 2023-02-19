namespace FitUp.DataModel.Helpers.Models
{
    using FitUp.DataModel.Helpers.Models.Interfaces;

    public class FullModel<TKey> : IBaseModel<TKey>, IDeletableModel, IInfoModel
    {
        public TKey Id { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }
    }
}
