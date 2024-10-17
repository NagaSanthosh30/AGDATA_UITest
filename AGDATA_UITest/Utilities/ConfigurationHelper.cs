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
            // Set up the configuration to read from appsettings.json
            var builder = new ConfigurationBuilder()
                // Current directory path
                .SetBasePath(Directory.GetCurrentDirectory())
                // Add JSON file to the configuration
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            configuration = builder.Build(); // Build the configuration
        }

        // Property to get BaseUrl
        public static string BaseUrl => configuration["BaseUrl"];

        // Property to get Timeout and convert it to an integer
        public static int Timeout => int.Parse(configuration["Timeout"]);
    }
}
