using B1SLayer;

namespace INVOICES_API.Utils
{
    public sealed class SL
    {
        private static readonly SLConnection slConnection = new SLConnection(
            AppConfig.Configuration["ServiceLayerURL"],
            AppConfig.Configuration["Database"],
            AppConfig.Configuration["B1User"],
            AppConfig.Configuration["B1Password"], 29);

        static SL() { }
        private SL() { }

        public static SLConnection Connection { get { return slConnection; } }
    }
}
