﻿namespace FitUp.ExercisesService.DataModel.Helpers.Models
{

    using FitUp.ExercisesService.DataModel.Helpers.Models.Interfaces;

    public class BaseInfoModel<TKey> : IBaseModel<TKey>, IInfoModel
    {
        public TKey Id { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }
    }
}
