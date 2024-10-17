using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGDATA_UITest.Pages
{
    public class MarketIntelligencePage : BasePage
    {
        private By benefitHeadings = By.XPath("//section[@class='services_target_markets three_col_textarea']/div/h3");
        private By letsGetStartedButton = By.XPath("//div[@id='prefooter']//a[text()=\"Let's Get Started\"]");

        public MarketIntelligencePage(IWebDriver driver) : base(driver) { }

        // Get Ways You Benefit section headings
        public List<string> GetWaysYouBenefitHeadings()
        {
            return driver.FindElements(benefitHeadings).Select(heading => heading.Text).ToList();
        }

        // Click on the Let's Get Started button
        public void ClickLetsGetStarted()
        {
            driver.FindElement(letsGetStartedButton).Click();
        }
    }
}
