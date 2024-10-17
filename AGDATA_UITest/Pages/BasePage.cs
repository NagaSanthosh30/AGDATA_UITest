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
        protected IWebDriver Driver;
        private static readonly ILogger log = new LoggerConfiguration()
                                              .WriteTo.Console()
                                              .CreateLogger();

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
        }

        // Reusable method to click on an element
        public void ClickElement(By locator)
        {
            try
            {
                log.Information("Clicking element: {Locator}", locator);
                Driver.FindElement(locator).Click();
            }
            catch (Exception e)
            {
                log.Error("Failed to click element: {Locator}. Error: {ExceptionMessage}", locator, e.Message);
                throw;
            }
        }

        // Reusable method to get text from an element
        public string GetElementText(By locator)
        {
            log.Information("Getting text from element: {Locator}", locator);
            return Driver.FindElement(locator).Text;
        }

        // Reusable method to navigate to a URL
        public void NavigateToUrl(string url)
        {
            log.Information("Navigating to URL: {Url}", url);
            Driver.Navigate().GoToUrl(url);
        }

        // Reusable wait method
        public void WaitForElementToBeClickable(By locator, TimeSpan timeout)
        {
            WebDriverWait wait = new WebDriverWait(Driver, timeout);
            wait.Until(ExpectedConditions.ElementToBeClickable(locator));
        }
       
        }




    }


