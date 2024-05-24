namespace INVOICES_API
{
    public static class AppConfig
    {
        public static IConfiguration Configuration { get; }

        static AppConfig()
        {
            Configuration = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .Build();
        }
    }
}
