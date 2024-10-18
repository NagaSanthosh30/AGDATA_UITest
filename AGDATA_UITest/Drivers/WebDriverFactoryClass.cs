using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AGDATA_UITest.Utilities;
using WebDriverManager.DriverConfigs.Impl;

namespace AGDATA_UITest.Drivers
{
    public  class WebDriverFactory
    {
        // Method to create a Chrome WebDriver
        public static IWebDriver CreateDriver()
        {
            // You can also specify options if needed
            var options = new ChromeOptions();
            // Add options if necessary, e.g., headless mode
            // options.AddArgument("--headless");

            return new ChromeDriver(options);
        }
    }
}
