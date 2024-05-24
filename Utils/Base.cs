namespace INVOICES_API.Utils
{
    public class Base
	{
		public static string Database;

		public static string DatabaseInvent;

		public IDAO DAO
		{
			get;
			set;
		}

		public IDAO DAOInvent
		{
			get;
			set;
		}

		static Base()
		{
			Base.Database = AppConfig.Configuration["Database"];
			Base.DatabaseInvent = AppConfig.Configuration["DatabaseInvent"];
		}

		public Base()
		{
			this.DAO = new HanaDAO();
		}
	}
}