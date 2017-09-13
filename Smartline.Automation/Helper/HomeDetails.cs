﻿using Nimble.Automation.Accelerators;
using OpenQA.Selenium;
using System;
using System.Configuration;
using System.Drawing.Imaging;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using System.Threading;

namespace Nimble.Automation.Repository
{

    public class HomeDetails : TestEngine
    {
        private IHomeDetails _homeDetailsLoc;
        private ActionEngine _act = null;
        private IWebDriver _driver = null;
        public string NimbleDebugURL = ConfigurationManager.AppSettings.Get("localBaseDebugUrl");
        public string DebugUrlRL = ConfigurationManager.AppSettings.Get("DebugUrlRL");
        TestUtility _testut = new TestUtility();
       

        public HomeDetails(IWebDriver driver, string strUserType)
        {
            if (GetPlatform(driver))
                _homeDetailsLoc = (strUserType == "NL") ? (IHomeDetails)new HomeDetailsMobileNLLoc() : new HomeDetailsMobileRLLoc();
            else
                _homeDetailsLoc = (strUserType == "NL") ? (IHomeDetails)new HomeDetailsDesktopNLLoc() : new HomeDetailsDesktopRLLoc();
            _act = new ActionEngine(driver);
            _driver = driver;
        }

        public void HomeDetailsPage()
        {
            // Click on Apply Button
            ClickApplyBtn();

            ClickStartApplictionBtn();
        }

        public void ClickApplyBtn()
        {
            _act.waitForVisibilityOfElement(_homeDetailsLoc.linkMenuApply, 300);
            _act.click(_homeDetailsLoc.linkMenuApply, "ApplyLinkBtn");
        }

        /// <summary>
        /// Clicks the start appliction button.
        /// </summary>
        public void ClickStartApplictionBtn()
        {
            _act.waitForVisibilityOfElement(_homeDetailsLoc.btnstartApplication, 500);
            //_act.JSClick(_homeDetailsLoc.btnstartApplication, "btnstartApplication");
            _act.click(_homeDetailsLoc.btnstartApplication, "btnstartApplication");
        }
        //Trail button press
        public void ClickActionApply()
        {
            _act.waitForVisibilityOfElement(_homeDetailsLoc.btnstartApplication, 60);
            _act.click(_homeDetailsLoc.btnstartApplication, "btnstartApplication");
        }
        //Trial text box
        public void EnterAmount()
        {
            _act.EnterText(_homeDetailsLoc.EnterAmount, "1600");
        }

        /// <summary>
        /// Clicks the login button.
        /// </summary>
        public void ClickLoginBtn()
        {
            _act.waitForVisibilityOfElement(_homeDetailsLoc.btnLogin, 500);
            _act.click(_homeDetailsLoc.btnLogin, "LoginBtn");
        }

        /// <summary>
        /// Login with existing user.
        /// </summary>
        /// <param name="password">The password.</param>
        /// <param name="loanamount">The loanamount.</param>
        //public void LoginExistingUser(string password, int loanamount)
        //{
        //    string strEmailID = CreateClient();
        //    if (strEmailID.Length <= 2)
        //        strEmailID = CreateClient();
        //    NimbleExistingUserLogin(strEmailID, password);
        //}

        public string LoginExistingUser(string password, int loanamount, string clienttype, string feature)
        {
            string strEmailID = CreateClient(clienttype,feature);
            Console.WriteLine("Email Length1" + strEmailID);
            Console.WriteLine("email fetched....");
            if (strEmailID.Length <= 2)
                strEmailID = CreateClient(clienttype, feature);
            Console.WriteLine("Email Length2" + strEmailID);
            NimbleExistingUserLogin(strEmailID, password);
            return strEmailID;
        }

        //public void LoginExistingUser1(string password, int loanamount, string clienttype, string feature)
        //{
        //    string strEmailID = CreateClient(clienttype, feature);
        //    if (strEmailID.Length <= 2)
        //        strEmailID = CreateClient(clienttype, feature);
        //    NimbleExistingUserLogin(strEmailID, password);
        //}

        public void LoginGracePeriodUser(string password, string clienttype, string feature)
        {
            //string strEmailID = CreateGracePeriodClient();
            string strEmailID = CreateClient(clienttype, feature);
            if (strEmailID.Length <= 2)
                strEmailID = CreateGracePeriodClient();
            NimbleExistingUserLogin(strEmailID, password);
        }
        /// <summary>
        /// Clicks the hide show debug button.
        /// </summary>
        public void ClickHideShowDebugBtn()
        {
            _act.waitForVisibilityOfElement(_homeDetailsLoc.BtnHideShowDebug, 120);
            _act.click(_homeDetailsLoc.BtnHideShowDebug, "HideShowDebugBtn");
        }

