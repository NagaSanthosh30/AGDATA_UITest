using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGDATA_UITest.Utilities
{
    public static class ConfigurationHelper
    {
        private static IConfigurationRoot configuration;

        static ConfigurationHelper()
        {
            // Load configuration from the appsettings.json file
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            configuration = builder.Build();
        }

        public static string GetBaseUrl()
        {
            return configuration["BaseUrl"];
        }

        public static int GetTimeout()
        {
            return int.Parse(configuration["Timeout"]);
        }
    }
}
