using Microsoft.Extensions.Configuration;
using System;
using System.Data.SqlClient;

namespace DAL
{
    public class LoginService
    {
        private readonly IConfiguration _configuration;

        public LoginService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void YourMethod()
        {
            // Retrieve connection string from appsettings.json
            string connectionString = _configuration.GetConnectionString("DefaultConnection");

            // Create SqlConnection object
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Open the connection
                    connection.Open();

                    // Connection opened successfully, you can perform your database operations here
                }
                catch (SqlException ex)
                {
                    // Handle exceptions
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }
    }
}