        /// <summary>
        /// Clicks the pass all no bs option.
        /// </summary>
        public void ClickPassAllNobslnk()
        {
            _act.waitForVisibilityOfElement(_homeDetailsLoc.BtnPassAllNobs, 60);
            _act.click(_homeDetailsLoc.BtnPassAllNobs, "PassAllNobs");
        }

        /// <summary>
        /// Closes the pol dialog.
        /// </summary>
        public void ClosePOLDialog()
        {
            _act.waitForVisibilityOfElement(_homeDetailsLoc.cancelPurposeLoanDialog, 60);
            _act.click(_homeDetailsLoc.cancelPurposeLoanDialog, "cancelPOL");
        }

        /// <summary>
        /// Clicks the request money button.
        /// </summary>
        public void ClickRequestMoneyBtn()
        {
            _act.waitForVisibilityOfElement(_homeDetailsLoc.RequestMoney, 500);
            _act.click(_homeDetailsLoc.RequestMoney, "RequestMoney");

        }

        /// <summary>
        /// Clicks the existing user start appliction button.
        /// </summary>
        public void ClickExistinguserStartApplictionBtn()
        {
            _act.waitForVisibilityOfElement(_homeDetailsLoc.btnstartApplication, 400);
            _act.click(_homeDetailsLoc.btnstartApplication, "Existing User");
        }

        /// <summary>
        /// Nimbles the existing user login.
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        /// <param name="password">The password.</param>
        public void NimbleExistingUserLogin(string userName, string password)
        {
            _act.waitForVisibilityOfElement(_homeDetailsLoc.DebugLogibBtn, 400);
            _act.click(_homeDetailsLoc.DebugLogibBtn, "click on lOGIN BUTTON to login");
            _act.JSClick(_homeDetailsLoc.PopupLogibBtn, "click on popup login");
            _act.waitForVisibilityOfElement(_homeDetailsLoc.LoginUsername, 400);
            Thread.Sleep(1000);//Delay time to entere the Email ID
            _act.EnterText(_homeDetailsLoc.LoginUsername, userName);
            _act.EnterText(_homeDetailsLoc.LoginPassword, password);
            _act.click(_homeDetailsLoc.LoginButton, "Login");
        }

        public void LoginLogoutUser(string UserName, string Password)
        {
            _act.JSClick(_homeDetailsLoc.PopupLogibBtn, "click on popup login");
            _act.waitForVisibilityOfElement(_homeDetailsLoc.LoginUsername, 300);
            _act.EnterText(_homeDetailsLoc.LoginUsername, UserName);
            _act.EnterText(_homeDetailsLoc.LoginPassword, Password);
            _act.click(_homeDetailsLoc.LoginButton, "Login");
        }

        /// <summary>
        /// Creates new client.
        /// </summary>
        /// <returns></returns>
        //public string CreateClient(string name, string feature)
        //{
        //    _driver.Navigate().GoToUrl(NimbleDebugURL);
        //    _act.waitForVisibilityOfElement(_homeDetailsLoc.CreateClient, 120);
        //    _act.click(_homeDetailsLoc.CreateClient, "createclient");

        //    _act.waitForVisibilityOfElement(By.XPath("//div[@id='clientlist']//tr[@class='header']/td[text()='" + name + "']"), 200);
        //    var clientlist = By.XPath("//div[@id='clientlist']//tr[@class='header']/td[text()='" + name + "']");
        //    _act.click(clientlist, "clientlist");
       
        //    _act.waitForVisibilityOfElement(By.XPath(".//tr//td[2]/span[text()='"+ feature + "']/../preceding-sibling::td/button"), 200);
        //    var selectfeature = By.XPath(".//tr//td[2]/span[text()='" + feature + "']/../preceding-sibling::td/button");
        //    _act.click(selectfeature, "selectfeature");

        //    _act.waitForVisibilityOfElement(_homeDetailsLoc.FetchEmailId, 120);
        //    Thread.Sleep(1000);
        //    var automail = Generateclientemail().Split(' ');
        //    var email = automail[0];
        //    //Recapture email if earlier one failed
        //    if (email == "")
        //    {
        //        automail = Generateclientemail().Split(' ');
        //        email = automail[0];
        //    }
        //    Console.WriteLine(email);
        //    string strbuilder = DateTime.Now.ToString("MM-dd-yy HH:mm") + " " + TestContext.CurrentContext.Test.Name + "*" + email + Environment.NewLine;
        //    _testut.WriteToFile(strbuilder);
        //    return email;
        //}

