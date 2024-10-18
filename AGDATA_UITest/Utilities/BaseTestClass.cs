using AGDATA_UITest.Drivers;
using AGDATA_UITest.Pages;
using AlexanderOnTest.NetCoreWebDriverFactory.WebDriverFactory;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGDATA_UITest.Utilities
{
    public class BaseTestClass
    {
        protected IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            // Initialize WebDriver (Chrome in this case)
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDown()
        {
            // Dispose of the WebDriver instance
            if (driver != null)
            {
                driver.Quit();
                driver.Dispose();
            }
        }
    }
}
