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
        //--------------------------------indraja----------------//
        

        

        

       

        

        

        

        

        

        

        [Given(@"Navigate to URL")]
        public void GivenNavigateToURL()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Click on Apply button\.")]
        public void ThenClickOnApplyButton_()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Click on Start application button\.")]
        public void ThenClickOnStartApplicationButton_()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Select loan Amount \(MAAC(.*)\)")]
        public void ThenSelectLoanAmountMAAC(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Select purpose of loan \(Households\)")]
        public void ThenSelectPurposeOfLoanHouseholds()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Enter purpose of loan amount \(MAAC(.*)\)")]
        public void ThenEnterPurposeOfLoanAmountMAAC(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Enter Personal Details & contact details")]
        public void ThenEnterPersonalDetailsContactDetails()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Select bank \(Dag bank\)\.")]
        public void ThenSelectBankDagBank_()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Enter bank credentials")]
        public void ThenEnterBankCredentials()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Choose bank account")]
        public void ThenChooseBankAccount()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Enter bank details \(BSB- (.*) , Account no (.*) - ,Account name- TestUser\)")]
        public void ThenEnterBankDetailsBSB_AccountNo_AccountName_TestUser(int p0, int p1)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Select Income Category \(Primary income\)")]
        public void ThenSelectIncomeCategoryPrimaryIncome()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Select Other Debt Repayments Option as \(No\)")]
        public void ThenSelectOtherDebtRepaymentsOptionAsNo()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Select Dependents List as \((.*)\)")]
        public void ThenSelectDependentsListAs(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Click Govt\. Benefits Options List as \(NO\)")]
        public void ThenClickGovt_BenefitsOptionsListAsNO()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Click Agree App Submit Button")]
        public void ThenClickAgreeAppSubmitButton()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Verify SMS OTP\.")]
        public void ThenVerifySMSOTP_()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Verify loan Amount with Approved amount")]
        public void ThenVerifyLoanAmountWithApprovedAmount()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Choose Loan Amount Slider \((.*)\)")]
        public void ThenChooseLoanAmountSlider(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Choose Frequency \(Fortnightly\)")]
        public void ThenChooseFrequencyFortnightly()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Change First Repayment Date \(loanAmount\)")]
        public void ThenChangeFirstRepaymentDateLoanAmount()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Move Slider Middle Amount RL \((.*)\)")]
        public void ThenMoveSliderMiddleAmountRL(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Click Detailed Repayment Schedule\.")]
        public void ThenClickDetailedRepaymentSchedule_()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Verify first date")]
        public void ThenVerifyFirstDate()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Verify last Date")]
        public void ThenVerifyLastDate()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Verify repayment Amount")]
        public void ThenVerifyRepaymentAmount()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Verify no of repayments count")]
        public void ThenVerifyNoOfRepaymentsCount()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Verify repayment schedule amount")]
        public void ThenVerifyRepaymentScheduleAmount()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Getting a list of repayment count\.")]
        public void ThenGettingAListOfRepaymentCount_()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Select Spend less Reason")]
        public void ThenSelectSpendLessReason()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Click on Loan contract")]
        public void ThenClickOnLoanContract()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Click on Confirm Accepting Contract")]
        public void ThenClickOnConfirmAcceptingContract()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Click On Agree Button")]
        public void ThenClickOnAgreeButton()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Click on No-thanks Button")]
        public void ThenClickOnNo_ThanksButton()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Click on Loan Dashboard Button")]
        public void ThenClickOnLoanDashboardButton()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Click on Logout Button")]
        public void ThenClickOnLogoutButton()
        {
            ScenarioContext.Current.Pending();
        }


    }
}
