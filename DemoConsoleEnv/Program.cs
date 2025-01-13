using Microsoft.Extensions.Configuration;
using System;

namespace DemoConsoleEnv
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var environment =
                String.IsNullOrEmpty(Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")) ?
                "Development" : Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            var configuration = new ConfigurationBuilder()
               .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
               .AddJsonFile($"appsettings.{environment}.json", optional: true, reloadOnChange: false) // Añade el archivo JSON como opcional para usar en local
               .AddEnvironmentVariables()
               .Build();

            AppConfig.CargarConfiguracion(configuration);

            var database = AppConfig.SUITE_NEPTUNO_DATABASE;
            var logProvider = AppConfig.LOG_PROVIDER;
            
        }
    }
}
