using System.Configuration;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        // plan now vs plan later = plan now clean code
        public static IDataConnection Connection { get; private set; }
        public static void InitializeConnections(DatabaseType db)
        {
            /* switch tab tab then in the () type db it fills for you left as is for now cuz c# limited
            switch (db)
            {
                case DatabaseType.Sql:
                    break;
                case DatabaseType.TextFile:
                    break;
                default:
                    break;
            } */

            if (db == DatabaseType.Sql)
            {
                // TODO - Set up the SQL connector properly 
                SqlConnector sql = new SqlConnector();
                Connection = sql;

            }
            else if (db == DatabaseType.TextFile)
            {
                // TODO - Create the text connection
                TextConnector text = new TextConnector();
                Connection = text;
            }
        }
        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
