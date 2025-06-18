using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Security;

namespace InvestigationGame
{
    internal static class DBconnect
    {
        public static MySqlConnection Connect()
        {
            try
            {
                string connectionString = "server = localhost;user = root;database = investigationgame;port = 3306;";
                MySqlConnection connection = new MySqlConnection(connectionString);
                return connection;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while connecting to the database: " + ex.Message);
                return null;
            }
        }
    }
}
