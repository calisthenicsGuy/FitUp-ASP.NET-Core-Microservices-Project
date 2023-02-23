namespace FitUp.DataModel.Data
{
    using Newtonsoft.Json;

    public abstract class BaseAppSettings
    {
        public BaseAppSettings(string fileName)
        {
            this.FileName = fileName;
        }

        public string FileName { get; set; }

        public string DefaultConnection => this.ConnectionStrings().DefaultConnection;

        public string DbContextConnection => this.ConnectionStrings().DbContextConnection;

        public AppSettingsSchema GetApplicationSettings()
        {
            string jsonData = File.ReadAllText($@"{this.FileName}");
            return JsonConvert.DeserializeObject<AppSettingsSchema>(jsonData);
        }

        public ConnectionStringsSchema ConnectionStrings()
        {
            AppSettingsSchema appSettingsSchema = this.GetApplicationSettings();
            return appSettingsSchema.ConnectionStrings;
        }
    }

    public class AppSettingsSchema
    {
        public ConnectionStringsSchema ConnectionStrings { get; set; }
    }

    public class ConnectionStringsSchema
    {
        public string DefaultConnection { get; set; }

        public string DbContextConnection { get; set; }
    }
}