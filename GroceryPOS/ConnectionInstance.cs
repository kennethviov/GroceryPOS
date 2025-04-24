using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryPOS
{
    internal class ConnectionInstance
    {
        private static ConnectionInstance instance = null;
        private SqlConnection conn;
        private ConnectionInstance() { 
                   conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; Database = protoDB; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False");
        }
        public static ConnectionInstance Instance()
        {
            if (instance == null)
            {
                instance = new ConnectionInstance();
            }
            return instance;
        }
        public SqlConnection getConn()
        {
            return conn;
        }
    }
    
}
