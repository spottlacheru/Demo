using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace Toyota.Automation
{
    [Binding]
    public class ContentSteps
    {
        private IWebDriver _driver;

        public ContentSteps(IWebDriver driver)
        {
            _driver = driver;
        }


        [Given(@"The User has Launched URL")]
        public void GivenTheUserHasLaunchedURL()
        {
            _driver.Navigate().GoToUrl("https://www.google.com.au");
            System.Threading.Thread.Sleep(30000);
        }

        [When(@"The User click on ""(.*)"" button")]
        public void WhenTheUserClickOnButton(string p0)
        {
           
        }

        [Then(@"The Page Navigates to ""(.*)"" page")]
        public void ThenThePageNavigatesToPage(string p0)
        {
           
        }

        [Then(@"The User Sees ""(.*)"" image")]
        public void ThenTheUserSeesImage(string p0)
        {
           
        }

        [Then(@"The User Sees ""(.*)"" table")]
        public void ThenTheUserSeesTable(string p0)
        {
           
        }

        [Then(@"The User Sees ""(.*)"" button")]
        public void ThenTheUserSeesButton(string p0)
        {
           
        }

        [Then(@"The User enters """"(.*)"""" entry")]
        public void ThenTheUserEntersEntry(string p0)
        {
           
        }


    }
}
