namespace FitUp.DataModel.Data
{
    using Newtonsoft.Json;

    public class AppSettings
    {
        public AppSettings(string fileName, string absoluteFilePath = null)
        {
            this.FileName = fileName;
            this.AbsoluteFilePath = absoluteFilePath;
        }

        public string FileName { get; set; }

        public string AbsoluteFilePath { get; set; }

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

        public string DefaultConnection()
            => this.ConnectionStrings().DefaultConnection;

        public string DbContextConnection()
            => this.ConnectionStrings().DbContextConnection;
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