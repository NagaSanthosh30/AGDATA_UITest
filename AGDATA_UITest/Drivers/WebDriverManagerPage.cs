using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGDATA_UITest.Drivers
{
    public class WebDriverManagerPage
    {
        protected IWebDriver Driver;

        [SetUp]
        public void InitializeDriver()
        {
            // Initialize the ChromeDriver
            Driver = new ChromeDriver();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void DisposeDriver()
        {
            // Dispose of the WebDriver instance
            if (Driver != null)
            {
                Driver.Quit(); // Close all browser windows and safely end the session
                Driver.Dispose(); // Release any resources associated with the WebDriver
                Driver = null; // Optionally set to null to avoid referencing disposed objects
            }
        }
    }
}
