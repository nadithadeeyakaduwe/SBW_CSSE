using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBW.DataAccess
{
    class ConnectionManager
    {
        public static SqlConnection connection;

        public static string connectionString = ConfigurationManager.ConnectionStrings["LocalDB"].ConnectionString;
        public static SqlConnection getConnection()
        {
            if (connection == null)
            {
                connection = new SqlConnection(connectionString);
            }
            return connection;
        }
    }
}