        public string CreateClient(string name, string feature)
        {
            _act.waitForVisibilityOfElement(By.XPath("//div[@id='clientlist']//tr[@class='header']/td[text()='" + name + "']"), 120);
            var clientlist = By.XPath("//div[@id='clientlist']//tr[@class='header']/td[text()='" + name + "']");
            _act.click(clientlist, "clientlist");
            Thread.Sleep(1000);
            _act.waitForVisibilityOfElement(By.XPath(".//tr[@style='display: table-row;']//td[2]/span[text()='"+feature+"']/../preceding-sibling::td/button[not(ancestor::div[contains(@class,'hidden')])]"), 120);
            var selectfeature = By.XPath(".//tr[@style='display: table-row;']//td[2]/span[text()='" + feature + "']/../preceding-sibling::td/button[not(ancestor::div[contains(@class,'hidden')])]");
            _act.click(selectfeature, "selectfeature");
            Thread.Sleep(1000);
            _act.waitForVisibilityOfElement(By.XPath("(.//tr[@style='display: table-row;']//td[2]/span[text()='"+ feature + "']/../div/a[contains(text(),'.com.au')])[last()]"), 100);
            //_act.waitForVisibilityOfElement(_homeDetailsLoc.FetchEmailId, 200);
            Thread.Sleep(1000);
            var automail = Generateclientemail(feature).Split(' ');
            var email = automail[0];
            Console.WriteLine(email);
            string strbuilder = DateTime.Now.ToString("MM-dd-yy HH:mm") + " " + TestContext.CurrentContext.Test.Name + "*" + email + Environment.NewLine;
            _testut.WriteToFile(strbuilder);
            return email;
        }

        //public string CreateClient1()
        //{
        //    _act.waitForVisibilityOfElement(_homeDetailsLoc.OldProduct, 500);
        //    _act.click(_homeDetailsLoc.OldProduct, "OldProduct");
        //  //  _driver.FindElement(_homeDetailsLoc.OldProduct).Click();
        //  //  _driver.FindElement(By.XPath("//*[@id='clientlist']/table/tbody/tr[32]/td")).Click();       
        //    _act.waitForVisibilityOfElement(_homeDetailsLoc.ReturnerSingle, 240);
        //    _act.click(_homeDetailsLoc.ReturnerSingle, "Single Returner");
        //    _act.waitForVisibilityOfElement(_homeDetailsLoc.FetchEmailId, 240);
        //    Thread.Sleep(4000);
        //    var automail = Generateclientemail().Split(' ');
        //    var email = automail[0];
        //    //Recapture email if earlier one failed
        //    if (email == "")
        //    {
        //        automail = Generateclientemail().Split(' ');
        //        email = automail[0];
        //    }
        //    Console.WriteLine(email);
        //    string strbuilder = DateTime.Now.ToString("MM-dd-yy HH:mm") + " " + TestContext.CurrentContext.Test.Name + "*" + email + Environment.NewLine;
        //    _testut.WriteToFile(strbuilder);
        //    return email;
        //}

        public string CreateGracePeriodClient()
        {
            _act.waitForVisibilityOfElement(_homeDetailsLoc.DavidTestClients, 120);

            _driver.FindElement(_homeDetailsLoc.DavidTestClients).Click();
            //  _driver.FindElement(By.XPath("//*[@id='clientlist']/table/tbody/tr[32]/td")).Click();       
            _act.waitForVisibilityOfElement(_homeDetailsLoc.GracePeriodMakeButton, 120);
            _act.click(_homeDetailsLoc.GracePeriodMakeButton, "Single Returner");
            _act.waitForVisibilityOfElement(_homeDetailsLoc.GracePeriodEmail, 120);
            Thread.Sleep(4000);
            var automail = GenerateGraceemail().Split(' ');
            var email = automail[0];
            //Recapture email if earlier one failed
            if (email == "")
            {
              //  automail = Generateclientemail().Split(' ');
                email = automail[0];
            }
            Console.WriteLine(email);
            string strbuilder = DateTime.Now.ToString("MM-dd-yy HH:mm") + " " + TestContext.CurrentContext.Test.Name + "--" + email + Environment.NewLine;
            _testut.WriteToFile(strbuilder);
            return email;
        }


