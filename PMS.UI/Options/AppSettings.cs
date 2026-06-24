namespace PMS.UI.Options
{
    public class AppSettings
    {
        public string ApiEndpoint { get; set; }
        public int ApiTimeoutInSeconds { get; set; }
        public int DefaultPageSize { get; set; } = 10;
    }
}
