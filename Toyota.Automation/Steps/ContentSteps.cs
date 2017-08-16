using OpenQA.Selenium;
using System.Diagnostics;
using TechTalk.SpecFlow;
using Toyota.Automation.Repository;

namespace Toyota.Automation
{
    [Binding]
    public class ContentSteps
    {
        private IWebDriver _driver;

        private IBankDetails _bankdetail;
        private IHomeDetails _homedetails;
        private ILoanPurposeDetails _loanpurposdetails;
        private ILoanSetupDetails _loansetupdetails;
        private IPersonalDetails _personaldetail;

        public ContentSteps(IWebDriver driver)
        {
            _driver = driver;
            _bankdetail = new BankDetailsDesktopNLLoc();
            SetHelperDesktop();
            SetHelperMobile();

        }
        [Conditional("DebugLocalFireFox")]
        [Conditional("DebugLocalIE")]
        [Conditional("DebugCloudChrome")]
        [Conditional("DebugCloudFireFox")]
        [Conditional("DebugCloudIE")]
        public void SetHelperDesktop()
        {
            _bankdetail = new BankDetailsDesktopNLLoc();
            _homedetails = new HomeDetailsDesktopNLLoc();
            _loanpurposdetails = new LoanPurposeDetailsDesktopNLLoc();
            _loansetupdetails = new LoanSetupDetailsDesktopNLLoc();
            _personaldetail = new PersonalDetailsDesktopNLLoc();
        }

        [Conditional("DebugLocalAndroid")]
        [Conditional("DebugCloudAndroid")]
        [Conditional("DebugCloudIOS")]
        public void SetHelperMobile()
        {
            _bankdetail = new BankDetailsMobileNLLoc();
            _homedetails = new HomeDetailsMobileNLLoc();
            _loanpurposdetails = new LoanPurposeDetailsMobileNLLoc();
            _loansetupdetails = new LoanSetupDetailsMobileNLLoc();
            _personaldetail = new PersonalDetailsMobileNLLoc();
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
           var val = _bankdetail.AddAnotherBank;
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

        [When(@"The User click on Apply button")]
        public void WhenTheUserClickOnApplyButton()
        {
            _driver.FindElement(_homedetails.linkMenuApply).Click();
        }

        [Then(@"The User Sees StartApplication button")]
        public void ThenTheUserSeesStartApplicationButton()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"The User Selects LoanAmount slider")]
        public void ThenTheUserSelectsLoanAmountSlider()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"The User enters LoanAmount entry")]
        public void ThenTheUserEntersLoanAmountEntry()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"The User click on Continue button")]
        public void ThenTheUserClickOnContinueButton()
        {
            ScenarioContext.Current.Pending();
        }


    }
}
