using AGDATA_UITest.Drivers;
using AGDATA_UITest.Pages;
using AGDATA_UITest.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AGDATA_UITest.Test
{
    [TestFixture]
    public class UITest : BaseTestClass
    {
        private HomePage homePage;
        private MarketIntelligencePage marketIntelligencePage;
        private ContactPage contactPage;

        [SetUp]
        public void Setup()
        {
            homePage = new HomePage(driver);
            marketIntelligencePage = new MarketIntelligencePage(driver);
            contactPage = new ContactPage(driver);
        }

        [Test]
        public void ValidateMarketIntelligenceWorkflow()
        {
            // Navigate to Market Intelligence
            driver.Navigate().GoToUrl("https://www.agdata.com");
            homePage.NavigateToMarketIntelligence();

            // Get the headings from the "Ways You Benefit" section
            var headings = marketIntelligencePage.GetHeadings();

            // Assert the headings are present
            Assert.That(headings.Contains("MINIMIZE COSTS"), Is.True, "Minimize Costs heading not found");
            Assert.That(headings.Contains("GENERATE REVENUE"), Is.True, "Generate Revenue heading not found");
            Assert.That(headings.Contains("MITIGATE RISK"), Is.True, "Mitigate Risk heading not found");

            


            // Click on "Let's Get Started"
            marketIntelligencePage.ClickLetsGetStarted();

            // Validate the 'Contact' page is displayed/loaded
            Assert.That(contactPage.IsLoaded(), Is.True, "Contact page not displayed after clicking Let's Get Started.");
        }

        
    }
}