        /// <summary>
        /// Generate cliente mails this instance.
        /// </summary>
        /// <returns></returns>
        private string Generateclientemail(string feature)
        {
            string clientemail = string.Empty;
            bool flag = true;
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            while (flag)
            {
                try
                {
                    //  var returnerEmail = _driver.FindElement(_homeDetailsLoc.FetchEmailId);
                    var returnerEmail = _driver.FindElement(By.XPath("(.//tr[@style='display: table-row;']//td[2]/span[text()='" + feature + "']/../div/a[contains(text(),'.com.au')])[last()]"));
                    wait.Until(ExpectedConditions.TextToBePresentInElement(returnerEmail, "Making..."));                   
                    flag = false;
                }
                catch (Exception)
                {
                    clientemail = Generateemail(feature);
                   // clientemail = _act.getText(_homeDetailsLoc.FetchEmailId, "ClientEmail");                   
                    break;                  
                }
            }
            return clientemail;
        }




        /// <summary>
        /// Generate cliente mails this instance.
        /// </summary>
        /// <returns></returns>
        private string Generateemail(string feature)
        {
            string clientemail = string.Empty;
            bool flag = true;
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            while (flag)
            {
                try
                {
                    // var returnerEmail = _driver.FindElement(_homeDetailsLoc.FetchEmailId);
                    var returnerEmail = _driver.FindElement(By.XPath("(.//tr[@style='display: table-row;']//td[2]/span[text()='" + feature + "']/../div/a[contains(text(),'.com.au')])[last()]"));
                    wait.Until(ExpectedConditions.TextToBePresentInElement(returnerEmail, ".com"));
                    // clientemail = _act.getText(_homeDetailsLoc.FetchEmailId, "ClientEmail");
                    clientemail= _act.getText(By.XPath("(.//tr[@style='display: table-row;']//td[2]/span[text()='" + feature + "']/../div/a[contains(text(),'.com.au')])[last()]"), "ClientEmail");
                    break;
                }
                catch (Exception)
                {
                    clientemail = _act.getText(By.XPath("(.//tr[@style='display: table-row;']//td[2]/span[text()='" + feature + "']/../div/a[contains(text(),'.com.au')])[last()]"), "ClientEmail");
                    break;
                    flag = false;
                }
            }
            return clientemail;
        }


        private string GenerateGraceemail()
        {
            string clientemail = string.Empty;
            bool flag = true;
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            while (flag)
            {
                try
                {
                    var returnerEmail = _driver.FindElement(_homeDetailsLoc.GracePeriodEmail);
                    wait.Until(ExpectedConditions.TextToBePresentInElement(returnerEmail, "Making..."));
                    flag = false;
                }
                catch (Exception)
                {
                    clientemail = _act.getText(_homeDetailsLoc.GracePeriodEmail, "ClientEmail");
                    break;
                }
            }
            return clientemail;
        }

        public void ClickDebugClientCatg(string strCategory)
        {
            By xap = By.XPath(".//*[@id='clientlist']/table/tbody/tr[contains(text(),'"+ strCategory + "')]/td");
           // _act.waitForVisibilityOfElement(xap, 120);
            _act.click(xap, strCategory);

        }



        /// <summary>
        /// Clicks the debug menu.
        /// </summary>
        public void ClickDebugMenu()
        {
            _act.waitForVisibilityOfElement(_homeDetailsLoc.BtnHideShowDebug, 60);
            _act.click(_homeDetailsLoc.BtnHideShowDebug, "BtnHideandShow");
        }

        /// <summary>
        /// Passes all nobs BTN.
        /// </summary>
        public void PassAllNobsBtn()
        {
            _act.waitForVisibilityOfElement(_homeDetailsLoc.BtnPassAllNobs, 60);
            _act.click(_homeDetailsLoc.BtnPassAllNobs, "BtnPasallnobs");
        }

        /// <summary>
        /// Checks the hide show.
        /// </summary>
        /// <returns></returns>
        public bool CheckHideShow()
        {
            return _act.isElementPresent(_homeDetailsLoc.BtnHideShowDebug);
        }

        /// <summary>
        /// helper method to capture Screenshots this instance.
        /// </summary>
        public void Screenshot()
        {
            var image = ((ITakesScreenshot)_driver).GetScreenshot();
            //Save the screenshot
            image.SaveAsFile("C:/nimble-ui-automation/screenshot/Screenshot.png", ImageFormat.Png);
        }

        public void homeFunctions()
        {
            // Click on Apply Button
            ClickApplyBtn();

            // Click on Start Your Application Button
            ClickStartApplictionBtn();
        }

        public string homeFunctions_RL(string PASSWORD, int LOANAMOUNT , string name, string feature)
        {
            // Login with existing user
           var emailid = LoginExistingUser(PASSWORD, LOANAMOUNT, name, feature);

            // Click on Request Money Button
            ClickRequestMoneyBtn();

            //Click on Start Application Button
            ClickExistinguserStartApplictionBtn();
            return emailid;
        }

