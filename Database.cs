using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Stock_Manage
{

             public class Database
        {
            private string connectionString = "server=localhost;database=inventory_manager;uid=root;pwd=;";

            public MySqlConnection GetConnection()
            {
                return new MySqlConnection(connectionString);
            }
        }
    
}
