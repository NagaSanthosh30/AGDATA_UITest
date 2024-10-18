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
        private By contactHeader = By.XPath("//section[@class='intro_header center-text']//h4[text()='Contact']"); // Adjust the XPath according to the actual header text on the Contact page

        public ContactPage(IWebDriver driver) : base(driver) { }

        // Method to check if the Contact page is loaded
        public bool IsLoaded()
        {
            // Wait until the contact header is visible
            WaitUntilElementVisible(contactHeader);
            // Return true if the header is displayed
            return driver.FindElement(contactHeader).Displayed;
        }
    }
}
