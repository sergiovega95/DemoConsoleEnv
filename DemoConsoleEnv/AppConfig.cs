using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsoleEnv
{
    public class AppConfig
    {
        public static string ENVIROMENT { get; set; }
        public static string LOG_PROVIDER { get; set; }
        public static string FILE_PROVIDER { get; set; }
        public static string ClAMAV_ANTIVIRUS_URL { get; set; }
        public static string TEMPORAL_FILES_SAVE_PATH { get; set; }
        public static string FILES_SAVE_PATH { get; set; }
        public static string AZURE_BLOB_STORAGE_CONNECTION_STRING { get; set; }
        public static string SUITE_NEPTUNO_DATABASE { get; set; }
        public static string AUDIT_DATABASE { get; set; }
        public static string MJ_APIKEY_PUBLIC { get; set; }
        public static string MJ_APIKEY_PRIVATE { get; set; }
        public static string MUNICIPIO { get; set; }
        public static string CRONJOB { get; set; }

        public static void CargarConfiguracion(IConfiguration configuration)
        {
            LOG_PROVIDER = configuration.GetSection("LOG_PROVIDER").Value;
            FILE_PROVIDER = configuration.GetSection("FILE_PROVIDER").Value;
            ClAMAV_ANTIVIRUS_URL = configuration.GetSection("ClAMAV_ANTIVIRUS_URL").Value;
            TEMPORAL_FILES_SAVE_PATH = configuration.GetSection("TEMPORAL_FILES_SAVE_PATH").Value;
            FILES_SAVE_PATH = configuration.GetSection("FILES_SAVE_PATH").Value;
            AZURE_BLOB_STORAGE_CONNECTION_STRING = configuration.GetSection("AZURE_BLOB_STORAGE_CONNECTION_STRING").Value;
            SUITE_NEPTUNO_DATABASE= configuration.GetSection("SUITE_NEPTUNO_DATABASE").Value;
            AUDIT_DATABASE = configuration.GetSection("AUDIT_DATABASE").Value;
            MJ_APIKEY_PUBLIC = configuration.GetSection("MJ_APIKEY_PUBLIC").Value;
            MJ_APIKEY_PRIVATE = configuration.GetSection("MJ_APIKEY_PRIVATE").Value;
            MUNICIPIO = configuration.GetSection("MUNICIPIO").Value;
            CRONJOB = configuration.GetSection("CRONJOB").Value;
            ENVIROMENT = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
        }
    }
   
}