        public string homeFunctions_RL(string name, string feature)
        {
            // Login with existing use
            return LoginExistingUser("password", 121, name, feature);
            
        }



        /// <summary>
        /// Logs in debug client : SACC product, missed payment, out of grace
        /// </summary>
        /// <returns></returns>
        public void LoginExistingUser_SACCInGrace(string password, int loanamount, string clienttype, string feature)
        {
            //string strEmailID = CreateClientSACCInGrace();
            string strEmailID = CreateClient(clienttype, feature);
            if (strEmailID.Length <= 2)
                strEmailID = CreateClientSACCInGrace();
            NimbleExistingUserLogin(strEmailID, password);
        }

        /// <summary>
        /// Creates debug client : SACC product, missed payment, in grace
        /// </summary>
        /// <returns></returns>
        public string CreateClientSACCInGrace()
        {
            _driver.Navigate().GoToUrl(DebugUrlRL);
            _act.waitForVisibilityOfElement(_homeDetailsLoc.ClickCreateClientGracePeriodBtn, 120);
            _act.click(_homeDetailsLoc.ClickCreateClientGracePeriodBtn, "Create Client Grace Period");
            _act.waitForVisibilityOfElement(_homeDetailsLoc.ClickCreateClientSACCInGraceBtn, 120);
            _act.click(_homeDetailsLoc.ClickCreateClientSACCInGraceBtn, "SACC failed payment inside grace");
            //_act.waitForVisibilityOfElement(_homeDetailsLoc.FetchEmailIDSACCInGrace, 120);
            Thread.Sleep(4000);
            var automail = GenerateClientEmailGrace().Split(' ');
            var email = automail[0];
            //Recapture email if earlier one failed
            if (email == "")
            {
                automail = GenerateClientEmailGrace().Split(' ');
                email = automail[0];
            }
            Console.WriteLine(email);
            string strbuilder = DateTime.Now.ToString("MM-dd-yy HH:mm") + " " + TestContext.CurrentContext.Test.Name + "--" + email + Environment.NewLine;
            _testut.WriteToFile(strbuilder);
            return email;
        }


        /// <summary>
        /// Logs in debug client : SACC product, missed payment, out of grace
        /// </summary>
        /// <returns></returns>
        /// 
        public void LoginExistingUser_SACCOutGrace(string password, int loanamount, string clienttype, string feature)
        {
            //string strEmailID = CreateClientSACCOutGrace();
            string strEmailID = CreateClient(clienttype, feature);
            if (strEmailID.Length <= 2)
                strEmailID = CreateClientSACCOutGrace();
            NimbleExistingUserLogin(strEmailID, password);
        }

        /// <summary>
        /// Creates debug client : SACC product, missed payment, in grace
        /// </summary>
        /// <returns></returns>
        public string CreateClientSACCOutGrace()
        {
            _act.waitForVisibilityOfElement(_homeDetailsLoc.DavidClientBtn, 120);
            _act.click(_homeDetailsLoc.DavidClientBtn, "Create Client Grace Period");
            _act.click(_homeDetailsLoc.ClickDavidSACCOurGraceMakeBtn, "SACC failed payment inside grace");
            Thread.Sleep(4000);
            var automail = FetchEmail(_homeDetailsLoc.FetchEmailIDDavidSACCOutGrace).Split(' ');
            var email = automail[0];
            //Recapture email if earlier one failed
            if (email == "")
            {
                automail = FetchEmail(_homeDetailsLoc.FetchEmailIDDavidSACCOutGrace).Split(' ');
                email = automail[0];
            }
            Console.WriteLine(email);
            string strbuilder = DateTime.Now.ToString("MM-dd-yy HH:mm") + " " + TestContext.CurrentContext.Test.Name + "--" + email + Environment.NewLine;
            _testut.WriteToFile(strbuilder);
            return email;
        }

        /// <summary>
        /// Fetches the Email ID
        /// </summary>
        /// <returns>string email ID</returns>
        private string FetchEmail(By Xpath)
        {
            string clientemail = string.Empty;
            bool flag = true;
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            while (flag)
            {
                try
                {
                    var returnerEmail = _driver.FindElement(Xpath);
                    wait.Until(ExpectedConditions.TextToBePresentInElement(returnerEmail, "Making..."));
                    flag = false;
                }
                catch (Exception)
                {

                    clientemail = _act.getText(Xpath, "ClientEmail");
                    break;
                }
            }
            return clientemail;
        }

