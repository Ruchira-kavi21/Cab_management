using FormClass;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabRental
{
    public class Driver1
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
    public static class VerifyLoginDriver
    {
        private static string connectionString = $"server=localhost;user=root;password={DatabaseConfig.Password};database=cardb2";

        public static bool VerifyDriverCredentials(string username, string password)
        {

            string query = "SELECT COUNT(*) FROM Drivers1 WHERE Name = @username AND Password = @password";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        int driverCount = Convert.ToInt32(cmd.ExecuteScalar());
                        return driverCount > 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }
        }

    }
}
