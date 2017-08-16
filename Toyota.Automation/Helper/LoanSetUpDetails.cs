using Nimble.Automation.Accelerators;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Nimble.Automation.Repository
{
    public class LoanSetUpDetails : TestEngine
    {
        private ILoanSetupDetails _loansetupdetailsLoc;
        private ActionEngine _act = null;
        private IWebDriver _driver = null;



        public LoanSetUpDetails(IWebDriver driver, string strUserType)
        {
            if (GetPlatform(driver))
                _loansetupdetailsLoc = (strUserType == "NL") ? (ILoanSetupDetails)new LoanSetupDetailsMobileNLLoc() : new LoanSetupDetailsMobileRLLoc();

            else
                _loansetupdetailsLoc = (strUserType == "NL") ? (ILoanSetupDetails)new LoanSetupDetailsDesktopNLLoc() : new LoanSetupDetailsDesktopRLLoc();
            _act = new ActionEngine(driver);
            _driver = driver;
        }

        //public void FetchGUIDandEmail()
        //{
        //    string EmailId = getText(_loansetupdetailsLoc.EmailinDashboard, "Email");
        //    string GUID = getText(_loansetupdetailsLoc.GUIDDashboard, "GUID");
        //}

        /// <summary>
        /// Clicks the refresh button.
        /// </summary>
        public void ClickRefreshBtn()
        {
            _act.waitForVisibilityOfElement(_loansetupdetailsLoc.RefreshButton, 60);
            _act.click(_loansetupdetailsLoc.RefreshButton, "RefreshButton");
        }

        /// <summary>
        /// Verify and the click setup button.
        /// </summary>
        public void VerifyandClickSetupBtn()
        {
            _act.waitForVisibilityOfElement(_loansetupdetailsLoc.SetupButton, 60);
            _act.click(_loansetupdetailsLoc.SetupButton, "SetupButton");
        }

        /// <summary>
        /// Click Verify button.
        /// </summary>
        public void ClickVerifyBtn()
        {
            _act.waitForVisibilityOfElement(_loansetupdetailsLoc.VerifyButton, 60);
            _act.click(_loansetupdetailsLoc.VerifyButton, "VerifyButton");
        }

        /// <summary>
        /// Verifies the verify BTN.
        /// </summary>
        /// <returns>bool true if exist else false</returns>
        public bool VerifyVerifyBtn()
        {
           return _act.waitForVisibilityOfElement(_loansetupdetailsLoc.VerifyButton, 120);
            
        }

        /// <summary>
        /// Verifies the amount.
        /// </summary>
        /// <param name="RequestedAmount">The requested amount.</param>
        /// <exception cref="System.Exception">Approved Loan Amount : " + 2000 + " is not verified Successfully</exception>
        public void VerifyAmount(string RequestedAmount)
        {
            _act.waitForVisibilityOfElement(_loansetupdetailsLoc.ApprovedloanAmount, 120);
            string ApprovedLoanAmt = _act.getText(_loansetupdetailsLoc.ApprovedloanAmount, "Approved Loan Amount");
            // ApprovedLoanAmt;
            if (!ApprovedLoanAmt.Equals("") && ApprovedLoanAmt.Equals("1000"))
            {
                _act.click(_loansetupdetailsLoc.DetailedrepaymentscheduleButton, "DetailedrepaymentscheduleButton");
            }
            else
            {
                throw new Exception("Approved Loan Amount : " + 2000 + " is not verified Successfully");
            }
        }

        /// <summary>
        /// Verifies the first repayment date.
        /// </summary>
        /// <exception cref="System.Exception">Repayment Date Failed to display as in Detailed schedules</exception>
        public void VerifyFirstRepaymentDate()
        {
            string firstrepaymentdate = _act.getText(_loansetupdetailsLoc.firstrepaymentdate, "firstrepaymentdate");

            string Detailedrepaymentschedule = _act.getText(_loansetupdetailsLoc.Detailedpaymentamount, "Detailedrepaymentschedule");

            string firstrepayment = Convert.ToDateTime(firstrepaymentdate).ToString("MMM dd");

            string detailedrepayment = Convert.ToDateTime(Detailedrepaymentschedule).ToString("MMM dd");

            if (firstrepayment == detailedrepayment)
            {
                Console.WriteLine(" First repayment  : " + firstrepaymentdate + " is verified with Detailed repayment schedule :" + Detailedrepaymentschedule);
            }
            else
            {
                throw new Exception("Repayment Date Failed to display as in Detailed schedules");
            }
        }

        /// <summary>
        /// Clicks the submit button.
        /// </summary>
        public void ClickSubmitBtn()
        {
            _act.waitForVisibilityOfElement(_loansetupdetailsLoc.ButtonSubmit, 300);
            _act.click(_loansetupdetailsLoc.ButtonSubmit, "ButtonSubmit");
        }

        /// <summary>
        /// Find and selects the spendless.
        /// </summary>
        /// <returns>bool if exist: true else false</returns>
        public bool FindandselectSpendless()
        {
            Thread.Sleep(5000);
            bool flag = false;
            if (_act.isElementPresent(_loansetupdetailsLoc.JustCheckingLabel))
            {
                flag = true;
            }
            else
            {
                flag = false;
            }
            return flag;
        }

        /// <summary>
        /// Selects the reason to spend less.
        /// </summary>
        /// <param name="ReasonforSpendLess">The reasonfor spend less.</param>
        public void SelectReasontospendLess(string ReasonforSpendLess)
        {
            if (GetPlatform(_driver))
            {
                if (ReasonforSpendLess.Contains(","))
                {
                    var spendreasons = ReasonforSpendLess.Split(',');
                    foreach (var reason in spendreasons)
                    {
                        var choosereason = By.XPath(".//label[contains(text(),'" + reason + "')]");
                        _act.waitForVisibilityOfElement(choosereason, 60);
                        _act.JSClick(choosereason, "selectreason");
                    }
                    _act.JSClick(_loansetupdetailsLoc.reasonsubmitBtn, "reasonsubmitBtn");
                }
                else
                {
                    var choosereason = By.XPath(".//label[contains(text(),'" + ReasonforSpendLess + "')]");
                    _act.waitForVisibilityOfElement(choosereason, 60);
                    _act.JSClick(choosereason, "selectreason");
                    _act.JSClick(_loansetupdetailsLoc.reasonsubmitBtn, "reasonsubmitBtn");
                }
            }
            else
            {
                if (ReasonforSpendLess.Contains(","))
                {
                    var spendreasons = ReasonforSpendLess.Split(',');
                    foreach (var reason in spendreasons)
                    {
                        var choosereason = By.XPath(".//table[@id='offerOptions']//tr/td/label[contains(text(),'" + reason + "')]");
                        _act.waitForVisibilityOfElement(choosereason, 60);
                        _act.JSClick(choosereason, "selectreason");
                    }
                    _act.JSClick(_loansetupdetailsLoc.reasonsubmitBtn, "reasonsubmitBtn");
                }
                else
                {
                    var choosereason = By.XPath(".//table[@id='offerOptions']//tr/td/label[contains(text(),'" + ReasonforSpendLess + "')]");
                    _act.waitForVisibilityOfElement(choosereason, 60);
                    _act.JSClick(choosereason, "selectreason");
                    _act.JSClick(_loansetupdetailsLoc.reasonsubmitBtn, "reasonsubmitBtn");
                }
            }
        }

        public void Loancontract()
        {
            _act.waitForVisibilityOfElement(_loansetupdetailsLoc.Loancontract, 500);
            IWebElement sliderElement = _driver.FindElement(_loansetupdetailsLoc.Loancontract);
            IWebElement scrolldown = _driver.FindElement(By.XPath(".//div[@id='scrollBottom']"));
            _driver.FindElement(_loansetupdetailsLoc.LoanContractLabel).Click();
            bool elementvisible = _act.isElementDisabled(_loansetupdetailsLoc.confirmLoancotract);
            Actions actions = new Actions(_driver);
            actions.MoveToElement(scrolldown);
            actions.Perform();
            
        }

        public int GetRepaymentAmountSetupPage()
        {
            Thread.Sleep(4000);
            _act.waitForVisibilityOfElement(_loansetupdetailsLoc.RepaymentSetupPage, 60);
            string amount = _act.getText(_loansetupdetailsLoc.RepaymentSetupPage, "");
            var repay = amount.Split('.');
            string repayamt = repay[0];
            repayamt = repayamt.Replace("$", "");
            repayamt = repayamt.Replace(",", "");
            int repamt = Convert.ToInt32(repayamt);
            return repamt;
        }

        public int GetRepaymentAmountConfirmPage()
        {
            _act.waitForVisibilityOfElement(_loansetupdetailsLoc.RepaymentConfirmPage, 60);
            string amount = _act.getText(_loansetupdetailsLoc.RepaymentConfirmPage, "");
            var repay = amount.Split('.');
            string repayamt = repay[0];
            repayamt = repayamt.Replace("$", "");
            repayamt = repayamt.Replace(",", "");
            int repamt = Convert.ToInt32(repayamt);
            return repamt;
        }

        public int getRepaymentCountConfirmPage()
        {
            _act.waitForVisibilityOfElement(_loansetupdetailsLoc.RepaymentConfirmPage, 60);
            string amount = _act.getText(_loansetupdetailsLoc.RepaymentConfirmPage, "");
            var repay = amount.Split('.');
            string repayamt = repay[0];
            repayamt = repayamt.Replace("$", "");
            repayamt = repayamt.Replace(",", "");
            int repamt = Convert.ToInt32(repayamt);
            return repamt;
        }

        public int getRepaymentAmountSetupPage()
        {
            Thread.Sleep(4000);
            _act.waitForVisibilityOfElement(_loansetupdetailsLoc.RepaymentSetupPage, 60);
            string amount = _act.getText(_loansetupdetailsLoc.RepaymentSetupPage, "");
            var repay = amount.Split('.');
            string repayamt = repay[0];
            repayamt = repayamt.Replace("$", "");
            repayamt = repayamt.Replace(",", "");
            int repamt = Convert.ToInt32(repayamt);
            return repamt;
        }

        public string getFinalRepaymentDateSetupPage()
        {
           
            _act.waitForVisibilityOfElement(_loansetupdetailsLoc.FinalRepaymentDateSetupPage, 240);
            string date = _act.getText(_loansetupdetailsLoc.FinalRepaymentDateSetupPage, "");
            return date;
           
        }

        public void ClickFortnight()
        {
            _act.waitForVisibilityOfElement(_loansetupdetailsLoc.FortNight, 60);
            _act.click(_loansetupdetailsLoc.FortNight, "");
        }

        public void ClickMonthly()
        {
            _act.waitForVisibilityOfElement(_loansetupdetailsLoc.Monthly, 60);
            _act.click(_loansetupdetailsLoc.Monthly, "");
        }

        public bool getAmtOfCredit(int loanamt)
        {
            bool flag = false;
            _act.waitForVisibilityOfElement(_loansetupdetailsLoc.AmountOfCredit, 60);
            string amount = _act.getText(_loansetupdetailsLoc.AmountOfCredit, "");
            var repay = amount.Split('.');
            string repayamt = repay[0];
            repayamt = repayamt.Replace("$", "");
            repayamt = repayamt.Replace(",", "");
            int repamt = Convert.ToInt32(repayamt);
            // return repamt;
            
            int e = Convert.ToInt32(0.04 * loanamt);
           
            int  f = Convert.ToInt32(0.20 * loanamt);
            int c = e + f + loanamt;
            if (c == repamt)
            {
                flag = true;
            }
            return flag;
        }
        public bool getDisclosureDate()
        {
            bool flag = false;
            _act.waitForVisibilityOfElement(_loansetupdetailsLoc.DisclosureDate, 60);
            string date = _act.getText(_loansetupdetailsLoc.DisclosureDate, "");
            DateTime today = DateTime.Today;

            string currentDate = today.ToString("dd/MM/yyyy");
            var date1 = currentDate.Split('/');
            string todayDate = date1[0];

            if (date.Contains(todayDate))
            {
                flag = true;
            }
            return flag;
        }

        public string GetFirstDateConfirmPage()
        {
        
            _act.waitForVisibilityOfElement(_loansetupdetailsLoc.FirstDateConfirmPage, 60);
            string date = _act.getText(_loansetupdetailsLoc.FirstDateConfirmPage, "");
            var date1 = date.Split(',');
            string day = date1[0];
            var date2 = day.Split('/');
            string date3 = date2[0];

            return date3;
        }

        public string GetLastDateConfirmPage()
        {
            _act.waitForVisibilityOfElement(_loansetupdetailsLoc.LastDateConfirmPage, 60);
            string date = _act.getText(_loansetupdetailsLoc.LastDateConfirmPage, "");
            var date1 = date.Split(',');
            string day = date1[0];
            var date2 = day.Split('/');
            string date3 = date2[0];

            return date3;
        }

        public string getunconfirmedcontractmsg()
        {
            _act.waitForVisibilityOfElement(_loansetupdetailsLoc.Unconfirmedcontractmsg, 60);
            string warningmsg = _act.getText(_loansetupdetailsLoc.Unconfirmedcontractmsg, "");
            return warningmsg;
        }

        public string getunconfirmedpurposemsg()
        {
            _act.waitForVisibilityOfElement(_loansetupdetailsLoc.Unconfirmedpurposemsg, 60);
            string warningmsg = _act.getText(_loansetupdetailsLoc.Unconfirmedpurposemsg, "");
            return warningmsg;
        }

        public string getunconfirmedrepaymsg()
        {
            _act.waitForVisibilityOfElement(_loansetupdetailsLoc.Unconfirmedrepaymsg, 60);
            string warningmsg = _act.getText(_loansetupdetailsLoc.Unconfirmedrepaymsg, "");
            return warningmsg;
        }

        public string getLastDateConfirmPage()
        {
            _act.waitForVisibilityOfElement(_loansetupdetailsLoc.LastDateConfirmPage, 60);
            string date = _act.getText(_loansetupdetailsLoc.LastDateConfirmPage, "");
            var date1 = date.Split(',');
            string day = date1[0];
            var date2 = day.Split('/');
            string date3 = date2[0];

            return date3;
        }
        //public void ConfirmAcceptingContract()
        //{
        //    Actions builder = new Actions(_driver);
        //    IWebElement readandacceptterms = _driver.FindElement(_loansetupdetailsLoc.confirmLoancotract);
        //    // builder.MoveToElement(readandacceptterms, 10, 10).Click().Build().Perform();
        //    readandacceptterms.Click();
        //    Thread.Sleep(3000);
        //    IWebElement confirmreqandpurpose = _driver.FindElement(_loansetupdetailsLoc.confirmpurpose);
        //    builder.MoveToElement(confirmreqandpurpose, 10, 10).Click().Build().Perform();      
        //    Thread.Sleep(3000);
        //    IWebElement confirmrepayment = _driver.FindElement(_loansetupdetailsLoc.confirmrepay);
        //    builder.MoveToElement(confirmrepayment, 10, 10).Click().Build().Perform();      
        //    Thread.Sleep(3000);
        //    confirmrepayment = _driver.FindElement(_loansetupdetailsLoc.confirmrepay);
        //    builder.MoveToElement(confirmrepayment, 10, 10).Click().Build().Perform();         
        //    Thread.Sleep(3000);
        //    confirmrepayment = _driver.FindElement(_loansetupdetailsLoc.confirmrepay);
        //    builder.MoveToElement(confirmrepayment, 10, 10).Click().Build().Perform();       
        //    Thread.Sleep(3000);
        //}

        /// <summary>
        /// Confirms the accepting contract.
        /// </summary>
        public void ConfirmAcceptingContract()
        {
            if (GetPlatform(_driver))
            {

                IWebElement confirmLoancotractBtn = _driver.FindElement(_loansetupdetailsLoc.confirmLoancotract);
                Actions actions = new Actions(_driver);
                actions.MoveToElement(confirmLoancotractBtn);
                actions.Perform();

                _act.waitForVisibilityOfElement(_loansetupdetailsLoc.confirmLoancotract, 200);
                _act.JSClick(_loansetupdetailsLoc.confirmLoancotract, "confirmLoancotract");

                _act.waitForVisibilityOfElement(_loansetupdetailsLoc.confirmpurpose, 200);
                _act.JSClick(_loansetupdetailsLoc.confirmpurpose, "confirmpurpose");

                _act.waitForVisibilityOfElement(_loansetupdetailsLoc.confirmrepay, 200);
                _act.JSClick(_loansetupdetailsLoc.confirmrepay, "confirmrepay");
            }
            else
            {
                IWebElement confirmLoancotractBtn = _driver.FindElement(_loansetupdetailsLoc.confirmLoancotract);
                Actions actions = new Actions(_driver);
                actions.MoveToElement(confirmLoancotractBtn);
                actions.Perform();


                _act.waitForVisibilityOfElement(_loansetupdetailsLoc.confirmLoancotract, 200);
                _act.JSClick(_loansetupdetailsLoc.confirmLoancotract, "confirmLoancotract");

                _act.waitForVisibilityOfElement(_loansetupdetailsLoc.confirmpurpose, 200);
                _act.JSClick(_loansetupdetailsLoc.confirmpurpose, "confirmpurpose");

                _act.waitForVisibilityOfElement(_loansetupdetailsLoc.confirmrepay, 200);
                _act.JSClick(_loansetupdetailsLoc.confirmrepay, "confirmrepay");
            }


        }

        /// <summary>
        /// Partials the confirm accepting contract and purpose.
        /// </summary>
        public void PartialConfirmAcceptingContractwithcontractandpurpose()
        {
            if (GetPlatform(_driver))
            {
                IWebElement confirmLoancotractBtn = _driver.FindElement(_loansetupdetailsLoc.confirmLoancotract);
                Actions actions = new Actions(_driver);
                actions.MoveToElement(confirmLoancotractBtn);
                actions.Perform();

                // check 1 and 2 radio buttons

                _act.waitForVisibilityOfElement(_loansetupdetailsLoc.confirmLoancotract, 200);
                _act.JSClick(_loansetupdetailsLoc.confirmLoancotract, "confirmLoancotract"); // 1 checked

                _act.waitForVisibilityOfElement(_loansetupdetailsLoc.confirmpurpose, 200);
                _act.JSClick(_loansetupdetailsLoc.confirmpurpose, "confirmpurpose");  // 2 checked

                //_act.waitForVisibilityOfElement(_loansetupdetailsLoc.confirmrepay, 60);
                //_act.JSClick(_loansetupdetailsLoc.confirmrepay, "confirmrepay");       // 3 unchecked
            }
            else
            {
                IWebElement confirmLoancotractBtn = _driver.FindElement(_loansetupdetailsLoc.confirmLoancotract);
                Actions actions = new Actions(_driver);
                actions.MoveToElement(confirmLoancotractBtn);
                actions.Perform();

                // check 1 and 2 radio buttons

                _act.waitForVisibilityOfElement(_loansetupdetailsLoc.confirmLoancotract, 60);
                _act.JSClick(_loansetupdetailsLoc.confirmLoancotract, "confirmLoancotract"); // 1 checked

                _act.waitForVisibilityOfElement(_loansetupdetailsLoc.confirmpurpose, 60);
                _act.JSClick(_loansetupdetailsLoc.confirmpurpose, "confirmpurpose");  // 2 checked

                //_act.waitForVisibilityOfElement(_loansetupdetailsLoc.confirmrepay, 60);
                //_act.JSClick(_loansetupdetailsLoc.confirmrepay, "confirmrepay");   // 3 unchecked
            }
        }

        /// <summary>
        /// Partials the confirm accepting contract and repay.
        /// </summary>
        public void PartialConfirmAcceptingContractwithcontractandrepay()
        {
            if (GetPlatform(_driver))
            {
                IWebElement confirmLoancotractBtn = _driver.FindElement(_loansetupdetailsLoc.confirmLoancotract);
                Actions actions = new Actions(_driver);
                actions.MoveToElement(confirmLoancotractBtn);
                actions.Perform();

                // check 1 and 3 radio buttons

                // _act.waitForVisibilityOfElement(_loansetupdetailsLoc.confirmLoancotract, 60);
                // _act.JSClick(_loansetupdetailsLoc.confirmLoancotract, "confirmLoancotract");   // 1 checked

                _act.waitForVisibilityOfElement(_loansetupdetailsLoc.confirmpurpose, 60);
                _act.JSClick(_loansetupdetailsLoc.confirmpurpose, "confirmpurpose");            // 2 unchecked

                _act.waitForVisibilityOfElement(_loansetupdetailsLoc.confirmrepay, 60);
                _act.JSClick(_loansetupdetailsLoc.confirmrepay, "confirmrepay");            // 3 checked
            }
            else
            {
                IWebElement confirmLoancotractBtn = _driver.FindElement(_loansetupdetailsLoc.confirmLoancotract);
                Actions actions = new Actions(_driver);
                actions.MoveToElement(confirmLoancotractBtn);
                actions.Perform();

                // check 1 and 3 radio buttons

                //_act.waitForVisibilityOfElement(_loansetupdetailsLoc.confirmLoancotract, 60);
                //_act.JSClick(_loansetupdetailsLoc.confirmLoancotract, "confirmLoancotract");     // 1 checked

                _act.waitForVisibilityOfElement(_loansetupdetailsLoc.confirmpurpose, 60);
                _act.JSClick(_loansetupdetailsLoc.confirmpurpose, "confirmpurpose");       // 2 unchecked

                _act.waitForVisibilityOfElement(_loansetupdetailsLoc.confirmrepay, 60);
                _act.JSClick(_loansetupdetailsLoc.confirmrepay, "confirmrepay");        // 3 checked
            }
        }

        /// <summary>
        /// Partials the confirm accepting purpose and repay.
        /// </summary>
        public void PartialConfirmAcceptingContractwithpurposeandrepay()
        {
            if (GetPlatform(_driver))
            {
                IWebElement confirmLoancotractBtn = _driver.FindElement(_loansetupdetailsLoc.confirmLoancotract);
                Actions actions = new Actions(_driver);
                actions.MoveToElement(confirmLoancotractBtn);
                actions.Perform();

                // check 2 and 3 radio buttons

                _act.waitForVisibilityOfElement(_loansetupdetailsLoc.confirmLoancotract, 60);
                _act.JSClick(_loansetupdetailsLoc.confirmLoancotract, "confirmLoancotract");   // 1 unchecked

                _act.waitForVisibilityOfElement(_loansetupdetailsLoc.confirmpurpose, 60);
                _act.JSClick(_loansetupdetailsLoc.confirmpurpose, "confirmpurpose");           // 2 checked

                // _act.waitForVisibilityOfElement(_loansetupdetailsLoc.confirmrepay, 60);
                // _act.JSClick(_loansetupdetailsLoc.confirmrepay, "confirmrepay");           // 3 checked
            }
            else
            {
                IWebElement confirmLoancotractBtn = _driver.FindElement(_loansetupdetailsLoc.confirmLoancotract);
                Actions actions = new Actions(_driver);
                actions.MoveToElement(confirmLoancotractBtn);
                actions.Perform();

                // check 2 and 3 radio buttons

                _act.waitForVisibilityOfElement(_loansetupdetailsLoc.confirmLoancotract, 60);
                _act.JSClick(_loansetupdetailsLoc.confirmLoancotract, "confirmLoancotract"); // 1 unchecked

                _act.waitForVisibilityOfElement(_loansetupdetailsLoc.confirmpurpose, 60);
                _act.JSClick(_loansetupdetailsLoc.confirmpurpose, "confirmpurpose");      // 2 checked

                //_act.waitForVisibilityOfElement(_loansetupdetailsLoc.confirmrepay, 60);
                // _act.JSClick(_loansetupdetailsLoc.confirmrepay, "confirmrepay");         // 3 checked
            }
        }

        /// <summary>
        /// complete the confirm accepting contract, purpose and reapy.
        /// </summary>
        public void CompleteConfirmAcceptingContract()
        {
            if (GetPlatform(_driver))
            {
                IWebElement confirmLoancotractBtn = _driver.FindElement(_loansetupdetailsLoc.confirmLoancotract);
                Actions actions = new Actions(_driver);
                actions.MoveToElement(confirmLoancotractBtn);
                actions.Perform();

                // check 1, 2 and 3 radio buttons

                _act.waitForVisibilityOfElement(_loansetupdetailsLoc.confirmLoancotract, 200);
                _act.JSClick(_loansetupdetailsLoc.confirmLoancotract, "confirmLoancotract");   // 1 checked

                // _act.waitForVisibilityOfElement(_loansetupdetailsLoc.confirmpurpose, 60);
                //_act.JSClick(_loansetupdetailsLoc.confirmpurpose, "confirmpurpose");           // 2 checked

                // _act.waitForVisibilityOfElement(_loansetupdetailsLoc.confirmrepay, 60);
                // _act.JSClick(_loansetupdetailsLoc.confirmrepay, "confirmrepay");           // 3 checked
            }
            else
            {
                IWebElement confirmLoancotractBtn = _driver.FindElement(_loansetupdetailsLoc.confirmLoancotract);
                Actions actions = new Actions(_driver);
                actions.MoveToElement(confirmLoancotractBtn);
                actions.Perform();

                // check 1, 2 and 3 radio buttons

                _act.waitForVisibilityOfElement(_loansetupdetailsLoc.confirmLoancotract, 200);
                _act.JSClick(_loansetupdetailsLoc.confirmLoancotract, "confirmLoancotract"); // 1 checked

                // _act.waitForVisibilityOfElement(_loansetupdetailsLoc.confirmpurpose, 60);
                // _act.JSClick(_loansetupdetailsLoc.confirmpurpose, "confirmpurpose");      // 2 checked

                //_act.waitForVisibilityOfElement(_loansetupdetailsLoc.confirmrepay, 60);
                // _act.JSClick(_loansetupdetailsLoc.confirmrepay, "confirmrepay");         // 3 checked
            }
        }

        /// <summary>
        /// Partials the confirm accepting purpose and repay.
        /// </summary>
        public void UnConfirmAcceptingLoanContract()
        {
            if (GetPlatform(_driver))
            {
                IWebElement confirmLoancotractBtn = _driver.FindElement(_loansetupdetailsLoc.confirmLoancotract);
                Actions actions = new Actions(_driver);
                actions.MoveToElement(confirmLoancotractBtn);
                actions.Perform();

                // uncheck 1

                _act.waitForVisibilityOfElement(_loansetupdetailsLoc.confirmLoancotract, 60);
                _act.JSClick(_loansetupdetailsLoc.confirmLoancotract, "confirmLoancotract");   // 1 unchecked

                // _act.waitForVisibilityOfElement(_loansetupdetailsLoc.confirmpurpose, 60);
                //_act.JSClick(_loansetupdetailsLoc.confirmpurpose, "confirmpurpose");           // 2 checked

                // _act.waitForVisibilityOfElement(_loansetupdetailsLoc.confirmrepay, 60);
                // _act.JSClick(_loansetupdetailsLoc.confirmrepay, "confirmrepay");           // 3 checked
            }
            else
            {
                IWebElement confirmLoancotractBtn = _driver.FindElement(_loansetupdetailsLoc.confirmLoancotract);
                Actions actions = new Actions(_driver);
                actions.MoveToElement(confirmLoancotractBtn);
                actions.Perform();

                // uncheck 1

                _act.waitForVisibilityOfElement(_loansetupdetailsLoc.confirmLoancotract, 60);
                _act.JSClick(_loansetupdetailsLoc.confirmLoancotract, "confirmLoancotract"); // 1 unchecked

                // _act.waitForVisibilityOfElement(_loansetupdetailsLoc.confirmpurpose, 60);
                // _act.JSClick(_loansetupdetailsLoc.confirmpurpose, "confirmpurpose");      // 2 checked

                // _act.waitForVisibilityOfElement(_loansetupdetailsLoc.confirmrepay, 60);
                // _act.JSClick(_loansetupdetailsLoc.confirmrepay, "confirmrepay");         // 3 checked
            }
        }

        /// <summary>
        /// Partials the confirm accepting contract and repay.
        /// </summary>
        public void UnConfirmAcceptingpurpose()
        {
            if (GetPlatform(_driver))
            {
                IWebElement confirmLoancotractBtn = _driver.FindElement(_loansetupdetailsLoc.confirmLoancotract);
                Actions actions = new Actions(_driver);
                actions.MoveToElement(confirmLoancotractBtn);
                actions.Perform();

                // uncheck 2

                _act.waitForVisibilityOfElement(_loansetupdetailsLoc.confirmLoancotract, 60);
                _act.JSClick(_loansetupdetailsLoc.confirmLoancotract, "confirmLoancotract");   // 1 checked

                _act.waitForVisibilityOfElement(_loansetupdetailsLoc.confirmpurpose, 60);
                _act.JSClick(_loansetupdetailsLoc.confirmpurpose, "confirmpurpose");           // 2 unchecked

                // _act.waitForVisibilityOfElement(_loansetupdetailsLoc.confirmrepay, 60);
                // _act.JSClick(_loansetupdetailsLoc.confirmrepay, "confirmrepay");           // 3 checked
            }
            else
            {
                IWebElement confirmLoancotractBtn = _driver.FindElement(_loansetupdetailsLoc.confirmLoancotract);
                Actions actions = new Actions(_driver);
                actions.MoveToElement(confirmLoancotractBtn);
                actions.Perform();

                // uncheck 2

                _act.waitForVisibilityOfElement(_loansetupdetailsLoc.confirmLoancotract, 60);
                _act.JSClick(_loansetupdetailsLoc.confirmLoancotract, "confirmLoancotract"); // 1 checked

                _act.waitForVisibilityOfElement(_loansetupdetailsLoc.confirmpurpose, 60);
                _act.JSClick(_loansetupdetailsLoc.confirmpurpose, "confirmpurpose");      // 2 unchecked

                // _act.waitForVisibilityOfElement(_loansetupdetailsLoc.confirmrepay, 60);
                // _act.JSClick(_loansetupdetailsLoc.confirmrepay, "confirmrepay");         // 3 checked
            }
        }

        /// <summary>
        /// Partials the confirm accepting contract and purpose.
        /// </summary>
        public void UnConfirmAcceptingrepay()
        {
            if (GetPlatform(_driver))
            {
                IWebElement confirmLoancotractBtn = _driver.FindElement(_loansetupdetailsLoc.confirmLoancotract);
                Actions actions = new Actions(_driver);
                actions.MoveToElement(confirmLoancotractBtn);
                actions.Perform();

                // uncheck 3

                //_act.waitForVisibilityOfElement(_loansetupdetailsLoc.confirmLoancotract, 60);
                // _act.JSClick(_loansetupdetailsLoc.confirmLoancotract, "confirmLoancotract");   // 1 checked

                _act.waitForVisibilityOfElement(_loansetupdetailsLoc.confirmpurpose, 200);
                _act.JSClick(_loansetupdetailsLoc.confirmpurpose, "confirmpurpose");           // 2 checked

                _act.waitForVisibilityOfElement(_loansetupdetailsLoc.confirmrepay, 200);
                _act.JSClick(_loansetupdetailsLoc.confirmrepay, "confirmrepay");           // 3 unchecked
            }
            else
            {
                IWebElement confirmLoancotractBtn = _driver.FindElement(_loansetupdetailsLoc.confirmLoancotract);
                Actions actions = new Actions(_driver);
                actions.MoveToElement(confirmLoancotractBtn);
                actions.Perform();

                // uncheck 3

                //_act.waitForVisibilityOfElement(_loansetupdetailsLoc.confirmLoancotract, 60);
                //_act.JSClick(_loansetupdetailsLoc.confirmLoancotract, "confirmLoancotract"); // 1 checked

                _act.waitForVisibilityOfElement(_loansetupdetailsLoc.confirmpurpose, 200);
                _act.JSClick(_loansetupdetailsLoc.confirmpurpose, "confirmpurpose");      // 2 checked

                _act.waitForVisibilityOfElement(_loansetupdetailsLoc.confirmrepay, 200);
                _act.JSClick(_loansetupdetailsLoc.confirmrepay, "confirmrepay");         // 3 unchecked
            }
        }

        /// <summary>
        /// Verify I agree button display or not.
        /// </summary>
        public bool VerifyAgreeBtnDisplay()
        {
            bool flag = false;
            if (_act.isElementPresent(_loansetupdetailsLoc.submitcontractButton))
            {
                IWebElement agreebtn = _driver.FindElement(_loansetupdetailsLoc.submitcontractButton);
                if (_act.isElementDisplayed(agreebtn))
                    flag = true;
                else
                    flag = false;
            }
            return flag;
        }

        /// <summary>
        /// click on I agree button
        /// </summary>
        public void ClickOnAgreeBtn()
        {
            _act.waitForVisibilityOfElement(_loansetupdetailsLoc.submitcontractButton, 500);
            _act.JSClick(_loansetupdetailsLoc.submitcontractButton, "submitcontractButton");
        }

        /// <summary>
        /// Verify whether the I agree button displayed or not.
        /// </summary>
        public bool CheckAgreeBtn()
        {
            bool flag = false;
            if (_act.isElementDisplayed(_driver.FindElement(_loansetupdetailsLoc.submitcontractButton)))
            {
                flag = true;
            }
            return flag;
        }

        /// <summary>
        /// Clicks the acknowledge button.
        /// </summary>
        public void ClickAcknowledgeBtn()
        {
            _act.waitForVisibilityOfElement(_loansetupdetailsLoc.acknowledgebtn, 60);
            _act.click(_loansetupdetailsLoc.acknowledgebtn, "acknowledgebtn");
        }

        /// <summary>
        /// Clicks the submit final button.
        /// </summary>
        public void ClickSubmitFinalBtn()
        {
            _act.waitForVisibilityOfElement(_loansetupdetailsLoc.SubmitButton, 500);
            _act.click(_loansetupdetailsLoc.SubmitButton, "SubmitButton");
        }

        /// <summary>
        /// Clicks the nothanks button.
        /// </summary>
        public void ClickNothanksBtn()
        {
            _act.waitForVisibilityOfElement(_loansetupdetailsLoc.NoThanksButton, 500);
            _act.click(_loansetupdetailsLoc.NoThanksButton, "NoThanksButton");
        }

        /// <summary>
        /// Click want to save card button.
        /// </summary>
        public void ClickAndSaveVisaCardRbtn()
        {
            _act.waitForVisibilityOfElement(_loansetupdetailsLoc.NimbleCardRbtn, 120);
            _act.click(_loansetupdetailsLoc.NimbleCardRbtn, "NimbleCardRbtn");
        }

        /// <summary>
        /// Click on the nimble card submit.
        /// </summary>
        public void ClickOnNimbleCardSubmit()
        {
            _act.waitForVisibilityOfElement(_loansetupdetailsLoc.NimblecardSubmitBtn, 120);
            _act.click(_loansetupdetailsLoc.NimblecardSubmitBtn, "NimblecardSubmitBtn");
        }

        /// <summary>
        /// Verify if Nimble Card offer page Submit button is visible
        /// </summary>
        public bool VerifyNimbleCardSubmitBtnVisible()
        {
          // _driver.FindElement(_loansetupdetailsLoc.NimblecardSubmitBtn);
            return _act.isElementPresent(_loansetupdetailsLoc.NimblecardSubmitBtn, 15);
        }

        /// <summary>
        /// Clicks the loan dashboard.
        /// </summary>
        public void ClickLoanDashboard()
        {

            _act.waitForVisibilityOfElement(_loansetupdetailsLoc.LoanDashBoard, 500);
            _act.click(_loansetupdetailsLoc.LoanDashBoard, "loan dashboard");

        }

        /// <summary>
        /// Clicks the mobile loan dashboard button.
        /// </summary>
        public void ClickMobileLoanDashboardBtn()
        {
            _act.waitForVisibilityOfElement(_loansetupdetailsLoc.LoanDashBoard, 240);
            _act.click(_loansetupdetailsLoc.LoanDashBoard, "loan dashboard");

        }

        /// <summary>
        /// Clicks the more button.
        /// </summary>
        public void ClickMoreBtn()
        {
            _act.waitForVisibilityOfElement(_loansetupdetailsLoc.More, 120);
            _act.click(_loansetupdetailsLoc.More, "loan dashboard");
        }

        /// <summary>
        /// Clicks the loan dashboard manual.
        /// </summary>
        public bool ClickLoanDashboardManual()
        {
           // Thread.Sleep(45000);

            bool flag = false;
            Thread.Sleep(5000); // wait until the loandashboard buttons appears
            _act.waitForVisibilityOfElement(_loansetupdetailsLoc.LoanDashboardManual, 500);                     
            if (_act.isElementDisplayed(_driver.FindElement(_loansetupdetailsLoc.LoanDashboardManual)))
            {
                flag = true;
            }
            if (_act.isElementDisplayed(_driver.FindElement(_loansetupdetailsLoc.LoanDashboardManual)))
            {
                _act.click(_loansetupdetailsLoc.LoanDashboardManual, "LoanDashboardManual");
            }
            return flag;
        }
     



        /// <summary>
        /// Logouts this instance.
        /// </summary>
        public void Logout()
        {
            _act.waitForVisibilityOfElement(_loansetupdetailsLoc.Logout, 500);
            _act.JSClick(_loansetupdetailsLoc.Logout, "Logout");
            Thread.Sleep(2000);
        }

        public bool ActivateCard()
        {
            bool flag = false;

            _act.waitForVisibilityOfElement(_loansetupdetailsLoc.ActivateCard, 500);
            _act.JSClick(_loansetupdetailsLoc.ActivateCard, "ActivateCard");
            _act.waitForVisibilityOfElement(_loansetupdetailsLoc.SecurityQuestion, 180);
            _act.selectByOptionText(_loansetupdetailsLoc.SecurityQuestion, "What is your mother's Maiden Name?", "Bank");
            _act.EnterText(_loansetupdetailsLoc.SecurityAnswer, "Serena");
            _act.EnterText(_loansetupdetailsLoc.LastFourDigits, "1234");
            _act.JSClick(_loansetupdetailsLoc.Productdisclosurebutton, "Productdisclosurebutton");
            _act.JSClick(_loansetupdetailsLoc.Financialservicesbutton, "Financialservicesbutton");
            _act.JSClick(_loansetupdetailsLoc.ActivateCardButton, "ActivateCardButton");
            _act.JSClick(_loansetupdetailsLoc.ActivateDoneButton, "ActivateDoneButton");

            _act.waitForVisibilityOfElement(_loansetupdetailsLoc.Bpay, 100);
            if(_act.isElementDisplayed(_driver.FindElement(_loansetupdetailsLoc.Bpay)))
            {
                flag = true;
            }
            _act.JSClick(_loansetupdetailsLoc.Bpay, "Bpay");
            _act.waitForVisibilityOfElement(_loansetupdetailsLoc.BillerCode, 100);
            _act.EnterText(_loansetupdetailsLoc.BillerCode, "1234");
            _act.JSClick(_loansetupdetailsLoc.VerifyBillerCode, "VerifyBillerCode");
            _act.EnterText(_loansetupdetailsLoc.BpayReference, "Wimble");
            _act.EnterText(_loansetupdetailsLoc.BpayDescription, "roller coaster");
            _act.EnterText(_loansetupdetailsLoc.BpayAmount, "94");
            string amount = "-$" + _act.getValue(_loansetupdetailsLoc.BpayAmount, "sdsa") + ".00";
            _act.JSClick(_loansetupdetailsLoc.BpaySubmit, "BpaySubmit");
            _act.waitForVisibilityOfElement(_loansetupdetailsLoc.BpayActivateButton, 100);
            _act.JSClick(_loansetupdetailsLoc.BpayActivateButton, "BpayActivateButton");
            _act.waitForVisibilityOfElement(_loansetupdetailsLoc.BpayTransactionHistoryButton, 100);
            _act.JSClick(_loansetupdetailsLoc.BpayTransactionHistoryButton, "BpayTransactionHistoryButton");
            _act.waitForVisibilityOfElement(_loansetupdetailsLoc.TransactionAmount, 100);
            string amount1 = _act.getText(_loansetupdetailsLoc.TransactionAmount, "");

            return flag;
        }

        public void LeavePopup()
        {
            _act.waitForVisibilityOfElement(_loansetupdetailsLoc.leavePopupDiv, 120);
            IWebElement popupdiv = _driver.FindElement(_loansetupdetailsLoc.leavePopupDiv);
            Actions actions = new Actions(_driver);
            actions.MoveToElement(popupdiv);
            actions.Perform();
            _act.click(_loansetupdetailsLoc.leavePopupDiv, "leavePopupDiv");
            Thread.Sleep(2000);
           
            _act.click(_loansetupdetailsLoc.leavePopup, "leavePopup");

            
        }

        public void LogoutInbtw()
        {
            _act.waitForVisibilityOfElement(_loansetupdetailsLoc.Logout, 160);
            Thread.Sleep(3000);
            _driver.FindElement(_loansetupdetailsLoc.Logout).Click();
        }

        /// <summary>
        /// Clicks on Finals approve button.
        /// </summary>
        public void FinalApprove()
        {
            _act.waitForVisibilityOfElement(_loansetupdetailsLoc.FinalApprove, 120);
            _act.click(_loansetupdetailsLoc.FinalApprove, "FinalApprove");
        }

        /// <summary>
        /// Clicks the approve button.
        /// </summary>
        public void ClickApproveBtn()
        {
            _act.waitForVisibilityOfElement(_loansetupdetailsLoc.ManualApprove, 120);
            _act.JSClick(_loansetupdetailsLoc.ManualApprove, "Manual Approve");
        }

        /// <summary>
        /// Verifies the approved loan.
        /// </summary>
        /// <param name="LoanAmount">The loan amount.</param>
        /// <returns></returns>
        public bool VerifyApprovedLoan(int LoanAmount)
        {
            bool flag = false;
            int ApprovedAmount = GetApprovedamount();

            // ApprovedLoanAmt;
            if (ApprovedAmount.Equals(LoanAmount))
            {
                Console.WriteLine("Requested amount=approved amount");
                flag = true;
            }
            else
            {
                Console.WriteLine("Requested amount not equal");
                flag = false;
            }
            return flag;
        }

        public bool VerifyRequestedAmtGreaterThanApprovedAmt(int LoanAmount, int approved)
        {
            bool flag = false;
            int ApprovedAmount = approved;

            // ApprovedLoanAmt;
            if (LoanAmount > ApprovedAmount)
            {
                Console.WriteLine("Requested amount>approved amount");
                flag = true;
            }
            else
            {
                Console.WriteLine("Requested amount not greater than approved amount");
                flag = false;
            }
            return flag;
        }

        public int GetApprovedamount()
        {
            string ApprovedLoanAmt = ApprovedLoanAmount();
            Console.WriteLine("approved amount" + ApprovedLoanAmt);
            ApprovedLoanAmt = ApprovedLoanAmt.Replace(",", "");
            Console.WriteLine("approved amountNEW" + ApprovedLoanAmt);
            ApprovedLoanAmt = ApprovedLoanAmt.Replace("$", "");
            if (GetPlatform(_driver))
            {
                var actamt = ApprovedLoanAmt.Split('.');
                ApprovedLoanAmt = actamt[0];
                ApprovedLoanAmt = ApprovedLoanAmt.Replace(".", "");
            }
            Console.WriteLine("approved amountlatest" + ApprovedLoanAmt);
            int ActualAmount = Convert.ToInt32(ApprovedLoanAmt);
            return ActualAmount;
        }

        /// <summary>
        /// Waits for loan set up page to display.
        /// </summary>
        /// <returns></returns>
        public bool WaitForLoanSetUpPage()
        {
            return _act.waitForVisibilityOfElement(_loansetupdetailsLoc.LoanAutoApprovedLabel, 120);
        }

        /// <summary>
        /// Gets Approveds loan amount.
        /// </summary>
        /// <returns>string loan amount</returns>
        public string ApprovedLoanAmount()
        {
            _act.waitForVisibilityOfElement(_loansetupdetailsLoc.ApprovedloanAmount, 240);
            string ApprovedLoanAmount = _act.getText(_loansetupdetailsLoc.ApprovedloanAmount, "Approved loan amount");
            return ApprovedLoanAmount;
        }

        /// <summary>
        /// Verifies the funded amount.
        /// </summary>
        /// <param name="LoanAmount">The loan amount.</param>
        /// <returns></returns>
        public bool VerifyFundedAmount(int LoanAmount)
        {
            bool flag = false;
            int FundedAmount = VerifyFundedAmount();

            if (LoanAmount.Equals(FundedAmount))
            {
                Console.WriteLine("loan Requested Amount =funded amount=approved amount");
                flag = true;
            }
            else
            {
                Console.WriteLine("funded amount not equal to approved amount");
                flag = false;
            }

            return flag;
        }

        public bool VerifyApprovedGreaterThanFunded(int approved, int funded)
        {
            bool flag = false;
            int FundedAmount = funded;
            int Approved = approved;

            if (Approved > FundedAmount)
            {
                Console.WriteLine("approved amount>funded amount");
                flag = true;
            }
            else
            {
                Console.WriteLine("funded amount not lesser approved amount");
                flag = false;
            }

            return flag;
        }

        public void ClickDetailedRepaymentSchedule()
        {
            _act.waitForVisibilityOfElement(_loansetupdetailsLoc.DetailedrepaymentscheduleButton, 240);
            _act.click(_loansetupdetailsLoc.DetailedrepaymentscheduleButton, "DetailedrepaymentscheduleButton");
        }

        public int GetRepaymentCountSetupPage()
        {
            _act.waitForVisibilityOfElement(_loansetupdetailsLoc.RepaymentCountSetupPage, 60);
            string count = _act.getText(_loansetupdetailsLoc.RepaymentCountSetupPage, "");
            int repaymentcount = Convert.ToInt32(count);
            return repaymentcount;
        }

        public int GetRepaymentCountConfirmPage()
        { 
                // _act.waitForVisibilityOfElement(_loansetupdetailsLoc.RepaymentCountConfirmPage, 60);
                string count = _act.getText(_loansetupdetailsLoc.RepaymentCountConfirmPage, "");
                var count1 = count.Split(' ');
                string repcnt = count1[4];
                int repaymentcount = Convert.ToInt32(repcnt);
                 int repaymentfinalcount = 0;
            try
            {
                if (driver.FindElement(By.XPath("(//div[@id='contractPage1']/table)[2]//tr//td[contains(text(),'last repayment')]")).Displayed)
                   repaymentfinalcount=repaymentcount + 1;

            }
            catch {
              repaymentfinalcount= (repaymentcount);
            }
            return repaymentfinalcount;
        }

        /// <summary>
        /// Verifies the funded amount.
        /// </summary>
        /// <returns>integer funded amount</returns>
        public int VerifyFundedAmount()
        {
            string FundedLoanAmt = getFundedLoanAmt();
            FundedLoanAmt = FundedLoanAmt.Replace("$", "");
            FundedLoanAmt = FundedLoanAmt.Replace(",", "");
            int FundedAmount = Convert.ToInt32(FundedLoanAmt);
            return FundedAmount;
        }

        /// <summary>
        /// Verifies the repay amount.
        /// </summary>
        /// <returns>bool if exist true else false</returns>
        public bool VerifyRepayAmount()
        {
            bool flag = false;
            int index = 0;
            IWebElement baseTable = _driver.FindElement(_loansetupdetailsLoc.DetailedTable);
            List<IWebElement> tableRows = new List<IWebElement>();
            tableRows = baseTable.FindElements(By.TagName("tr")).ToList();
            for (int i = 0; i < tableRows.Count; i++)
            {
                index = i;

            }
            Console.WriteLine("no of rows=" + index);
            int lastrowvalue = index - 3;
            int secondlastrowvalue = lastrowvalue - 1;

            IWebElement lastrow = baseTable.FindElement(By.XPath("//*[@id='repayments']/tbody/tr[" + lastrowvalue + "]"));
            IWebElement lastcell = lastrow.FindElement(By.XPath("//*[@id='repayments']/tbody/tr[" + lastrowvalue + "]/td[3]"));
            IWebElement secondlastrow = baseTable.FindElement(By.XPath("//*[@id='repayments']/tbody/tr[" + secondlastrowvalue + "]"));
            IWebElement secondlastcell = secondlastrow.FindElement(By.XPath("//*[@id='repayments']/tbody/tr[" + secondlastrowvalue + "]/td[3]"));
            String lastvalue = lastcell.Text.ToString();
            String secondlastvalue = secondlastcell.Text.ToString();
            if (lastvalue.Equals(secondlastvalue))
            {
                Console.WriteLine("Value matched");
                flag = true;
            }
            else
            {
                Console.WriteLine("Value not matched");
                flag = false;
            }

            return flag;
        }

        public string GetLastRepaymentAmount()
        {
            int index = 0;
            IWebElement baseTable = _driver.FindElement(_loansetupdetailsLoc.DetailedTable);
            List<IWebElement> tableRows = new List<IWebElement>();
            tableRows = baseTable.FindElements(By.TagName("tr")).ToList();
            for (int i = 0; i < tableRows.Count; i++)
            {
                index = i;

            }
            Console.WriteLine("no of rows=" + index);
            int lastrowvalue = index - 3;
            int secondlastrowvalue = lastrowvalue - 1;

            IWebElement lastrow = baseTable.FindElement(By.XPath("//*[@id='repayments']/tbody/tr[" + lastrowvalue + "]"));
            IWebElement lastcell = lastrow.FindElement(By.XPath("//*[@id='repayments']/tbody/tr[" + lastrowvalue + "]/td[3]"));
            IWebElement secondlastrow = baseTable.FindElement(By.XPath("//*[@id='repayments']/tbody/tr[" + secondlastrowvalue + "]"));
            IWebElement secondlastcell = secondlastrow.FindElement(By.XPath("//*[@id='repayments']/tbody/tr[" + secondlastrowvalue + "]/td[3]"));
            String lastvalue = lastcell.Text.ToString();
            return lastvalue;
        }

        public string GetFirstDateSetupPage()
        {
            string date = _act.getText(_loansetupdetailsLoc.FirstDate, "");
            var date1 = date.Split(' ');
            string a = date1[1];
            var numAlpha = new Regex("(?<Alpha>[a-zA-Z]*)(?<Numeric>[0-9]*)");
            var match = numAlpha.Match(a);

            var alpha = match.Groups["Alpha"].Value;
            var num = match.Groups["Numeric"].Value;

            //  fdate =
            return num;
        }

        public string GetLastDateSetupPage()
        {
            string date = _act.getText(_loansetupdetailsLoc.LastDate, "");
            var date1 = date.Split(' ');
            string a = date1[1];
            var numAlpha = new Regex("(?<Alpha>[a-zA-Z]*)(?<Numeric>[0-9]*)");
            var match = numAlpha.Match(a);

            var alpha = match.Groups["Alpha"].Value;
            var num = match.Groups["Numeric"].Value;

            //  fdate =
            return num;
        }      
             
        public string FinalRepaymentConfirmPage()
        {
            _act.waitForVisibilityOfElement(_loansetupdetailsLoc.FinalRepaymentConfirmPage, 600);
            string text = _act.getText(_loansetupdetailsLoc.FinalRepaymentConfirmPage, "");
            var text1 = text.Split(' ');
            string lastrepay = text1[4];
            return lastrepay;
        }
        /// <summary>
        /// Gets the funded loan amt.
        /// </summary>
        /// <returns>string loan amount</returns>
        public string getFundedLoanAmt()
        {
            _act.waitForVisibilityOfElement(_loansetupdetailsLoc.FundedAmount, 120);
            string fundedLoanAmount = _act.getText(_loansetupdetailsLoc.FundedAmount, "Funded amount");
            return fundedLoanAmount;
        }

        /// <summary>
        /// Clicks the loan dashboard.
        /// </summary>
        public void clickLoanDashboard()
        {
            _act.waitForVisibilityOfElement(_loansetupdetailsLoc.LoanDashBoard, 60);
            _act.click(_loansetupdetailsLoc.LoanDashBoard, "loan dashboard");
        }

        //public void MoveSliderLowestAmount()
        //{
        //   // IWebElement Container = _driver.FindElement(_loansetupdetailsLoc.LoanAmountContainer);

        //    IWebElement Sliderstick = _driver.FindElement(_loansetupdetailsLoc.SliderLowestAmount);
        //    int sliderwidth = Sliderstick.Size.Width;
        //    IWebElement Sliderbutton = _driver.FindElement(_loansetupdetailsLoc.SliderButtonLowestAmount);

        //    Actions sliderActions = new Actions(_driver);

        //    sliderActions.ClickAndHold(Sliderbutton);
        //    int lowest = 0 / sliderwidth;
        //    sliderActions.MoveByOffset(40,0).Build().Perform();
        //    //   IWebElement eleslider= _driver.FindElement(_loansetupdetailsLoc.SliderButtonLowestAmount);
        //    //sliderActions.DragAndDropToOffset(Sliderbutton, lowest, 0).Build().Perform();
        //    //new Actions(_driver)
        //    //           .DragAndDropToOffset(sliderHandle, dx, 0)
        //    //           .Build()
        //    //.Perform();
        //    //   IWebElement SliderStick = _driver.FindElement(_loansetupdetailsLoc.SliderLowestAmount);

        //    //var sliderHandle = _driver.FindElement(_loansetupdetailsLoc.SliderButtonLowestAmount);
        //    //var sliderTrack = _driver.FindElement(_loansetupdetailsLoc.SliderLowestAmount);
        //    //var width = int.Parse(sliderTrack.GetCssValue("width").Replace("px", ""));
        //    //var dx = 0;

        //    //new Actions(_driver)
        //    //            .DragAndDropToOffset(sliderHandle, dx, 0)
        //    //            .Build()
        //    //            .Perform();


        // //   IWebElement slider = _driver.FindElement(_loansetupdetailsLoc.SliderButtonLowestAmount);
        // //   //    int width = slider.get().getWidth();
        // //  // int actual = 1600 - request - 2200;
        // ////   int move = actual / 50;
        // //   Actions SliderActions = new Actions(_driver);
        // //   SliderActions.ClickAndHold(slider);
        // //   SliderActions.MoveByOffset(0, 0).Build().Perform();
        //}

        /// <summary>
        /// Moves the slider to lowest amount.
        /// </summary>
        public void MoveSliderLowestAmount()
        {
            _act.waitForVisibilityOfElement(_loansetupdetailsLoc.SliderButtonLowestAmount, 200);
            IWebElement sliderEle = _driver.FindElement(_loansetupdetailsLoc.SliderButtonLowestAmount);
            _act.click(_loansetupdetailsLoc.SliderButtonLowestAmount, "slider");

            string value1 = _act.getText(_loansetupdetailsLoc.MaxRepaymentAmount, "gettext");
            var actualvaluemax = value1.Replace("$", "");
            if (actualvaluemax.Contains(","))
            {
                actualvaluemax = actualvaluemax.Replace(",", "");
            }
            int amountmax = Convert.ToInt32(actualvaluemax);

            string value2 = _act.getText(_loansetupdetailsLoc.MinRepaymentAmount, "gettext");
            var actualvaluemin = value2.Replace("$", "");
            if (actualvaluemin.Contains(","))
            {
                actualvaluemin = actualvaluemin.Replace(",", "");
            }
            int amountmin = Convert.ToInt32(actualvaluemin);

            int diffamt = amountmax - amountmin;

            int weeklyAmount = diffamt / 5;

            int leftclicks = weeklyAmount + 5;
            for (int i = 1; i <= leftclicks; i++)

            {
                sliderEle.SendKeys(Keys.ArrowLeft);
            }
            Thread.Sleep(4000);
        }
        public void MoveLoanValueSlider()
        {
            _act.waitForVisibilityOfElement(_loansetupdetailsLoc.loanSlider, 200);
            IWebElement sliderEle = _driver.FindElement(_loansetupdetailsLoc.loanSlider);
            _act.click(_loansetupdetailsLoc.loanSlider, "slider");


            for (int i = 1; i <= 8; i++)

            {
                sliderEle.SendKeys(Keys.ArrowLeft);
            }
            Thread.Sleep(4000);
        }

        /// <summary>
        /// Moves the slider to middle amount.
        /// </summary>
        public void MoveSliderMiddleAmount(int loanamt)
        {
            int leftclicks = 0;
            int weeklyAmount = 0;
            _act.waitForVisibilityOfElement(_loansetupdetailsLoc.SliderButtonLowestAmount, 150);
            IWebElement sliderEle = _driver.FindElement(_loansetupdetailsLoc.SliderButtonLowestAmount);
            _act.click(_loansetupdetailsLoc.SliderButtonLowestAmount, "slider");

            var value = _act.getText(_loansetupdetailsLoc.MaxRepaymentAmount, "gettext");
            var actualvalue = value.Replace("$", "");
            if (actualvalue.Contains(","))
            {
                actualvalue = actualvalue.Replace(",", "");
            }


            var lowestvalue = _act.getText(_loansetupdetailsLoc.MinRepaymentAmount, "LeastAmount");
            var lowest = lowestvalue.Replace("$", "");
            if (lowest.Contains(","))
            {
                lowest = lowest.Replace(",", "");
            }


            int amount = Convert.ToInt32(actualvalue) - Convert.ToInt32(lowest);


            weeklyAmount = amount / 10;

            float middleamount = weeklyAmount / 2;
            if ((middleamount % 2) != 0)
            {
                leftclicks = (int)middleamount + 1;
                if (Convert.ToInt32(actualvalue) < 250)

                {
                    leftclicks = leftclicks - 2;
                }
               
            }
            else
            {
                leftclicks = (int)middleamount;
                if (Convert.ToInt32(actualvalue) < 250)

                {
                    leftclicks = leftclicks - 2;
                }

                //else
                //{
                //    leftclicks = leftclicks + 5;
                //}
            }
            if(Convert.ToInt32(actualvalue)>250)
            {
                leftclicks = 25;
            }
            for (int i = 1; i <= leftclicks; i++)

            {
                sliderEle.SendKeys(Keys.ArrowLeft);
                 Thread.Sleep(1000);

            }
            Thread.Sleep(4000);
            }

        public void MoveSliderMiddleAmountRL(int loanamt)
        {
            
            _act.waitForVisibilityOfElement(_loansetupdetailsLoc.SliderButtonLowestAmount, 150);
            IWebElement sliderEle = _driver.FindElement(_loansetupdetailsLoc.SliderButtonLowestAmount);
            _act.click(_loansetupdetailsLoc.SliderButtonLowestAmount, "slider");

            if(loanamt>1600)
            {
                for (int i = 1; i <= 25; i++)

                {
                    sliderEle.SendKeys(Keys.ArrowLeft);
                     Thread.Sleep(1000);

                }
                Thread.Sleep(3000);
            }

            else
            {
                for (int i = 1; i <= 3; i++)

            {
                sliderEle.SendKeys(Keys.ArrowLeft);
                     Thread.Sleep(2000);

                }
            }
        }


        /// <summary>
        /// Get Minimum Repayment Amount 
        /// </summary>
        /// <returns>string</returns>
        public string GetMinRepaymentAmt()
        {
            _act.waitForVisibilityOfElement(_loansetupdetailsLoc.RepaymentDateSlider, 250);
            return _act.getText(_loansetupdetailsLoc.MinRepaymentAmount, "LeastAmount");
            }

        /// <summary>
        /// Get Maxium Repayment Amount 
        /// </summary>
        /// <returns>string</returns>
        public string GetMaxRepaymentAmt()
        {
            return _act.getText(_loansetupdetailsLoc.MaxRepaymentAmount, "gettext");
        }

        /// <summary>
        /// Move Repayments slider date to lowest.
        /// </summary>
        public void RepaymentDateLowest()
        {
            _act.waitForVisibilityOfElement(_loansetupdetailsLoc.RepaymentDateSlider, 150);
            IWebElement sliderDate = _driver.FindElement(_loansetupdetailsLoc.RepaymentDateSlider);
            _act.click(_loansetupdetailsLoc.RepaymentDateSlider, "sliderdate");

            var value = _act.getText(_loansetupdetailsLoc.RepaymentDateValue, "RepaymentDateValue");
            var actualvalue = value.Split(' ');
            var date = actualvalue[1];
            var reqdate = date.Replace(",", "");
            int DateValue = Convert.ToInt32(reqdate);
            for (int i = 1; i <= DateValue; i++)
            {
                sliderDate.SendKeys(Keys.ArrowLeft);
            }
            Thread.Sleep(4000);
        }

        /// <summary>
        /// Move Repayments slider date to middle.
        /// </summary>
        public void RepaymentDateMiddle()
        {
            _act.waitForVisibilityOfElement(_loansetupdetailsLoc.RepaymentDateSlider, 150);
            IWebElement sliderDate = _driver.FindElement(_loansetupdetailsLoc.RepaymentDateSlider);
            _act.click(_loansetupdetailsLoc.RepaymentDateSlider, "sliderdate");

            //var value = _act.getText(_loansetupdetailsLoc.RepaymentDateValue, "RepaymentDateValue");
            //var actualvalue = value.Split(' ');
            //var date = actualvalue[1];
            //var reqdate = date.Replace(",", "");
            //int DateValue = Convert.ToInt32(reqdate);
            for (int i = 1; i < 8; i++)
            {
                sliderDate.SendKeys(Keys.ArrowRight);
                Thread.Sleep(1000);

            }
            Thread.Sleep(4000);



        }

        /// <summary>
        /// Move Repayments slider date to highest.
        /// </summary>
        public void RepaymentDateHighest()
        {
            _act.waitForVisibilityOfElement(_loansetupdetailsLoc.RepaymentDateSlider, 150);
            IWebElement sliderDate = _driver.FindElement(_loansetupdetailsLoc.RepaymentDateSlider);
            _act.click(_loansetupdetailsLoc.RepaymentDateSlider, "sliderdate");

            //var value = _act.getText(_loansetupdetailsLoc.RepaymentDateValue, "RepaymentDateValue");
            //var actualvalue = value.Split(' ');
            //var date = actualvalue[1];
            //var reqdate = date.Replace(",", "");
            //int DateValue = Convert.ToInt32(reqdate);
            for (int i = 1; i <= 20; i++)
            {
                sliderDate.SendKeys(Keys.ArrowRight);
            }
            Thread.Sleep(4000);
        }

        public bool loanSetupFunction(int loanamount)
        {

            bool blnval1 = false;
            bool blnval2 = false;
            // Verify Funded Amount
            if (VerifyApprovedLoan(loanamount))
                blnval1 = true;

            ClickSubmitBtn();


            //  Scrolling the Loan Contract
            Loancontract();

            // Confirming accepting contract
            ConfirmAcceptingContract();

            // click on I Agree button
            ClickOnAgreeBtn();

            // click on No thanks Button
            ClickNothanksBtn();


            // Verify Funded Amount
            if (loanamount == VerifyFundedAmount())
                blnval2 = true;

            if (GetPlatform(_driver))
            {
                // Click on To Loan Dashboard Button
                ClickMobileLoanDashboardBtn();

                // click on More Button from Bottom Menu
                ClickMoreBtn();

                //Logout
                Logout();

            }
            else
            {
                // Click on Loan Dashboard Button
                ClickLoanDashboard();

                //Logout
                Logout();
            }
            if (blnval1 && blnval2)
                return true;
            else
                return false;
        }

        public bool loanSetupFunction_RL(int loanamount)
        {



            //  Scrolling the Loan Contract
            Loancontract();

            // Confirming accepting contract
            ConfirmAcceptingContract();

            // click on I Agree button
            ClickOnAgreeBtn();

            // click on No thanks Button
            ClickNothanksBtn();


            if (GetPlatform(_driver))
            {
                // Click on To Loan Dashboard Button
                ClickMobileLoanDashboardBtn();

                // click on More Button from Bottom Menu
                ClickMoreBtn();

                //Logout
                Logout();
            }
            else
            {
                // Click on Loan Dashboard Button
                ClickLoanDashboard();

                //Logout
                Logout();
            }
            return true;
        }

        public string[] FetchAcctandBSB()
        {

            _act.waitForVisibilityOfElement(_loansetupdetailsLoc.AcctBSBLastPage, 30);
            string ApprovedLoanAmt = _act.getText(_loansetupdetailsLoc.AcctBSBLastPage, "ACCTNO AND BSB");
            var data = ApprovedLoanAmt.Split(':');
            var splitteddata = data[1];
            var splitteddata1 = splitteddata.Split(' ');
            string[] numbers = new string[2];
            numbers[0] = splitteddata1[1];
           // int BSB = Convert.ToInt32(splitteddata1[1]);
            var splitteddata3 = data[2];
            if (splitteddata3.Contains(' '))
            {
                splitteddata3 = splitteddata3.Replace(" ", "");
            }
            numbers[1] = splitteddata3;
            //int AcctNo = Convert.ToInt32(splitteddata3);
            return numbers;


        }
        public string getEmail()
        {
            _act.waitForVisibilityOfElement(_loansetupdetailsLoc.emailSetupPage, 300);
            string email = _act.getText(_loansetupdetailsLoc.emailSetupPage, "email");
            return email;
        }

        public int GetLowestRepAmt()
        {
            _act.waitForVisibilityOfElement(_loansetupdetailsLoc.LowestRepAmt, 300);
            string amt = _act.getText(_loansetupdetailsLoc.LowestRepAmt, "email");

            string amt1 = amt.Replace("$", "");
            if (amt1.Contains(","))
            {
                amt1 = amt1.Replace(",", "");
            }
            int amt2 = Convert.ToInt32(amt1);
            return amt2;
        }

        public int GetHighestRepAmt()
        {
            _act.waitForVisibilityOfElement(_loansetupdetailsLoc.HighestRepAmt, 300);
            string amt = _act.getText(_loansetupdetailsLoc.HighestRepAmt, "email");
            string amt1 = amt.Replace("$", "");
            if(amt1.Contains(","))
            {
                amt1 = amt1.Replace(",", "");
            }
            int amt2 = Convert.ToInt32(amt1);
            return amt2;
        }

        public int getRepAmtInTable(int highamt)
        {
            Thread.Sleep(4000);
            _act.waitForVisibilityOfElement(_loansetupdetailsLoc.RepAmtInTable, 300);
            string amt = _act.getText(_loansetupdetailsLoc.RepAmtInTable, "email");
            var amt1 = amt.Split('.');
            string amt2 = amt1[0];
              string amt3=  amt2.Replace("$", "");
            if (amt3.Contains(","))
            {
                amt3 = amt3.Replace(",", "");
            }
            int amt4 = Convert.ToInt32(amt3);
                if(amt4<highamt)
            {
                amt4 = amt4 + 1;
            }
            return amt4;
        }

        public int getRepAmtInTableMiddle()
        {
            _act.waitForVisibilityOfElement(_loansetupdetailsLoc.RepAmtInTable, 300);
            string amt = _act.getText(_loansetupdetailsLoc.RepAmtInTable, "email");
            var amt1 = amt.Split('.');
            string amt2 = amt1[0];
            string amt3 = amt2.Replace("$", "");
            int amt4 = Convert.ToInt32(amt3);
            return amt4;
        }

        public string GetConfirmedTxtSetUp()
        {
            _act.waitForVisibilityOfElement(_loansetupdetailsLoc.GetConfirmedTxt, 200);
            string strval = _act.getText(_loansetupdetailsLoc.GetConfirmedTxt, "Text");
            Console.WriteLine(strval);
            return strval;

        }



    }
}