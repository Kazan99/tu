using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class DBUtils
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "127.0.0.1";
            int port = 3306;
            string database = "bui_hoang";
            string username = "root";
            string password = "Talata99";

            return DBMySQLUtils.GetDBConnection(host, port, database, username, password);
        }
    }
}
