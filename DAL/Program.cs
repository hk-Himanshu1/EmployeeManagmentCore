using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.IO;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            // Retrieve IConfiguration instance
            var configuration = host.Services.GetRequiredService<IConfiguration>();

            // Create an instance of YourClass, passing IConfiguration
            var yourClass = ActivatorUtilities.CreateInstance<DBContext>(host.Services, configuration);

            // Call a method on YourClass that uses the configuration
            yourClass.YourMethod();
            host.Run();
        }

        static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((hostingContext, config) =>
                {
                    config.SetBasePath(Directory.GetCurrentDirectory());
                    config.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                });
    }

    public class DBContext
    {
        private readonly IConfiguration _configuration;

        public DBContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void YourMethod()
        {
            // Use _configuration to access configuration settings
        }
    }
}
