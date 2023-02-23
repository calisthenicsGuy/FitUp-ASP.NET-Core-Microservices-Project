namespace FitUp.ExercisesService.DataModel.Data
{
    using FitUp.DataModel.Data;
    using Newtonsoft.Json;

    public class ExercisesAppSettings : BaseAppSettings
    {
        public ExercisesAppSettings(string fileName)
            : base(fileName)
        {
        }
    }
}