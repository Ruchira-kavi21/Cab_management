using FormClass;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabRental
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public static class VerifyLoginUser
    {
        private static string connectionString = $"server=localhost;user=root;password={DatabaseConfig.Password};database=cardb2";

        public static bool VerifyUserCredentials(string username, string password)
        {
            // SQL query to check if the user exists with the provided username and password
            string query = "SELECT COUNT(*) FROM Customers1 WHERE Name = @username AND Password = @password";

            // Establish a connection to the database
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    // Open the connection
                    conn.Open();

                    // Create a command with the query and the connection
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        //parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        // Execute the query and get the result
                        int userCount = Convert.ToInt32(cmd.ExecuteScalar());

                        // If userCount is greater than 0, the user exists
                        return userCount > 0;
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
