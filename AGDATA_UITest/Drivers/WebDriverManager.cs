using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGDATA_UITest.Drivers
{
    // This class handles browser initialization and cleanup.
    public class WebDriverManager
    {
        private IWebDriver driver;

        public IWebDriver GetWebDriver()
        {
            if (driver != null) return driver;

            // Initialize Chrome browser
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            // Implicit wait setup
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);  
            return driver;
        }

        public void QuitWebDriver()
        {
            if (driver != null)
            {
                driver.Quit();
                driver = null;
            }
        }
    }
}
