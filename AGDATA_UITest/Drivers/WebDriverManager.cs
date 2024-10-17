using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGDATA_UITest.Drivers
{
    // To Handle WebDriver instantiation and configuration
    public class WebDriverManager
    {
        public IWebDriver CreateDriver()
        {
            // For ChromeDriver adding implicit wait for 10seconds
            var driver = new ChromeDriver();  
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            return driver;
        }
    }

}
