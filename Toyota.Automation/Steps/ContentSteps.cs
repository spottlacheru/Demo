using OpenQA.Selenium;
using System.Diagnostics;
using TechTalk.SpecFlow;
using Toyota.Automation.Repository;
using System;
using System.Threading;
using System.Text;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Toyota.Automation
{
    [Binding]
    public class ContentSteps
    {
        private IWebDriver _driver;
        private ActionEngine _act = null;
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
            _driver.Navigate().GoToUrl("https://staging.inator.com.au/");
            Thread.Sleep(30000);
        }

        [When(@"The User click on Apply button")]
        public void WhenTheUserClickOnApplyButton()
        {        
            _act.waitForVisibilityOfElement(_homedetails.linkMenuApply, 60);
            _act.click(_homedetails.linkMenuApply, "ApplyLinkBtn");
       
        }

        [Then(@"Click on Start application button\.")]
        public void ThenClickOnStartApplicationButton_()
        {
            _act.waitForVisibilityOfElement(_homedetails.btnstartApplication, 60);
            _act.click(_homedetails.btnstartApplication, "btnstartApplication");
        }

        [Then(@"Select loan Amount \(MAAC(.*)\)")]
        public void ThenSelectLoanAmountMAAC(int p0, string POL)
        {
            RequestLoanAmount(1800, "Household goods and furniture");
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
            _act.waitForVisibilityOfElement(_bankdetail.BankName, 120);
            _act.selectByOptionText(_bankdetail.BankName, "Dagbank", "Bank");
            _act.waitForVisibilityOfElement(_bankdetail.YodleeContinueButton, 30);
            _act.click(_bankdetail.YodleeContinueButton, "YodleeContinueButton");
        }

        [Then(@"Enter bank credentials")]
        public void ThenEnterBankCredentials()
        {
            _act.waitForVisibilityOfElement(_bankdetail.BankUsername, 50);
            _act.EnterText(_bankdetail.BankUsername, "WebUITest.bank2");
            _act.EnterText(_bankdetail.BankPassword, "bank2");
            _act.waitForVisibilityOfElement(_bankdetail.verifyautocontinuebutton, 200);
            _act.click(_bankdetail.verifyautocontinuebutton, "BankContinueBtn");
        }

        [Then(@"Choose bank account")]
        public void ThenChooseBankAccount()
        {
            _act.waitForVisibilityOfElement(_bankdetail.BankSelectRBtnExact, 200);
            _act.JSClick(_bankdetail.BankSelectRBtnExact, "BankSelectRBtnExact");
            _act.waitForVisibilityOfElement(_bankdetail.btnSelectAccount, 200);
            _act.click(_bankdetail.btnSelectAccount, "btnSelectAccount");
        }

        [Then(@"Enter bank details \(BSB- (.*) , Account no (.*) - ,Account name- TestUser\)")]
        public void ThenEnterBankDetailsBSB_AccountNo_AccountName_TestUser(int p0, int p1)
        {
            _act.waitForVisibilityOfElement(_bankdetail.BSB, 60);
            _act.EnterText(_bankdetail.BSB, "012004");
            _act.EnterText(_bankdetail.AccountNumber, "123456789");
            _act.EnterText(_bankdetail.NameonAccount, "TestUser");
            _act.waitForVisibilityOfElement(_bankdetail.ContinueConfirmAcctDetails, 60);
            _act.click(_bankdetail.ContinueConfirmAcctDetails, "DetailsContinueButton");
        }

        [Then(@"Select Income Category \(Primary income\)")]
        public void ThenSelectIncomeCategoryPrimaryIncome()
        {
            _act.waitForVisibilityOfElement(_bankdetail.IncomeCategory, 200);
            _act.selectByOptionText(_bankdetail.IncomeCategory, "PrimaryIncome", "IncomeCategory");
            _act.waitForVisibilityOfElement(_bankdetail.ConfirmIncomeButton, 60);
            _act.click(_bankdetail.ConfirmIncomeButton, "ConfirmIncomeButton");
        }

        [Then(@"Select Other Debt Repayments Option as \(No\)")]
        public void ThenSelectOtherDebtRepaymentsOptionAsNo()
        {
            _act.waitForVisibilityOfElement(_bankdetail.OtherDebtLiabilitiesoption, 120);
            _act.JSClick(_bankdetail.OtherDebtLiabilitiesoption, "OtherDebtLiabilitiesoption");
        }
        [Then(@"Select Dependents List as \((.*)\)")]
        public void ThenSelectDependentsListAs(int p0)
        {
            _act.waitForVisibilityOfElement(_bankdetail.Dependants, 60);
            _act.selectByOptionText(_bankdetail.Dependants, "Zero", "Dependants");
            _act.waitForVisibilityOfElement(_bankdetail.BtnConfirmExpenses, 60);
            _act.click(_bankdetail.BtnConfirmExpenses, "BtnConfirmExpenses");
        }

        [Then(@"Click Govt\. Benefits Options List as \(NO\)")]
        public void ThenClickGovt_BenefitsOptionsListAsNO()
        {
            _act.waitForVisibilityOfElement(_bankdetail.GovtBenefits, 60);
            _act.JSClick(_bankdetail.GovtBenefits, "GovtBenefits");
        }

        [Then(@"Click Agree App Submit Button")]
        public void ThenClickAgreeAppSubmitButton()
        {
            _act.waitForVisibilityOfElement(_bankdetail.AgreeApplicationsubmit, 60);
            _act.click(_bankdetail.AgreeApplicationsubmit, "AgreeApplicationsubmit");
        }

        [Then(@"Verify SMS OTP\.")]
        public void ThenVerifySMSOTP_()
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

        [Then(@"Verify Approved Amount with Applied Amount ""(.*)""")]
        public void ThenVerifyApprovedAmountWithAppliedAmount(int p0)
        {
           //\\Verify Assert
        }


        [Then(@"Choose Loan Amount Slider \((.*)\)")]
        public void ThenChooseLoanAmountSlider(int p0)
        {
            //    _act.waitForVisibilityOfElement(_loansetupdetails.loanSlider, 200);

            //    //Get the slider max value

            //    //string value= _act.getText(_loansetupdetailsLoc.MinLoanAmt, "");
            //    //var split = value.Split('$');
            //    //string minValue = split[1];
            //    //min will always be 300

            //    string value1 = _act.getText(_loansetupdetails.MaxLoanAmt, "");
            //    var split1 = value1.Split('$');
            //    string maxValue = split1[1].Replace(",", "");
            //    int a = Convert.ToInt32(maxValue);
            //    int b = 300;
            //    int middleamount;
            //    if (a < 1600)
            //        middleamount = (a - b) / 25;//you vll get 50 here
            //    else
            //        middleamount = (a - b) / 50;

            //    IWebElement sliderEle = _driver.FindElement(_loansetupdetails.loanSlider);
            //    _act.click(_loansetupdetails.loanSlider, "slider");

            //    for (int i = 1; i <= middleamount; i++)
            //    {
            //        string actualValue = _act.getText(_loansetupdetails.LoanAmountSlider, "");
            //        int actualValueInt = Convert.ToInt32(actualValue.Replace("$", "").Replace(",", ""));

            //        //then compare the value with your desired value
            //        if (desiredvalue == actualValueInt)
            //        {
            //            break;
            //        }

            //        sliderEle.SendKeys(Keys.ArrowLeft);

            //    }
            //    Thread.Sleep(4000);
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

        public void RequestLoanAmount(int requestedAmount, string loanpurpose)
        {
            //select loan value from slider
            _act.waitForVisibilityOfElement(By.XPath(".//*[@class='ui-slider-handle ui-state-default ui-corner-all']"), 20);
            IWebElement sliderEle = _driver.FindElement(By.XPath(".//*[@class='ui-slider-handle ui-state-default ui-corner-all']"));
            _act.click(By.XPath(".//*[@class='ui-slider-handle ui-state-default ui-corner-all']"), "click");
            if (requestedAmount > 1600 && requestedAmount <= 5000)
            {
                int actualvalue = requestedAmount - 1600;
                int rightclicks = (actualvalue) / 50;
                for (int i = 1; i <= rightclicks; i++)
                {
                    sliderEle.SendKeys(Keys.ArrowRight);

                }
            }
            else if (requestedAmount < 1600 && requestedAmount > 300)
            {
                int actualvalue = 1600 - requestedAmount;
                int leftclicks = (actualvalue) / 50;
                for (int i = 1; i <= leftclicks; i++)
                {
                    sliderEle.SendKeys(Keys.ArrowLeft);
                }
            }

            // click on first POL dropdown
            _act.click(By.XPath("(//span[text()='- select purpose -'])[last()-2]"), "first purpose");

            // select first POL from popup
            if (loanpurpose.Contains(","))
            {
                var purpose = loanpurpose.Split(',');
                foreach (var loan in purpose)
                {
                    IWebElement selectedPOL = _driver.FindElement(By.XPath("//*[@id='POLOptions']//div/label[contains(text(),'" + loan + "')]/preceding-sibling::div"));
                    string classtextwhenchecked = selectedPOL.GetAttribute("class");
                    //  if (!classtextwhenchecked.Contains("checked"))
                    //  {
                    var polpurpose = By.XPath("//*[@id='POLOptions']//div/label[contains(text(),'" + loan + "')]/preceding-sibling::div");
                    //    Thread.Sleep(3000);
                    _act.JSClick(polpurpose, "selectpurpose");
                    //   Thread.Sleep(3000);
                    // }
                }
                if (loanpurpose == "Other,Anything else")
                {
                    _act.EnterText(By.XPath("//*[@class='polMoreDetails']"), "Secret it is");
                }
                _act.JSClick(By.XPath(".//*[@id='purpose-done-btn2']"), "BtnPurposeLoan");
            }
            else
            {
                IWebElement selectedPOL = _driver.FindElement(By.XPath("//*[@id='POLOptions']//div/label[contains(text(),'" + loanpurpose + "')]/preceding-sibling::div"));
                string classtextwhenchecked = selectedPOL.GetAttribute("class");
                //  if (!classtextwhenchecked.Contains("checked"))
                //  {
                var polpurpose = By.XPath("//*[@id='POLOptions']//div/label[contains(text(),'" + loanpurpose + "')]/preceding-sibling::div");
                //   Thread.Sleep(3000);
                _act.JSClick(polpurpose, "selectpurpose");
                // Thread.Sleep(3000);
                //  }
                //  Thread.Sleep(3000);
                if (loanpurpose == "Other,Anything else")
                {
                    _act.EnterText(By.XPath("//*[@class='polMoreDetails']"), "Secret it is");
                }
                _act.JSClick(By.XPath(".//*[@id='purpose-done-btn2']"), "BtnPurposeLoan");
            }

            // enter first POL loan amount
            _act.EnterText(By.XPath("(.//*[@type='number'])[last()-2]"), requestedAmount.ToString());

            //click on continue button
            _act.click(By.XPath(".//*[@id='btnPOLsCompleted']"), "continue");

            if (loanpurpose.Contains("Utility bills"))
            {
                if (_act.isElementPresent(By.XPath("//span[text()='More information']")))
                {
                    _act.waitForVisibilityOfElement(By.XPath("//span[text()='More information']"), 60);
                    _act.EnterText(By.XPath("//*[@name='poloverallmoreinfo']"), "hi hello");
                    // click on MoreInfo continue Button
                    _act.click(By.XPath("//*[@class='button-continue button sml button']"), "MoreInfoContinue");
                }
            }

        }

        public PersonalDetailsDataObj PopulatePersonalDetails()
        {
            PersonalDetailsDataObj _obj = new PersonalDetailsDataObj();
            _obj.FirstName = RandomString(12);
            _obj.Email = RandomEmail();

            string Password = "password";
            _act.waitForVisibilityOfElement(_personaldetail.Title, 60);
            _act.selectByOptionText(_personaldetail.Title, RandomTitle(), "Title");
            Thread.Sleep(2000); //required for title select
            _act.EnterText(_personaldetail.FirstName, _obj.FirstName);
            _act.EnterText(_personaldetail.MiddleName, RandomString(12));
            _act.EnterText(_personaldetail.LastName, RandomString(12));
            if (GetPlatform(_driver))
            {
                _act.selectByOptionText(_personaldetail.Dob_Day, RandomDay(), "Day");
                _act.selectByOptionText(_personaldetail.Dob_Month, RandomMonth(), "Month");
                _act.selectByOptionText(_personaldetail.Dob_Year, RandomYear(), "Year");
            }
            else
            {
                _act.EnterText(_personaldetail.DOB, GetRandomDOB());
            }
            _act.EnterText(_personaldetail.Email, _obj.Email);
            _act.EnterText(_personaldetail.Password, Password);
            _act.EnterText(_personaldetail.ConfirmPassword, Password);
            string email = _driver.FindElement(_personaldetail.Email).GetAttribute("value");
            Console.WriteLine(email);
            if (GetPlatform(_driver))
            {
                _act.click(_personaldetail.Next2Button, "clickContinueButtonAfterEmail");
            }
            _act.EnterText(_personaldetail.Homephone, "0" + RandomNumber(9));
            _act.EnterText(_personaldetail.Mobilephone, "04" + RandomNumber(8));
            if (GetPlatform(_driver))
            {
                _act.click(_personaldetail.Address, "Address");
                _act.waitForVisibilityOfElement(_personaldetail.AddressSearch, 60);
                _act.EnterText(_personaldetail.AddressSearch, "TestAddress#");
                IWebElement AddressAutofill = _driver.FindElement(_personaldetail.AddressAutoFillBtn);
                // if(_act.isElementDisplayed(AddressAutofill))
                if (_act.isElementPresent(_personaldetail.AddressAutoFillBtn))
                {
                    _act.click(_personaldetail.AddressAutoFillBtn, "AddressAutoFillBtn");
                }
            }
            else
            {
                _act.EnterText(_personaldetail.Address, "TestAddress#");
                _act.waitForVisibilityOfElement(_personaldetail.AddressAutoFillBtn, 60);
                IWebElement AddressAutofill = _driver.FindElement(_personaldetail.AddressAutoFillBtn);
                if (_act.isElementDisplayed(AddressAutofill))
                {
                    _act.click(_personaldetail.AddressAutoFillBtn, "AddressAutoFillBtn");
                }
            }
            _act.waitForVisibilityOfElement(_personaldetail.Unitnumber, 60);
            Thread.Sleep(1000);
            _act.EnterText(_personaldetail.Unitnumber, RandomNumber(3));
            Thread.Sleep(1000);
            _act.EnterText(_personaldetail.Streetnumber, RandomNumber(3));
            Thread.Sleep(1000);
            _act.EnterText(_personaldetail.StreetName, "At:N Cr:A Id:100 Rr1:A Rr2:A Rr3:A Rmsrv:0.9999");
            _act.EnterText(_personaldetail.Streettype, RandomStreeType());
            int index = Convert.ToInt32(RandomNumber(2));
            _act.EnterText(_personaldetail.Suburbtype, RandomSubrubPostCode(index, 0));
            _act.EnterText(_personaldetail.Postcode, RandomSubrubPostCode(index, 1));
            if (GetPlatform(_driver))
            {
                _act.click(_personaldetail.Next3Button, "clickContinueButtonAfterStreetName");
            }
            _act.waitForVisibilityOfElement(_personaldetail.EmploymentStatus, 30);
            _act.selectByOptionText(_personaldetail.EmploymentStatus, "Full Time", "EmploymentStatus");
            _act.JSClick(_personaldetail.ShortTermLoanStatusNo, "ShortTermLoanStatusNo");
            CheckReadPrivacyBtn("New");
            CheckReadCreditBtn("New");
            _act.click(_personaldetail.personaldetailscontinuebutton, "personaldetailscontinuebutton");


           

            return _obj;
        }

        public async void PopulatePersonalDetails(PersonalDetailsDataObj _perData)
        {
            //check if object is null if not assign value
            PersonalDetailsDataObj _personalData = VerifyObj(_perData);

            _act.waitForVisibilityOfElement(_personaldetail.Title, 60);
            _act.selectByOptionText(_personaldetail.Title, _personalData.Title, "Title");
            Thread.Sleep(2000); // Required for Title select
            _act.EnterText(_personaldetail.FirstName, _personalData.FirstName);
            _act.EnterText(_personaldetail.MiddleName, _personalData.MiddleName);
            _act.EnterText(_personaldetail.LastName, _personalData.LastName);
            if (GetPlatform(_driver))
            {
                _act.selectByOptionText(_personaldetail.Dob_Day, _personalData.DOB_Day, "Day");
                _act.selectByOptionText(_personaldetail.Dob_Month, _personalData.DOB_Month, "Month");
                _act.selectByOptionText(_personaldetail.Dob_Year, _personalData.DOB_Year, "Year");
            }
            else
            {
                _act.EnterText(_personaldetail.DOB, _personalData.DOB);
            }
            _act.EnterText(_personaldetail.Email, _personalData.Email);
            _act.EnterText(_personaldetail.Password, _personalData.Password);
            _act.EnterText(_personaldetail.ConfirmPassword, _personalData.ConfirmPassword);
            string email = _driver.FindElement(_personaldetail.Email).GetAttribute("value");
            Console.WriteLine(email);
            if (GetPlatform(_driver))
            {
                _act.click(_personaldetail.Next2Button, "clickContinueButtonAfterEmail");
            }
            _act.EnterText(_personaldetail.Homephone, _personalData.HomePhone);
            _act.EnterText(_personaldetail.Mobilephone, _personalData.MobilePhone);
            if (GetPlatform(_driver))
            {
                _act.click(_personaldetail.Address, "Address");
                _act.waitForVisibilityOfElement(_personaldetail.AddressSearch, 60);
                _act.EnterText(_personaldetail.AddressSearch, "TestAddress#");
                IWebElement AddressAutofill = _driver.FindElement(_personaldetail.AddressAutoFillBtn);
                // if(_act.isElementDisplayed(AddressAutofill))
                if (_act.isElementPresent(_personaldetail.AddressAutoFillBtn))
                {
                    _act.click(_personaldetail.AddressAutoFillBtn, "AddressAutoFillBtn");
                }
            }
            else
            {
                _act.EnterText(_personaldetail.Address, "TestAddress#");
                _act.waitForVisibilityOfElement(_personaldetail.AddressAutoFillBtn, 60);
                IWebElement AddressAutofill = _driver.FindElement(_personaldetail.AddressAutoFillBtn);
                if (_act.isElementDisplayed(AddressAutofill))
                {
                    _act.click(_personaldetail.AddressAutoFillBtn, "AddressAutoFillBtn");
                }
            }
            _act.waitForVisibilityOfElement(_personaldetail.Unitnumber, 20);
            _act.EnterText(_personaldetail.Unitnumber, _personalData.UnitNumber);
            Thread.Sleep(1000);
            _act.EnterText(_personaldetail.Streetnumber, _personalData.StreetNumber);
            Thread.Sleep(1000);
            _act.EnterText(_personaldetail.StreetName, _personalData.StreetName + _personalData.Rmsrvcode);
            _act.EnterText(_personaldetail.Streettype, _personalData.StreetType);
            _act.EnterText(_personaldetail.Suburbtype, _personalData.Suburb);
            _act.EnterText(_personaldetail.Postcode, _personalData.PostCode);

            if (GetPlatform(_driver))
            {
                _act.click(_personaldetail.Next3Button, "clickContinueButtonAfterStreetName");
            }
            _act.selectByOptionText(_personaldetail.EmploymentStatus, _personalData.EmploymentStatus, "EmploymentStatus");
            if (_personalData.Have2SACCLoan == "Yes")
            {
                _act.click(_personaldetail.ShortTermLoanStatusYes, "ShortTermLoanStatusYes");
            }
            else
            {
                _act.click(_personaldetail.ShortTermLoanStatusNo, "ShortTermLoanStatusNo");
            }
            CheckReadPrivacyBtn(_personalData.UserType);
            CheckReadCreditBtn(_personalData.UserType);

            _act.click(_personaldetail.personaldetailscontinuebutton, "personaldetailscontinuebutton");

          
        }

        public PersonalDetailsDataObj VerifyObj(PersonalDetailsDataObj _obj)
        {
            PersonalDetailsDataObj _object = new PersonalDetailsDataObj();
            _object.Title = (_obj.Title == null) ? RandomTitle() : _obj.Title;
            _object.FirstName = (_obj.FirstName == null) ? RandomString(12) : _obj.FirstName;
            _object.MiddleName = (_obj.MiddleName == null) ? RandomString(4) : _obj.MiddleName;
            _object.LastName = (_obj.LastName == null) ? RandomString(4) : _obj.LastName;
            _object.DOB = (_obj.DOB == null) ? GetRandomDOB() : _obj.DOB;
            _object.DOB_Day = (_obj.DOB_Day == null) ? RandomDay() : _obj.DOB_Day;
            _object.DOB_Month = (_obj.DOB_Month == null) ? RandomMonth() : _obj.DOB_Month;
            _object.DOB_Year = (_obj.DOB_Year == null) ? RandomYear() : _obj.DOB_Year;
            _object.Email = (_obj.Email == null) ? RandomEmail() : _obj.Email;
            _object.Password = (_obj.Password == null) ? "password" : _obj.Password;
            _object.ConfirmPassword = (_obj.ConfirmPassword == null) ? "password" : _obj.ConfirmPassword;
            _object.HomePhone = (_obj.HomePhone == null) ? "0" + RandomNumber(9) : _obj.HomePhone;
            _object.MobilePhone = (_obj.MobilePhone == null) ? "04" + RandomNumber(8) : _obj.MobilePhone;
            _object.Address = (_obj.Address == null) ? "TestAddress#@" : _obj.Address;
            _object.UnitNumber = (_obj.UnitNumber == null) ? RandomNumber(4) : _obj.UnitNumber;
            _object.StreetNumber = (_obj.StreetNumber == null) ? RandomNumber(3) : _obj.StreetNumber;
            _object.Rmsrvcode = (_obj.Rmsrvcode == null) ? " Rmsrv:0.9999" : _obj.Rmsrvcode;
            _object.StreetName = (_obj.StreetName == null) ? "At:N Cr:A Id:100 Rr1:A Rr2:A Rr3:A" : _obj.StreetName;
            _object.StreetType = (_obj.StreetType == null) ? RandomStreeType() : _obj.StreetType;
            int index = Convert.ToInt32(RandomNumber(2));
            _object.Suburb = (_obj.Suburb == null) ? RandomSubrubPostCode(index, 0) : _obj.Suburb;
            _object.PostCode = (_obj.PostCode == null) ? RandomSubrubPostCode(index, 1) : _obj.PostCode;
            _object.EmploymentStatus = (_obj.EmploymentStatus == null) ? "Full Time" : _obj.EmploymentStatus;
            _object.Have2SACCLoan = (_obj.Have2SACCLoan == null) ? "No" : _obj.Have2SACCLoan;
            _object.UserType = (_obj.UserType == null) ? "New" : _obj.UserType;

            return _object;
        }

        public string RandomString(int length)
        {
            Random random = new Random();
            string chars = "abcdefghijklmnopqrstuvwxyz";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public string RandomAccName()
        {
            Random random = new Random();
            return RandomString(random.Next(3, 12));
        }

        public DateTime GetRandomDate()
        {
            Random random = new Random();
            DateTime from = new DateTime(1950, 5, 1);
            DateTime to = new DateTime(1995, 5, 1);
            var range = to - from;

            var randTimeSpan = new TimeSpan((long)(random.NextDouble() * range.Ticks));

            return from + randTimeSpan;
        }

        public string GetRandomDOB()
        {
            string _dt = GetRandomDate().ToString("dd/MM/yyyy");
            return _dt.Replace("-", "/");
        }

        public string RandomEmail()
        {
            Random _random = new Random();
            return RandomString(10) + "_" + _random.Next(0000, 9999).ToString() + "@Cigniti.com";
        }

        public string RandomNumber(int length)
        {
            Random random = new Random();
            StringBuilder output = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                output.Append(random.Next(0, 10));
            }
            return output.ToString();
        }

        public string RandomAccNumber()
        {
            Random random = new Random();

            return RandomNumber(random.Next(4, 9));
        }

        public string RandomDay()
        {
            Random rnd = new Random();
            int day = rnd.Next(1, 30);
            return day.ToString();
        }

        public string RandomMonth()
        {
            Random rnd = new Random();
            int month = rnd.Next(1, 12);
            return month.ToString();
        }

        public string RandomYear()
        {
            string _dt = GetRandomDate().ToString("yyyy");
            return _dt;
        }

        public string RandomTitle()
        {
            Random random = new Random();
            string[] title = { "Mr", "Mrs", "Miss", "Ms" };
            return title[random.Next(0, 3)];
        }

        public string RandomStreeType()
        {
            Random random = new Random();
            string[] streetype = {  "ACCESS", "ALLEY", "ALLEYWAY", "AMBLE", "ANCHORAGE", "APPROACH", "ARCADE", "ARTERY",
                    "AVENUE", "BASE", "BASIN", "BEACH", "BEND", "BLOCK", "BOULEVARD", "BOWL", "BRACE", "BRAE", "BREAK", "BRIDGE",
                    "BROADWAY", "BROW", "BYPASS", "BYWAY", "CAUSEWAY", "CENTRE", "CENTREWAY", "CHASE", "CIRCLE", "CIRCLET", "CIRCUIT",
                    "CIRCUS", "CLOSE", "COLONNADE", "COMMON", "CONCOURSE", "COPSE", "CORNER", "CORSO", "COURT","COURTYARD", "COVE",
                    "CRESCENT", "CREST", "CROSS", "CROSSING", "CROSSROAD", "CROSSWAY", "CRUISEWAY", "CUL-DE-SAC", "CUTTING", "DALE",
                    "DELL", "DEVIATION", "DIP", "DISTRIBUTOR", "DRIVE", "DRIVEWAY", "EDGE", "ELBOW", "END", "ENTRANCE", "ESPLANADE",
                    "ESTATE", "EXPRESSWAY", "EXTENSION", "FAIRWAY", "FIRE TRACK", "FIRETRAIL", "FLAT", "FOLLOW", "FOOTWAY", "FORESHORE",
                    "FORMATION", "FREEWAY", "FRONT", "FRONTAGE", "GAP", "GARDEN", "GARDENS", "GATE", "GATES", "GLADE", "GLEN", "GRANGE",
                    "GREEN", "GROUND", "GROVE", "GULLY", "HEIGHTS", "HIGHROAD", "HIGHWAY", "HILL", "INTERCHANGE", "INTERSECTION",
                    "JUNCTION", "KEY", "LANDING", "LANE", "LANEWAY", "LEES", "LINE", "LINK", "LITTLE", "LOOKOUT", "LOOP", "LOWER",
                    "MALL", "MEANDER", "MEW", "MEWS", "MOTORWAY", "MOUNT", "NOOK", "OUTLOOK", "PACKET", "PARADE", "PARK", "PARKLANDS",
                    "PARKWAY", "PART", "PASS", "PATH", "PATHWAY", "PIAZZA", "PLACE", "PLATEAU", "PLAZA", "POCKET", "POINT", "PORT",
                    "PROMENADE", "QUAD", "QUADRANGLE", "QUADRANT", "QUAY", "QUAYS", "RAMBLE", "RAMP", "RANGE", "REACH", "RESERVE",
                    "RESORT", "REST", "RETREAT", "RIDE", "RIDGE", "RIDGEWAY", "RIGHT OF WAY", "RING", "RISE", "RIVER", "RIVERWAY",
                    "RIVIERA", "ROAD", "ROAD EAST", "ROADS", "ROADSIDE", "ROADWAY", "RONDE", "ROSEBOWL", "ROTARY", "ROUND", "ROUTE",
                    "ROW", "RUE", "RUN", "SERVICE WAY", "SIDING", "SLOPE", "SOUND", "SPUR", "SQUARE", "STAIRS", "STATE HIGHWAY",
                    "STEPS", "STRAND", "STREET", "STREET EAST", "STREET NORTH", "STRIP", "SUBWAY", "TARN", "TERRACE", "THOROUGHFARE",
                    "TOLLWAY", "TOP", "TOR", "TOWERS", "TRACK", "TRAIL", "TRAILER", "TRIANGLE", "TRUNKWAY", "TURN", "UNDERPASS",
                    "UPPER", "VALE", "VIADUCT", "VIEW", "VILLAS", "VISTA", "WADE", "WALK", "WALKWAY", "WAY", "WHARF", "WYND", "YARD"};
            return streetype[random.Next(0, 206)];
        }

        /// <summary>
        /// List of Suburb Name and Postal Codes
        /// </summary>
        /// <param name="x">Max value 183</param>
        /// <param name="y"> 0 For Subrub Name and 1 for Postal Code</param>
        /// <returns>Subrub Name or Postal Code based on Paramater</returns>
        /// 
        public string RandomSubrubPostCode(int x, int y)
        {
            Random random = new Random();
            string[,] _val = new string[,]{{"AVONDALE HEIGHTS","3034"},{"MOONEE PONDS","3039"},{"MELBOURNE AIRPORT","3045"},{"ROYAL MELBOURNE HOSPITAL","3050"},
                                           {"GREENVALE","3059"},{"CAMPBELLFIELD","3061"},{"SOMERTON","3062"},{"ABBOTSFORD","3067"},
                                           {"THORNBURY","3071"},{"THOMASTOWN","3074"},{"MILL PARK","3082"},{"DIAMOND CREEK","3089"},
                                           {"PLENTY","3090"},{"YARRAMBAT","3091"},{"LOWER PLENTY","3093"},{"MONTMORENCY","3094"},
                                           {"WATTLE GLEN","3096"},{"KEW EAST","3102"},{"TEMPLESTOWE","3106"},{"TEMPLESTOWE LOWER","3107"},{"DONCASTER","3108"},
                                           {"NUNAWADING BC","3110"},{"DONVALE","3111"},{"PARK ORCHARDS","3114"},{"WONGA PARK","3115"},
                                           {"CHIRNSIDE PARK","3116"},{"BATHURST STREET PO","7000"},{"RISDON VALE","7016"},{"LAUDERDALE","7021"},
                                           {"SOUTH ARM","7022"},{"OPOSSUM BAY","7023"},{"CREMORNE","7024"},{"CAMPANIA","7026"},
                                           {"COLEBROOK","7027"},{"BLACKMANS BAY","7052"},{"HUNTINGFIELD","7055"},{"FRANKLIN","7113"},
                                           {"DOVER","7117"},{"STONOR","7119"},{"STRATHGORDON","7139"},{"KETTERING","7155"},
                                           {"COPPING","7174"},{"KELLEVIE","7176"},{"MURDUNNA","7178"},{"EAGLEHAWK NECK","7179"},
                                           {"TARANNA","7180"},{"HIGHCROFT","7183"},{"PREMAYDENA","7185"},{"KOONYA","7187"},
                                           {"CAPE BARREN ISLAND","7257"},{"GRAVELLY BEACH","7276"},{"HADSPEN","7290"},{"CARRICK","7291"},
                                           { "SOMERSET","7322"},{ "STANLEY","7331"},{ "GORMANSTON","7466"},
                                           { "GEORGE STREET","4003"},{ "NORTHGATE","4013"},{ "KIPPA-RING","4021"},{ "ROTHWELL","4022"},
                                           { "ROYAL BRISBANE HOSPITAL","4029"},{ "BALD HILLS","4036"},{ "EATONS HILL","4037"},
                                           { "BARDON","4065"},{ "UNIVERSITY OF QUEENSLAND","4072"},{ "YERONGA","4104"},{ "NATHAN","4111"},
                                           { "KURABY","4112"},{ "UNDERWOOD","4119"},{ "BELMONT","4153"},{ "CHANDLER","4155"},
                                           { "THORNESIDE","4158"},{ "BIRKDALE","4159"},{ "ALEXANDRA HILLS","4161"},{ "THORNLANDS","4164"},
                                           { "MURARRIE","4172"},{ "HEMMANT","4174"},{ "BETHANIA","4205"},{ "WEST BURLEIGH","4219"},
                                           { "GRIFFITH UNIVERSITY","4222"},{ "BOND UNIVERSITY","4229"},{ "ROBINA TOWN CENTRE","4230"},
                                           { "TAMBORINE","4270"},{ "EAGLE HEIGHTS","4271"},{ "GATTON COLLEGE","4345"},{ "MARBURG","4346"},
                                           { "ERNABELLA","0872"},{ "WEST LAKES SHORE","5020"},{ "WEST LAKES","5021"},{ "NOVAR GARDENS","5040"},
                                           { "HOLDEN HILL","5088"},{ "HIGHBURY","5089"},{ "HOPE VALLEY","5090"},{ "ANGLE VALE","5117"},
                                           { "WYNN VALE","5127"},{ "PARACOMBE","5132"},{ "INGLEWOOD","5133"},{ "NORTON SUMMIT","5136"},
                                           { "BASKET RANGE","5138"},{ "FOREST RANGE","5139"},{ "GREENHILL","5140"},{ "URAIDLA","5142"},
                                           { "CAREY GULLY","5144"},{ "PICCADILLY","5151"},{ "BRINGENBRONG","2642"},
                                           { "ALDGATE","5154"},{ "UPPER STURT","5156"},{ "CHRISTIE DOWNS","5164"},{ "O'SULLIVAN BEACH","5166"},
                                           { "MASLIN BEACH","5170"},{ "PORT ELLIOT","5212"},{ "MIDDLETON","5213"},{ "PARNDANA","5220"},
                                           { "CUDLEE CREEK","5232"},{ "BIRDWOOD","5234"},{ "TUNGKILLO","5236"},{ "LENSWOOD","5240"},
                                           { "DARWIN","0800"},{ "BERRY SPRINGS","0838"},{ "DARWIN RIVER","0841"},{ "BATCHELOR","0845"},
                                           { "ADELAIDE RIVER","0846"},{ "PINE CREEK","0847"},{ "TINDAL","0853"},{ "ALYANGULA","0885"},
                                           { "JABIRU","0886"},{ "KINGS CROSS","1340"},{ "ATO ACTIVITY STATEMENTS","1391"},{ "HURSTVILLE BC","1481"},
                                           { "WEST CHATSWOOD","1515"},{ "HORNSBY WESTFIELD","1635"},{ "NORTH RYDE BC","1670"},{ "RYDALMERE BC","1701"},
                                           { "SEVEN HILLS MC","1781"},{ "PENRITH SOUTH DC","1797"},{ "WETHERILL PARK DC","1851"},{ "WORLD SQUARE","2002"},
                                           { "PYRMONT","2009"},{ "REDFERN","2016"},{ "BELLEVUE HILL","2023"},{ "ROSE BAY","2029"},
                                           { "ANNANDALE","2038"},{ "ROZELLE","2039"},{ "ERSKINEVILLE","2043"},{ "HABERFIELD","2045"},
                                           { "CAMMERAY","2062"},{ "GORDON","2072"},{ "MOUNT COLAH","2079"},{ "MOUNT KURING-GAI","2080"},
                                           { "HMAS PENGUIN","2091"},{ "SEAFORTH","2092"},{ "FAIRLIGHT","2094"},{ "BAYVIEW","2104"},
                                           { "MACQUARIE UNIVERSITY","2109"},{ "RYDALMERE","2116"},{ "WEST PENNANT HILLS","2125"},{ "AUSTRALIAN NATIONAL UNIVERSITY","0200"},
                                           { "CIVIC SQUARE","2608"},{ "HALL","2618"},{ "TUGGERANONG DC","2901"},{ "GUNGAHLIN","2912"}};
            //int numb = random.Next(0, 99);
            //string[,] _value = new string [,]{ { _val[numb, 0], _val[numb, 1] } };
            return _val[x, y];
        }

        public bool GetPlatform(IWebDriver driver)
        {
            string strval = ((OpenQA.Selenium.Remote.DesiredCapabilities)((OpenQA.Selenium.Remote.RemoteWebDriver)driver).Capabilities).Platform.PlatformType.ToString();
            if (strval == "Android" || strval == "Mac")
                return true;
            else return false;
        }

        public class PersonalDetailsDataObj
        {
            public string Title { get; set; }
            public string FirstName { get; set; }
            public string MiddleName { get; set; }
            public string LastName { get; set; }
            public string DOB { get; set; }
            public string DOB_Day { get; set; }
            public string DOB_Month { get; set; }
            public string DOB_Year { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            public string ConfirmPassword { get; set; }
            public string HomePhone { get; set; }
            public string MobilePhone { get; set; }
            public string Address { get; set; }
            public string UnitNumber { get; set; }
            public string StreetNumber { get; set; }
            public string Rmsrvcode { get; set; }
            public string StreetType { get; set; }
            public string Suburb { get; set; }
            public string PostCode { get; set; }
            public string StreetName { get; set; }
            public string EmploymentStatus { get; set; }
            public string Have2SACCLoan { get; set; }
            public string UserType { get; set; }

        }

        public void CheckReadPrivacyBtn(string UserType)
        {
            if (UserType == "New")
            {
                string classtextReadPrivacy = _driver.FindElement(_personaldetail.ReadPrivacychecked).GetAttribute("class");
                if (!classtextReadPrivacy.Contains("checked"))
                {
                    _act.JSClick(_personaldetail .ReadPrivacychecked, "ReadPrivacychecked");
                }
            }
            else
            {
                string classtextReadPrivacy = _driver.FindElement(_personaldetail.ReadPrivacychecked).GetAttribute("class");
                if (!classtextReadPrivacy.Contains("checked"))
                {
                    _act.JSClick(_personaldetail.ReadPrivacychecked, "ReadPrivacychecked");
                }
            }

        }

        public void CheckReadCreditBtn(string UserType)
        {
            if (UserType == "New")
            {
                string classtexReadCredit = _driver.FindElement(_personaldetail.ReadCreditGuidechecked).GetAttribute("class");
                if (!classtexReadCredit.Contains("checked"))
                {
                    _act.JSClick(_personaldetail.ReadCreditGuidechecked, "ReadCreditGuidechecked");
                }
            }
            else
            {
                string classtexReadCredit = _driver.FindElement(_personaldetail.ReadCreditGuidechecked).GetAttribute("class");
                if (!classtexReadCredit.Contains("checked"))
                {
                    _act.JSClick(_personaldetail.ReadCreditGuidechecked, "ReadCreditGuidechecked");
                }
            }
        }

    }
}
