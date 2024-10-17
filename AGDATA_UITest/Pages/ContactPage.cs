using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGDATA_UITest.Pages
{
    public class ContactPage : BasePage
    {
        private By contactPageTitle = By.XPath("//section[@class='intro_header center-text']//h4[text()='Contact']");

        public ContactPage(IWebDriver driver) : base(driver) { }

        // Check if the Contact page is displayed
        public bool IsContactPageDisplayed()
        {
            return driver.FindElement(contactPageTitle).Displayed;
            Console.WriteLine("Contact Page is Loaded");
        }
    }
}
