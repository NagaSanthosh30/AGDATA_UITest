using Microsoft.VisualBasic;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using OpenQA.Selenium;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGDATA_UITest.Utilities
{
    public class Logger
    {
        public static void Initialize()
        {
            // Configuring the logger to write to both the console and a file.
            // The log file will be saved under "Logs/testlog.txt", and a new file is created daily.
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
            .WriteTo.File("Logs/testlog.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();
        }

        //Logs an informational message.
        public static void Information(string message)
        {
            // Logs the provided message at the "Information" level.
            Log.Information(message);
        }
        // Logs an error message.
        public static void Error(string message)
        {
            // Logs the provided message at the "Error" level.
            Log.Error(message);
        }

        public static void Close()
        {
            // Closes the logger and flushes any remaining logs to their respective sinks (console or file).
            Log.CloseAndFlush();
        }
    }
}