        /// <summary>
        /// TODO RENAME FUNC
        /// </summary>
        /// <returns></returns>
        private string GenerateClientEmailGrace()
        {
            string clientemail = string.Empty;
            bool flag = true;
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            while (flag)
            {
                try
                {
                    var returnerEmail = _driver.FindElement(_homeDetailsLoc.FetchEmailIDSACCInGrace);
                    wait.Until(ExpectedConditions.TextToBePresentInElement(returnerEmail, "Making..."));
                    flag = false;
                }
                catch (Exception)
                {

                    clientemail = _act.getText(_homeDetailsLoc.FetchEmailIDSACCInGrace, "ClientEmail");
                    break;
                }
            }
            return clientemail;
        }

        /// <summary>
        /// Click Make A Repayment button in Member Area
        /// </summary>
        public void ClickMakeRepaymentBtn()
        {
            _act.waitForVisibilityOfElement(_homeDetailsLoc.ClickMakeRepaymentBtn, 60);
            _act.click(_homeDetailsLoc.ClickMakeRepaymentBtn, "ClickMakeRepaymentBtn");
        }

        /// <summary>
        /// Check Direct Debit option for Make a Repayment in Member Area
        /// </summary>
        public void CheckRepaymentDirectDebitChkbx()
        {
            _act.waitForVisibilityOfElement(_homeDetailsLoc.CheckRepaymentDirectDebitChkbx, 60);
            _act.click(_homeDetailsLoc.CheckRepaymentDirectDebitChkbx, "CheckRepaymentDirectDebitChkbx");
        }

        /// <summary>
        /// Check Debit Card option for Make a Repayment in Member Area
        /// </summary>
        public void CheckRepaymentDebitCardChkbx()
        {
            _act.waitForVisibilityOfElement(_homeDetailsLoc.CheckRepaymentDebitCardChkbx, 60);
            _act.click(_homeDetailsLoc.CheckRepaymentDebitCardChkbx, "CheckRepaymentDebitCardChkbx");
        }

        /// <summary>
        /// Check BPAY option for Make a Repayment in Member Area
        /// </summary>
        public void CheckRepaymentBPAYChkbx()
        {
            _act.waitForVisibilityOfElement(_homeDetailsLoc.CheckRepaymentBPAYChkbx, 60);
            _act.click(_homeDetailsLoc.CheckRepaymentBPAYChkbx, "CheckRepaymentBPAYChkbx");
        }

        /// <summary>
        /// Check EFT option for Make a Repayment in Member Area
        /// </summary>
        public void CheckRepaymentEFTChkbx()
        {
            _act.waitForVisibilityOfElement(_homeDetailsLoc.CheckRepaymentEFTChkbx, 60);
            _act.click(_homeDetailsLoc.CheckRepaymentEFTChkbx, "CheckRepaymentEFTChkbx");
        }

        /// <summary>
        /// Click Continue button after selecting a payment method for Make A Repayment
        /// </summary>
        public void ClickRepaymentContinueBtn()
        {
            _act.waitForVisibilityOfElement(_homeDetailsLoc.ClickRepaymentContinueBtn, 60);
            _act.click(_homeDetailsLoc.ClickRepaymentContinueBtn, "ClickRepaymentContinueBtn");
        }

        /// <summary>
        /// Confirm Direct Debit for making a repayment
        /// </summary>
        public void ClickRepaymentDirectDebitBtn()
        {
            _act.waitForVisibilityOfElement(_homeDetailsLoc.ClickRepaymentDirectDebitBtn, 60);
            _act.click(_homeDetailsLoc.ClickRepaymentDirectDebitBtn, "ClickRepaymentDirectDebitBtn");
        }

        /// <summary>
        /// Confirm Debit Card for making a repayment
        /// </summary>
        public void ClickRepaymentDebitCardBtn()
        {
            _act.waitForVisibilityOfElement(_homeDetailsLoc.ClickRepaymentDebitCardBtn, 60);
            _act.click(_homeDetailsLoc.ClickRepaymentDebitCardBtn, "ClickRepaymentDebitCardBtn");
            _act.waitForVisibilityOfElement(_homeDetailsLoc.WaitForPaymentpage, 120);
        }

/// <summary>
/// ////////////////////////////////////////////////
/// </summary>

        public void LaunchNimbleUrl()
        {
            Thread.Sleep(2000);
            _act.launchUrl("https://staging.inator.com.au/");
         }
        /// <summary>
        /// Confirm BPAY for making a repayment
        /// </summary>
        public void ClickRepaymentBPAYBtn()
        {
            _act.waitForVisibilityOfElement(_homeDetailsLoc.ClickRepaymentBPAYBtn, 60);
            _act.click(_homeDetailsLoc.ClickRepaymentBPAYBtn, "ClickRepaymentBPAYBtn");
        }

