using DAL.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace DAL
{
    public class LoginService
    {
        private readonly IConfiguration _configuration;

        public LoginService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public static List<TblUserType> GetUserType()
        {
            using (var db = new SandboxContext())
            {
                var data = db.TblUserTypes.ToList();
                return data;
            }
        }

        //public static CreateUser()

        public void YourMethod()
        {
            string connectionString = _configuration.GetConnectionString("DefaultConnection");
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
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
