using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using Toyota.Automation.Locators;

namespace Toyota.Automation.Steps
{
    [Binding]
    public sealed class SmartlineSteps
    {        
        public ActionEngine _act;       
        private ISmartLineLoc _SmartlineLoc;      

        private IWebDriver _driver = null;


        public SmartlineSteps(IWebDriver driver)
        {
            _driver = driver;
            _act = new ActionEngine(driver);         
            SetHelperDesktop();
            SetHelperMobile();
        }

        [Conditional("DebugLocalChrome")]
        [Conditional("DebugLocalFireFox")]
        //[Conditional("DebugLocalIE")]
        //[Conditional("DebugCloudChrome")]
        //[Conditional("DebugCloudFireFox")]
        //[Conditional("DebugCloudIE")]
        public void SetHelperDesktop()
        {
            _SmartlineLoc = new SmartLineDesktopLoc();
            //_bankdetail = new BankDetailsDesktopNLLoc();
            //_homedetails = new HomeDetailsDesktopNLLoc();
            //_loanpurposdetails = new LoanPurposeDetailsDesktopNLLoc();
            //_loansetupdetails = new LoanSetupDetailsDesktopNLLoc();
            //_personaldetail = new PersonalDetailsDesktopNLLoc();
        }
      
        [Conditional("DebugCloudAndroid")]
        [Conditional("DebugCloudIOS")]
        public void SetHelperMobile()
        {
            _SmartlineLoc = new SmartLineMobileLoc();
            //_bankdetail = new BankDetailsMobileNLLoc();
            //_homedetails = new HomeDetailsMobileNLLoc();
            //_loanpurposdetails = new LoanPurposeDetailsMobileNLLoc();
            //_loansetupdetails = new LoanSetupDetailsMobileNLLoc();
            //_personaldetail = new PersonalDetailsMobileNLLoc();
        }

        [Given(@"navigate to url")]
        public void GivenNavigateToUrl()
        {
            _driver.Navigate().GoToUrl("https://www.smartline.com.au");
        }

        [Then(@"click on home loans")]
        public void ThenClickOnHomeLoans()
        {
            _act.waitForVisibilityOfElement(_SmartlineLoc.HomeLoans, 60);
            _act.click(_SmartlineLoc.HomeLoans, "HomeLoans");
        }       

        [Then(@"click on  talk to a smartline adviser")]
        public void ThenClickOnTalkToASmartlineAdviser()
        {
            _act.waitForVisibilityOfElement(_SmartlineLoc.smartlineadviser, 60);
            _act.click(_SmartlineLoc.smartlineadviser, "smartlineadviser");
        }

        [Then(@"enter firstname")]
        public void ThenEnterFirstname()
        {
            _act.waitForVisibilityOfElement(_SmartlineLoc.firstname, 60);
            _act.EnterText(_SmartlineLoc.firstname, "Purna");
        }

        [Then(@"enter phone number")]
        public void ThenEnterPhoneNumber()
        {
            _act.waitForVisibilityOfElement(_SmartlineLoc.phonenumber, 60);
            _act.EnterText(_SmartlineLoc.phonenumber, "7894561230");
        }

        [Then(@"enter last name")]
        public void ThenEnterLastName()
        {
            _act.waitForVisibilityOfElement(_SmartlineLoc.lastname, 60);
            _act.EnterText(_SmartlineLoc.lastname, "prasad");
        }

        [Then(@"enter post code")]
        public void ThenEnterPostCode()
        {
            _act.waitForVisibilityOfElement(_SmartlineLoc.postcode, 60);
            _act.EnterText(_SmartlineLoc.postcode, "52412");
        }

        [Then(@"check subscribe checkbox")]
        public void ThenCheckSubscribeCheckbox()
        {
            _act.waitForVisibilityOfElement(_SmartlineLoc.subscribe, 60);
            _act.click(_SmartlineLoc.subscribe, "subscribe");
        }

        [Then(@"click on submit button")]
        public void ThenClickOnSubmitButton()
        {
            _act.waitForVisibilityOfElement(_SmartlineLoc.submit, 60);
            _act.click(_SmartlineLoc.submit, "submit");
        }

        [Then(@"verify error message")]
        public void ThenVerifyErrorMessage()
        {
            _act.waitForVisibilityOfElement(_SmartlineLoc.errormessage, 60);
            IWebElement errormsg = _driver.FindElement(_SmartlineLoc.errormessage);
            if(_act.isElementDisplayed(errormsg))
            {
                string errormessage = _act.getText(_SmartlineLoc.errormessage, "errormessage");
                Console.WriteLine("The error message is : " + errormessage);
            }
            else
            {
                Console.WriteLine("The error message not displated");
            }              
        }

        [Then(@"enter email id")]
        public void ThenEnterEmailId()
        {
            _act.waitForVisibilityOfElement(_SmartlineLoc.emailid, 60);
            _act.click(_SmartlineLoc.emailid, "purna@gmail.com");
        }

    }
}