        /// <summary>
        /// Confirm EFT for making a repayment
        /// </summary>
        public void ClickRepaymentEFTBtn()
        {
            _act.waitForVisibilityOfElement(_homeDetailsLoc.ClickRepaymentEFTBtn, 60);
            _act.click(_homeDetailsLoc.ClickRepaymentEFTBtn, "ClickRepaymentEFTBtn");
        }

        /// <summary>
        /// Click Back on Repayment pop up message
        /// </summary>
        public void ClickRepaymentBackBtn()
        {
            _act.waitForVisibilityOfElement(_homeDetailsLoc.ClickRepaymentBackBtn, 60);
            _act.click(_homeDetailsLoc.ClickRepaymentBackBtn, "ClickRepaymentBackBtn");
        }

        /// <summary>
        /// Click Continue on Repayment pop up message
        /// </summary>
        public void ClickRepaymentConfirmBtn()
        {
            _act.waitForVisibilityOfElement(_homeDetailsLoc.ClickRepaymentConfirmBtn, 60);
            _act.click(_homeDetailsLoc.ClickRepaymentConfirmBtn, "ClickRepaymentConfirmBtn");
        }

        /// <summary>
        /// Enter Name on Card for Debit Card option of Make a Repayment
        /// </summary>
        public void EnterRepaymentNameOnCardTxt(string nameOnCard)
        {
            _act.waitForVisibilityOfElement(_homeDetailsLoc.EnterRepaymentNameOnCardTxt, 120);
            _act.EnterText(_homeDetailsLoc.EnterRepaymentNameOnCardTxt, nameOnCard);
        }

        /// <summary>
        /// Enter Card Number for Debit Card option of Make a Repayment
        /// </summary>
        public void EnterRepaymentCardNumberTxt(string cardNumber)
        {
            _act.waitForVisibilityOfElement(_homeDetailsLoc.EnterRepaymentCardNumberTxt, 120);
            _act.EnterText(_homeDetailsLoc.EnterRepaymentCardNumberTxt, cardNumber);
        }

        /// <summary>
        /// Enter Card Expiry Date for Debit Card option of Make a Repayment
        /// </summary>
        public void EnterRepaymentExpiryTxt(string cardExpiry)
        {
            _act.waitForVisibilityOfElement(_homeDetailsLoc.EnterRepaymentExpiryTxt, 120);
            _act.EnterText(_homeDetailsLoc.EnterRepaymentExpiryTxt, cardExpiry);
        }

        /// <summary>
        /// Enter Card Security code for Debit Card option of Make a Repayment
        /// </summary>
        public void EnterRepaymentSecurityTxt(string cardSecurity)
        {
            _act.waitForVisibilityOfElement(_homeDetailsLoc.EnterRepaymentSecurityTxt, 120);
            _act.EnterText(_homeDetailsLoc.EnterRepaymentSecurityTxt, cardSecurity);
        }

        /// <summary>
        /// Click Done for Debit Card option of Make a Repayment
        /// </summary>
        public void ClickRepaymentDebitCardDoneBtn()
        {
            _act.waitForVisibilityOfElement(_homeDetailsLoc.ClickRepaymentDebitCardDoneBtn, 120);
            _act.click(_homeDetailsLoc.ClickRepaymentDebitCardDoneBtn, "ClickRepaymentDebitCardDoneBtn");
        }

        /// <summary>
        /// Click Edit Profile in Member Area
        /// </summary>
        public void ClickMemberAreaEditProfileLnk()
        {
            _act.waitForVisibilityOfElement(_homeDetailsLoc.ClickMemberAreaEditProfileLnk, 60);
            _act.click(_homeDetailsLoc.ClickMemberAreaEditProfileLnk, "ClickMemberAreaEditProfileLnk");
        }

        /// <summary>
        /// Expand Contact Details section of Edit Profile, in Member Area
        /// </summary>
        public void ClickEditProfileContactDetailsBtn()
        {
            _act.waitForVisibilityOfElement(_homeDetailsLoc.ClickEditProfileContactDetailsBtn, 60);
            _act.click(_homeDetailsLoc.ClickEditProfileContactDetailsBtn, "ClickEditProfileContactDetailsBtn");
        }

