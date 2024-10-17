using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGDATA_UITest.Pages
{
    //Common functionalities for page objects are encapsulated here.
    // Calling BasePage Methods
    public class HomePage : BasePage
        // Finding elements using xpath
    {
        private By solutionsMenu = By.XPath("//nav[@class='main-navigation']//a[text()='Solutions']");
        private By marketIntelligenceOption = By.XPath("(//nav[@class='main-navigation']//following::a[text()='Market Intelligence'])[1]");

        public HomePage(IWebDriver driver) : base(driver) { }

        // Navigate to Market Intelligence
        public void GoToMarketIntelligencePage()
        {
            driver.FindElement(solutionsMenu).Click();
            // Wait after clicking Solutions
            WaitUntilElementVisible(marketIntelligenceOption); 
            driver.FindElement(marketIntelligenceOption).Click();
        }
    }
}
