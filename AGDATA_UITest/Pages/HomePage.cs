using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGDATA_UITest.Pages
{
    using OpenQA.Selenium;

    public class HomePage : BasePage
    {
        private By solutionsMenu = By.XPath("//a[contains(text(),'Solutions')]");
        private By marketIntelligenceMenu = By.XPath("(//a[contains(text(),'Market Intelligence')])[1]");

        public HomePage(IWebDriver driver) : base(driver) { }

        public void NavigateToMarketIntelligence()
        {
            Click(solutionsMenu);
            WaitUntilElementVisible(marketIntelligenceMenu); // Wait after clicking 'Solutions'
            Click(marketIntelligenceMenu);
           
        }
    }
}
