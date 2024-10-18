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
        private By waysYouBenefitHeadings = By.XPath("//section[@class='services_target_markets three_col_textarea']/div/h3");
        private By letsGetStartedButton = By.XPath("//div[@id='prefooter']//a[text()=\"Let's Get Started\"]");

        public MarketIntelligencePage(IWebDriver driver) : base(driver) { }

        // Get the headings from the "Ways You Benefit" section
        public IList<string> GetHeadings()
        {
            WaitUntilElementVisible(waysYouBenefitHeadings);
            var headings = driver.FindElements(waysYouBenefitHeadings);
            return headings.Select(h => h.Text).ToList(); // Return headings as a list

            foreach (var heading in headings)
            {
                Console.WriteLine("Heading: " + heading);
            }
        }

        // Click on "Let's Get Started" button
        public void ClickLetsGetStarted()
        {
            Click(letsGetStartedButton);
        }
    }
}