        /// <summary>
        /// Edit Street Name field of Edit Profile, in Member Area
        /// </summary>
        /// <param name="overrides"></param>
        public void EnterEditProfileStreetNameTxt(string overrides)
        {
            _act.waitForVisibilityOfElement(_homeDetailsLoc.EnterEditProfileStreetNameTxt, 120);
            _act.EnterText(_homeDetailsLoc.EnterEditProfileStreetNameTxt, overrides);
        }

        /// <summary>
        /// Click Save button of Edit Profile, in Member Area
        /// </summary>
        public void ClickEditProfileSaveBtn()
        {
            _act.waitForVisibilityOfElement(_homeDetailsLoc.ClickEditProfileSaveBtn, 60);
            _act.click(_homeDetailsLoc.ClickEditProfileSaveBtn, "ClickEditProfileSaveBtn");
        }

        /// <summary>
        /// Click button to return to Loan Dashboard, in Member Area
        /// </summary>
        public void ClickEditProfileLoanDashboardBtn()
        {
            _act.waitForVisibilityOfElement(_homeDetailsLoc.ClickEditProfileLoanDashboardBtn, 60);
            _act.click(_homeDetailsLoc.ClickEditProfileLoanDashboardBtn, "ClickEditProfileLoanDashboardBtn");
        }

        /// <summary>
        /// Mobile Member Area - More tab icon
        /// </summary>
        public void ClickMobileMoreBtn()
        {
            _act.waitForVisibilityOfElement(_homeDetailsLoc.ClickMobileMoreBtn, 60);
            _act.click(_homeDetailsLoc.ClickMobileMoreBtn, "ClickMobileMoreBtn");
        }

        /// <summary>
        /// Mobile Member Area Your Profile link
        /// </summary>
        public void ClickMobileYourProfileLnk()
        {
            _act.waitForVisibilityOfElement(_homeDetailsLoc.ClickMobileYourProfileLnk, 60);
            _act.click(_homeDetailsLoc.ClickMobileYourProfileLnk, "ClickMobileYourProfileLnk");
        }

        /// <summary>
        /// Mobile Member Area Contact page
        /// </summary>
        public void ClickMobileYourProfileContactLnk()
        {
            _act.waitForVisibilityOfElement(_homeDetailsLoc.ClickMobileYourProfileContactLnk, 60);
            _act.click(_homeDetailsLoc.ClickMobileYourProfileContactLnk, "ClickMobileYourProfileContactLnk");
        }

        /// <summary>
        /// Mobile Member Area entering overrides into Stree Name field
        /// </summary>
        /// <param name="overrides"></param>
        public void EnterMobileYourProfileStreetNameTxt(string overrides)
        {
            _act.waitForVisibilityOfElement(_homeDetailsLoc.EnterMobileYourProfileStreetNameTxt, 120);
            _act.EnterText(_homeDetailsLoc.EnterMobileYourProfileStreetNameTxt, overrides);
        }

        /// <summary>
        /// Mobile Member Area profile edit Save button
        /// </summary>
        public void ClickMobileYourProfileSaveBtn()
        {
            _act.waitForVisibilityOfElement(_homeDetailsLoc.ClickMobileYourProfileSaveBtn, 60);
            _act.click(_homeDetailsLoc.ClickMobileYourProfileSaveBtn, "ClickMobileYourProfileSaveBtn");
        }

        /// <summary>
        /// Mobile Member Area - Dashboard tab icon
        /// </summary>
        public void ClickMobileDashboardLnk()
        {
            _act.waitForVisibilityOfElement(_homeDetailsLoc.ClickMobileDashboardLnk, 60);
            _act.click(_homeDetailsLoc.ClickMobileDashboardLnk, "ClickMobileDashboardLnk");
        }

        /// <summary>
        /// Desktop Member Area - 'Your Dashboard' link
        /// </summary>
        public void ClickDesktopYourDashboardLnk()
        {
            _act.waitForVisibilityOfElement(_homeDetailsLoc.ClickDesktopYourDashboardLnk, 60);
            _act.click(_homeDetailsLoc.ClickDesktopYourDashboardLnk, "ClickDesktopYourDashboardLnk");
        }

        /// <summary>
        /// Desktop Member Area - close button for marketing survey triggered either at
        /// Bank or Set Up Loan step
        /// Only available in desktop nl/rl, not in mobile
        /// </summary>
        public void ClickMarketSurveyCloseBtn()
        {
            _act.waitForVisibilityOfElement(_homeDetailsLoc.ClickMarketSurveyCloseBtn, 60);
            _act.click(_homeDetailsLoc.ClickMarketSurveyCloseBtn, "ClickMarketSurveyCloseBtn");
        }
    }
}

