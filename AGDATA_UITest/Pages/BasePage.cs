using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace AGDATA_UITest.Pages
{


    public class BasePage
    {
        protected IWebDriver driver;
        protected WebDriverWait wait;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        // Wait until an element is visible
        public void WaitUntilElementVisible(By locator)
        {
            wait.Until(driver => driver.FindElement(locator).Displayed);
        }

        // Click method with wait
        public void Click(By locator)
        {
            WaitUntilElementVisible(locator);
            driver.FindElement(locator).Click();
        }
    }
}


