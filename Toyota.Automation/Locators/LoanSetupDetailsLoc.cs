﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toyota.Automation.Repository
{
    public interface ILoanSetupDetails
    {
        #region Loan Progress Menu Items

        By LoanApply { get; }

        By Verify { get; }

        By StepLoan { get; }

        By Confirm { get; }

        By GetMoney { get; }

        #endregion

        #region Loan Progress Bottom Menu

        By Dashboard { get; }

        By Card { get; }

        By Timeline { get; }

        By MoreButton { get; }

        #endregion

        #region Loan setup locators

        By RefreshButton { get; }

        By GetConfirmedTxt { get; }

        By SetupButton { get; }

        By VerifyButton { get; }

        By ApprovedloanAmount { get; }

        By firstrepaymentdate { get; }

        By Detailedpaymentamount { get; }

        By DetailedrepaymentscheduleButton { get; }

        By ButtonSubmit { get; }

        By FinalStepLabel { get; }

        By JustCheckingLabel { get; }

        By Loancontract { get; }

        By confirmLoancotract { get; }

        By confirmpurpose { get; }

        By confirmrepay { get; }

        By FundedAmount { get; }

        By EmailinDashboard { get; }

        By GUIDDashboard { get; }

        By LoanContractLabel { get; }

        By Scrollbottom { get; }

        // submit contract button
        By submitcontractButton { get; }

        // existing User
        By RequestMoney { get; }

        By ExistingUserStartAppButon { get; }

        //sms Input 
        By SMSInput { get; }

        By SubmitPin { get; }

        // acknowledge accept
        By acknowledgebtn { get; }

        By SubmitButton { get; }

        By LoanAutoApprovedLabel { get; }

        By NoThanksButton { get; }

        By NimbleCardRbtn { get; }

        By NimblecardSubmitBtn { get; }

        By LoanDashBoard { get; }

        By reasonspendless { get; }

        By reasonsubmitBtn { get; }

        By LoanDashboardManual { get; }

        By Logout { get; }

        By ManualApprove { get; }

        By FinalApprove { get; }

        By DetailedTable { get; }

        By More { get; }

        By RefreshBtn { get; }

        By confirmrepay1 { get; }

        By SliderLowestAmount { get; }

        By SliderButtonLowestAmount { get; }

        By LeastAmount { get; }

        By AmountDisplay { get; }

        By RepaymentDateSlider { get; }

        By RepaymentDateValue { get; }

        By MaxRepaymentAmount { get; }

        By MinRepaymentAmount { get; }

        By AcctBSBLastPage { get; }

        By FirstDate { get; }

        By LastDate { get; }

        By FirstDateConfirmPage { get; }

        By LastDateConfirmPage { get; }

        By AmountOfCredit { get; }

        By DisclosureDate { get; }

        By loanSlider { get; }

        By emailSetupPage { get; }

        By RepaymentConfirmPage { get; }

        By RepaymentCount { get; }

        By RepaymentSetupPage { get; }

        By leavePopup { get; }

        By leavePopupDiv { get; }

        By FortNight { get; }

        By Monthly { get; }

        By FinalRepaymentConfirmPage { get; }

        By ActivateCard { get; }

        By SecurityQuestion { get; }

        By SecurityAnswer { get; }

        By LastFourDigits { get; }

        By Productdisclosurebutton { get; }

        By Financialservicesbutton { get; }

        By ActivateCardButton { get; }

        By ActivateDoneButton { get; }

        By Bpay { get; }

        By BillerCode { get; }

        By VerifyBillerCode { get; }

        By BpayReference { get; }

        By BpayDescription { get; }

        By BpayAmount { get; }

        By BpaySubmit { get; }

        By BpayActivateButton { get; }

        By BpayTransactionHistoryButton { get; }

        By TransactionAmount { get; }

        By RepaymentCountConfirmPage { get; }

        By RepaymentCountSetupPage { get; }

        By FinalRepaymentDateSetupPage { get; }

        By LowestRepAmt { get; }

        By HighestRepAmt { get; }

        By RepAmtInTable { get; }

        By Unconfirmedcontractmsg { get; }

        By Unconfirmedpurposemsg { get; }

        By Unconfirmedrepaymsg { get; }

        


        #endregion
    }

    public class LoanSetupDetailsMobileNLLoc : ILoanSetupDetails
    {
        #region Loan Progress Menu Items

        public By LoanApply => By.XPath("//div[@class='pli-icon sprite-common i-40-checkpoints']/following-sibling::div");

        public By Verify => By.XPath("//div[@class='pli-icon sprite-common i-40-pad-tick']/following-sibling::div");

        public By StepLoan => By.XPath("//div[@class='pli-icon sprite-common i-40-cog-grey']/following-sibling::div[contains(text(),'Set up loan')]");

        public By Confirm => By.XPath("//div[@class='pli-icon sprite-common i-40-pencil']/following-sibling::div");

        public By GetMoney => By.XPath("//div[@class='pli-icon sprite-common i-40-money']/following-sibling::div");

        #endregion

        #region Loan Progress Bottom Menu

        public By Dashboard => By.XPath("//p[contains(text(),'Dashboard')]");

        public By Card => By.XPath("//p[contains(text(),'Card')]");

        public By Timeline => By.XPath("//p[contains(text(),'Timeline')]");

        public By MoreButton => By.XPath("//p[contains(text(),'More')]");

        #endregion

        #region Loan setup locators

        public By RefreshButton => By.XPath(".//*[@id='linkMenuDesktopHomeRefresh']");

        public By SetupButton => By.XPath(".//span[@id='afterLoanAmount']/a[@class='pli-button button xsml gold']");

        public By VerifyButton => By.XPath(".//*[@id='LoanProgress']/div/div[2]/div[3]/div[2]/a");

        public By ApprovedloanAmount => By.XPath(".//span[@class='font-50 green block m-t-20 m-b-30']");

        public By firstrepaymentdate => By.XPath(".//*[@id='howLongSlider_wrap']/div[@class='display-value white text-center bold600']/span");

        public By Detailedpaymentamount => By.XPath(".//*[@id='repayments']//td[@class='descCol'][contains(text(),'1')]/following-sibling::td[@class='dateCol']");

        public By DetailedrepaymentscheduleButton => By.XPath(".//*[@id='detailsScheduleHeader']");

        public By ButtonSubmit => By.XPath(".//*[@id='submit']");

        public By FinalStepLabel => By.XPath(".//*[@id='contract-sign']/h1");

        public By Loancontract => By.XPath("//*[@id='contractScrollWrap_Mobile']");

        public By confirmLoancotract => By.XPath(".//input[@id='termsandconditions2_m']//following-sibling::div[@data-attached='termsandconditions2_m']");

        public By confirmpurpose => By.XPath(".//input[@id='confirmpurpose_m']//following-sibling::div[@data-attached='confirmpurpose_m']");

        public By confirmrepay => By.XPath(".//input[@id='confirmrepay_m']//following-sibling::div[@data-attached='confirmrepay_m']");

        public By confirmrepay1 => By.XPath(".//*[@id='confirmrepay_errorbox']/div[3]");

        public By EmailinDashboard => By.XPath(".//*[@id='debugLeftNav']/li[6]");

        public By GUIDDashboard => By.XPath(".//*[@id='debugLeftNav']/li[7]");

        public By LoanContractLabel => By.XPath(".//*[@id='contractScrollWrap_Mobile']/h3");

        public By Scrollbottom => By.XPath(".//div[@id='scrollBottom']");

        public By FundedAmount => By.XPath(".//*[@class='green font-70']");

        // submit contract button
        public By submitcontractButton => By.XPath(".//button[@id='confirm']");

        // existing User
        public By RequestMoney => By.XPath(".//*[@id='dashTop']/div/a/span[contains(text(),'Request Money')]");

        public By ExistingUserStartAppButon => By.XPath(".//*[@id='btnContinueNCCP_Returner']");

        //sms Input 
        public By SMSInput => By.XPath("//*[@id='smsinput']");

        public By SubmitPin => By.XPath("//*[@id='btnNext']");

        // acknowledge accept
        public By acknowledgebtn => By.XPath(".//*[@id='optInNVPC']/div/label");

        public By SubmitButton => By.XPath(".//*[@id='btnSubmit']");

        // Auto approved label
        public By LoanAutoApprovedLabel => By.XPath(".//*[@id='returnclient']/h1[contains(text(),'Congratulations!')]");

        //No Thanks
        public By NoThanksButton => By.XPath(".//*[@id='btnNoThanks']");

        //nimble card yes
        public By NimbleCardRbtn => By.XPath(".//input[@id='wantsavisacard']/following-sibling::div");

        public By NimblecardSubmitBtn => By.XPath(".//button[@id='btnSubmit']");

        //loan dashboard
        public By LoanDashBoard => By.XPath(".//*[@id='mobile-appendixmaincontractsigned']/a");

        public By JustCheckingLabel => By.XPath(".//div[@class='width-90 block-center m-t-20 m-b-20 text-center']/h2");

        public By reasonspendless => By.XPath(".//label[@for='reason_YesSpendLess']");

        public By reasonsubmitBtn => By.XPath(".//button[@id='submit']");

        public By Logout => By.XPath(".//*[@id='mobile-more']//p[contains(text(),'Log out')]");

        public By LoanDashboardManual => By.XPath(".//a[@href='/Mobile/Home']");

        public By ManualApprove => By.XPath(".//*[@id='mobile-more']//p[contains(text(),'Approve')]");

        public By FinalApprove => By.XPath(".//a[@href='/Account/DoFinalApproval']");

        public By DetailedTable => By.Id("repayments");

        public By More => By.XPath(".//div[@id='more']");

        public By RefreshBtn => By.XPath("//a[@href='/Account/MobileHomeRefresh']//p[contains(text(),'Refresh')]");

        public By SliderLowestAmount => By.XPath("//div[@id='amtRequestedSlider']");

        // public By SliderButtonLowestAmount => By.XPath("(//*[@class='ui-slider-handle ui-state-default ui-corner-all'])[last()-2]");

        public By SliderButtonLowestAmount => By.XPath(".//div[@id='amtRequestedSlider']/span");

        public By loanSlider => By.XPath("(//*[@class='ui-slider-handle ui-state-default ui-corner-all'])[last()-2]");

        public By AmountDisplay => By.XPath("(//div[@class='display-value white text-center bold600']/span)[last()-1]");

        public By LeastAmount => By.XPath("(//*[@class='minAmount minmax f-left font-14 charcoal'])[last()-2]");

        public By RepaymentDateSlider => By.XPath("(//*[@class='ui-slider-handle ui-state-default ui-corner-all'])[last()-1]");

        public By RepaymentDateValue => By.XPath("(//div[@class='display-value white text-center bold600'])[last()-0]");

        public By MaxRepaymentAmount => By.XPath("(//div[@class='maxAmount minmax f-right font-14 charcoal'])[last()]");

        public By MinRepaymentAmount => By.XPath("(//div[@class='minAmount minmax f-left font-14 charcoal'])[last()]");

        public By AcctBSBLastPage => By.XPath("//h3[@class='m-b-20']");

        public By FirstDate => By.XPath("(//td[@class='dateCol'])[last()-8]");

        public By LastDate => By.XPath("(//td[@class='dateCol'])[last()]");

        public By RepaymentConfirmPage => By.XPath("(//td[@colspan='2'])[last()-9]");

        public By RepaymentSetupPage => By.XPath("//td[@id='totalRepayment']");

        public By RepaymentCount => By.XPath("//td[@id='repaymentCount']");

        public By FirstDateConfirmPage => By.XPath("(//td[@colspan='2'])[last()-11]");

        public By LastDateConfirmPage => By.XPath("(//td[@colspan='2'])[last()-10]");

        public By AmountOfCredit => By.XPath("(//td[@colspan='2'])[last()-13]");

        public By DisclosureDate => By.XPath("//td[contains(text(),'The information in this loan contract is prepared as at')]");

        public By emailSetupPage => By.XPath("(//li[@class='disabled'])[last()-1]");

        public By leavePopup => By.XPath("//button[@class='ui-button ui-widget ui-state-default ui-corner-all ui-button-icon-only ui-dialog-titlebar-close exitQuestionClose']");

        public By leavePopupDiv => By.XPath("//div[@class='ui-dialog ui-widget ui-widget-content ui-corner-all ui-front scale100']");

        public By FortNight => By.XPath("//label[@for='payFrequencyFort']");

        public By Monthly => By.XPath("//label[@for='payFrequencyMonth']");

        public By FinalRepaymentConfirmPage => By.XPath("(//div[@id='contractPage1']/table)[2]//tr//td[contains(text(),'A final repayment of $')]");

        public By ActivateCard => By.XPath("//a[text()='Activate Card']");

        public By SecurityQuestion => By.XPath("//select[@id='securityquestions']");

        public By SecurityAnswer => By.XPath("//input[@id='securityanswer']");

        public By LastFourDigits => By.XPath("//input[@id='cardconfirm']");

        public By Productdisclosurebutton => By.XPath("(//div[@class='checkbox white-bg large'])[last()-1]");

        public By Financialservicesbutton => By.XPath("(//div[@class='checkbox white-bg large'])[last()]");

        public By ActivateCardButton => By.XPath("//a[@id='ActivateCard']");

        public By ActivateDoneButton => By.XPath("//a[@id='ActivateDone']");

        public By Bpay => By.XPath("//span[@class='bpay']");

        public By BillerCode => By.XPath("//input[@id='billercode']");

        public By VerifyBillerCode => By.XPath("//a[@id='btnVerifyBiller']");

        public By BpayReference => By.XPath("//input[@id='reference']");

        public By BpayDescription => By.XPath("//input[@id='description']");

        public By BpayAmount => By.XPath("//input[@id='amount']");

        public By BpaySubmit => By.XPath("//a[@id='btnBPay']");

        public By BpayActivateButton => By.XPath("//a[@id='btnConfirm']");

        public By BpayTransactionHistoryButton => By.XPath("//a[@id='btnMembersArea']");

        public By TransactionAmount => By.XPath("//td[@class='negative']");

        public By RepaymentCountConfirmPage => By.XPath("//*[@id='contractPage1']/table[2]/tbody/tr[3]/td[2]");


        public By RepaymentCountSetupPage => By.XPath("//td[@id='repaymentCount']");

        public By FinalRepaymentDateSetupPage => By.XPath("//span[@id='finalRepayment']");

        public By LowestRepAmt => By.XPath("(//div[@class='minAmount minmax f-left font-14 charcoal'])[last()]");

        public By HighestRepAmt => By.XPath("(//div [@class='maxAmount minmax f-right font-14 charcoal'])[last()]");

        public By RepAmtInTable => By.XPath("//td[@id='repaymentAmount']");


        public By Unconfirmedcontractmsg => By.XPath(".//tr[@id='termsandconditions2_error']//p");

        public By Unconfirmedpurposemsg => By.XPath(".//tr[@id='confirmpurpose_error']//p");

        public By Unconfirmedrepaymsg => By.XPath(".//tr[@id='confirmrepay_error']//p");


        public By GetConfirmedTxt => By.XPath("//*[@id='MemberDashboard']/div[1]/div/p");

        #endregion

    }

    public class LoanSetupDetailsDesktopNLLoc : ILoanSetupDetails
    {
        #region Loan Progress Menu Items

        public By LoanApply => By.XPath("//div[@class='pli-icon sprite-common i-40-checkpoints']/following-sibling::div");

        public By Verify => By.XPath("//div[@class='pli-icon sprite-common i-40-pad-tick']/following-sibling::div");

        public By StepLoan => By.XPath("//div[@class='pli-icon sprite-common i-40-cog-grey']/following-sibling::div[contains(text(),'Set up loan')]");

        public By Confirm => By.XPath("//div[@class='pli-icon sprite-common i-40-pencil']/following-sibling::div");

        public By GetMoney => By.XPath("//div[@class='pli-icon sprite-common i-40-money']/following-sibling::div");

        #endregion

        #region Loan Progress Bottom Menu

        public By Dashboard => By.XPath("//p[contains(text(),'Dashboard')]");

        public By Card => By.XPath("//p[contains(text(),'Card')]");

        public By Timeline => By.XPath("//p[contains(text(),'Timeline')]");

        public By MoreButton => By.XPath("//p[contains(text(),'More')]");

        #endregion

        #region Loan setup locators

        public By RefreshButton => By.XPath(".//*[@id='linkMenuDesktopHomeRefresh']");

        public By SetupButton => By.XPath(".//span[@id='afterLoanAmount']/a[@class='pli-button button xsml gold']");

        public By VerifyButton => By.XPath(".//*[@id='LoanProgress']/div/div[2]/div[3]/div[2]/a");

        public By ApprovedloanAmount => By.XPath(".//*[@id='ReturnerCalc']/h1/span");

        public By firstrepaymentdate => By.XPath(".//*[@id='howLongSlider_wrap']/div[@class='display-value white text-center bold600']/span");

        public By Detailedpaymentamount => By.XPath(".//*[@id='repayments']//td[@class='descCol'][contains(text(),'1')]/following-sibling::td[@class='dateCol']");

        public By DetailedrepaymentscheduleButton => By.XPath(".//*[@class='ui-accordion-header ui-state-default ui-corner-all ui-accordion-icons']");

        public By ButtonSubmit => By.XPath(".//*[@id='SubmitButton']");

        public By FinalStepLabel => By.XPath(".//*[@id='contract-sign']/h1");

        public By Loancontract => By.XPath(".//*[@id='contractScroll']");

        public By confirmLoancotract => By.XPath("//*[contains(@data-attached,'termsandconditions2')]");

        // public By confirmpurpose => By.XPath(".//*[@id='confirmpurpose_errorbox']/div[3]");//label");//*[contains(@data-attached,'confirmpurpose')]

        public By confirmpurpose => By.XPath("//*[contains(@data-attached,'confirmpurpose')]");

        public By confirmrepay1 => By.XPath(".//*[@id='confirmrepay_errorbox']/div[3]");//label");////*[contains(@data-attached,'confirmrepay')]

        public By confirmrepay => By.XPath("//*[contains(@data-attached,'confirmrepay')]");

        public By EmailinDashboard => By.XPath(".//*[@id='debugLeftNav']/li[6]");

        public By GUIDDashboard => By.XPath(".//*[@id='debugLeftNav']/li[7]");

        public By LoanContractLabel => By.XPath(".//*[@id='contractScrollWrap']/h3");

        public By Scrollbottom => By.XPath(".//div[@id='scrollBottom']");

        public By FundedAmount => By.XPath(".//*[@id='contentholder']/h2[2]");

        // submit contract button
        public By submitcontractButton => By.XPath(".//button[@id='submitContract']");

        // existing User
        public By RequestMoney => By.XPath(".//*[@id='dashTop']/div/a/span[contains(text(),'Request Money')]");

        public By ExistingUserStartAppButon => By.XPath(".//*[@id='btnContinueNCCP_Returner']");

        //sms Input 
        public By SMSInput => By.XPath(".//input[@id='smsInput']");

        public By SubmitPin => By.XPath(".//button[@id='submitpin']");

        // acknowledge accept
        public By acknowledgebtn => By.XPath(".//*[@id='optInNVPC']/div/label");

        public By SubmitButton => By.XPath(".//*[@id='btnSubmit']");

        // Auto approved label
        public By LoanAutoApprovedLabel => By.XPath(".//*[@id='ReturnerCalc']/h1[contains(text(),'Congratulations!')]");

        //No thanks
        public By NoThanksButton => By.XPath(".//*[@id='btnNoThanks']");

        //nimble card yes
        public By NimbleCardRbtn => By.XPath(".//input[@id='wantsavisacard']/following-sibling::div");

        public By NimblecardSubmitBtn => By.XPath(".//button[@id='btnSubmit']");

        public By LoanDashBoard => By.XPath("//span[text()='Loan Dashboard']");

        public By JustCheckingLabel => By.XPath(".//div[@id='maincontent']//h2[contains(text(),'Just checking')]");

        public By reasonspendless => By.XPath(".//label[@for='reason_YesSpendLess']");

        public By reasonsubmitBtn => By.XPath(".//a[@id='submit']");

        public By ManualApprove => By.XPath(".//*[@id='mobile-more']//p[contains(text(),'Approve')]");

        public By Logout => By.XPath("//a[@href='/Account/Logout']");

        public By DetailedTable => By.Id("repayments");

        public By More => By.XPath(".//div[@id='more']");

        public By LoanDashboardManual => By.XPath(".//a[@href='/Account/MemberHome']/span");

        public By RefreshBtn => By.XPath("//a[@href='/Account/DesktopHomeRefresh']//p[contains(text(),'Refresh')]");

        public By SliderLowestAmount => By.XPath("//div[@id='amtRequestedSlider']");

        public By SliderButtonLowestAmount => By.XPath("(//*[@class='ui-slider-handle ui-state-default ui-corner-all'])[last()]");

        public By loanSlider => By.XPath("(//*[@class='ui-slider-handle ui-state-default ui-corner-all'])[last()-2]");
        public By FinalApprove => By.XPath(".//a[@href='/Account/DoFinalApproval']");


        public By AmountDisplay => By.XPath("(//div[@class='display-value white text-center bold600']/span)[last()-1]");
        public By LeastAmount => By.XPath("(//*[@class='minAmount minmax f-left font-14 charcoal'])[last()-2]");
        public By RepaymentDateSlider => By.XPath("(//*[@class='ui-slider-handle ui-state-default ui-corner-all'])[last()-1]");
        public By RepaymentDateValue => By.XPath("(//div[@class='display-value white text-center bold600'])[last()-0]");
        public By MaxRepaymentAmount => By.XPath("(//div[@class='maxAmount minmax f-right font-14 charcoal'])[last()]");

        public By MinRepaymentAmount => By.XPath("(//div[@class='minAmount minmax f-left font-14 charcoal'])[last()]");

        public By AcctBSBLastPage => By.XPath("//h3[@class='m-b-20']");

        public By FirstDate => By.XPath("(//td[@class='dateCol'])[last()-9]");

        public By LastDate => By.XPath("(//td[@class='dateCol'])[last()]");

        public By RepaymentConfirmPage => By.XPath("(//td[@colspan='2'])[last()-9]");

        public By RepaymentSetupPage => By.XPath("//td[@id='totalRepayment']");

        public By RepaymentCount => By.XPath("//td[@id='repaymentCount']");

        public By FirstDateConfirmPage => By.XPath("(//td[@colspan='2'])[last()-11]");

        public By LastDateConfirmPage => By.XPath("(//td[@colspan='2'])[last()-10]");

        public By AmountOfCredit => By.XPath("(//td[@colspan='2'])[last()-13]");

        public By DisclosureDate => By.XPath("//td[contains(text(),'The information in this loan contract is prepared as at')]");

        public By emailSetupPage => By.XPath("(//li[@class='disabled'])[last()-1]");

        public By leavePopup => By.XPath("//button[@class='ui-button ui-widget ui-state-default ui-corner-all ui-button-icon-only ui-dialog-titlebar-close exitQuestionClose']");

        public By leavePopupDiv => By.XPath("//div[@class='ui-dialog ui-widget ui-widget-content ui-corner-all ui-front scale100']");

        public By FortNight => By.XPath("//label[@for='payFrequencyFort']");

        public By Monthly => By.XPath("//label[@for='payFrequencyMonth']");

       // public By FinalRepaymentConfirmPage => By.XPath("//*[@id='contractPage1']/table[2]/tbody/tr[8]/td[1]");
        public By FinalRepaymentConfirmPage => By.XPath("(//div[@id='contractPage1']/table)[2]//tr//td[contains(text(),'A final repayment of $')]");

        public By ActivateCard => By.XPath("//a[text()='Activate Card']");

        public By SecurityQuestion => By.XPath("//select[@id='securityquestions']");

        public By SecurityAnswer => By.XPath("//input[@id='securityanswer']");

        public By LastFourDigits => By.XPath("//input[@id='cardconfirm']");

        public By Productdisclosurebutton => By.XPath("(//div[@class='checkbox white-bg large'])[last()-1]");

        public By Financialservicesbutton => By.XPath("(//div[@class='checkbox white-bg large'])[last()]");

        public By ActivateCardButton => By.XPath("//a[@id='ActivateCard']");

        public By ActivateDoneButton => By.XPath("//a[@id='ActivateDone']");

        public By Bpay => By.XPath("//span[@class='bpay']");

        public By BillerCode => By.XPath("//input[@id='billercode']");

        public By VerifyBillerCode => By.XPath("//a[@id='btnVerifyBiller']");

        public By BpayReference => By.XPath("//input[@id='reference']");

        public By BpayDescription => By.XPath("//input[@id='description']");

        public By BpayAmount => By.XPath("//input[@id='amount']");

        public By BpaySubmit => By.XPath("//a[@id='btnBPay']");

        public By BpayActivateButton => By.XPath("//a[@id='btnConfirm']");

        public By BpayTransactionHistoryButton => By.XPath("//a[@id='btnMembersArea']");

        public By TransactionAmount => By.XPath("//td[@class='negative']");

        public By RepaymentCountConfirmPage => By.XPath("//*[@id='contractPage1']/table[2]/tbody/tr[3]/td[2]");

        public By RepaymentCountSetupPage => By.XPath("//td[@id='repaymentCount']");

        public By FinalRepaymentDateSetupPage => By.XPath("//span[@id='finalRepayment']");

        public By LowestRepAmt => By.XPath("(//div[@class='minAmount minmax f-left font-14 charcoal'])[last()]");

        public By HighestRepAmt => By.XPath("(//div [@class='maxAmount minmax f-right font-14 charcoal'])[last()]");

        public By RepAmtInTable => By.XPath("//td[@id='repaymentAmount']");

        public By Unconfirmedcontractmsg => By.XPath(".//tr[@id='termsandconditions2_error']//p");

        public By Unconfirmedpurposemsg => By.XPath(".//tr[@id='confirmpurpose_error']//p");

        public By Unconfirmedrepaymsg => By.XPath(".//tr[@id='confirmrepay_error']//p");

        public By GetConfirmedTxt => By.XPath("//*[@id='MemberDashboard']/div[1]/div/p");

        #endregion

    }

    public class LoanSetupDetailsMobileRLLoc : ILoanSetupDetails
    {
        #region Loan Progress Menu Items

        public By LoanApply => By.XPath("//div[@class='pli-icon sprite-common i-40-checkpoints']/following-sibling::div");

        public By Verify => By.XPath("//div[@class='pli-icon sprite-common i-40-pad-tick']/following-sibling::div");

        public By StepLoan => By.XPath("//div[@class='pli-icon sprite-common i-40-cog-grey']/following-sibling::div[contains(text(),'Set up loan')]");

        public By Confirm => By.XPath("//div[@class='pli-icon sprite-common i-40-pencil']/following-sibling::div");

        public By GetMoney => By.XPath("//div[@class='pli-icon sprite-common i-40-money']/following-sibling::div");

        #endregion

        #region Loan Progress Bottom Menu

        public By Dashboard => By.XPath("//p[contains(text(),'Dashboard')]");

        public By Card => By.XPath("//p[contains(text(),'Card')]");

        public By Timeline => By.XPath("//p[contains(text(),'Timeline')]");

        public By MoreButton => By.XPath("//p[contains(text(),'More')]");

        #endregion

        #region Loan setup locators

        public By RefreshButton => By.XPath(".//*[@id='linkMenuDesktopHomeRefresh']");

        public By SetupButton => By.XPath(".//span[@id='afterLoanAmount']/a[@class='pli-button button xsml gold']");

        public By VerifyButton => By.XPath(".//*[@id='LoanProgress']/div/div[2]/div[3]/div[2]/a");

        public By ApprovedloanAmount => By.XPath(".//span[@class='font-50 green block m-t-20 m-b-30']");

        public By firstrepaymentdate => By.XPath(".//*[@id='howLongSlider_wrap']/div[@class='display-value white text-center bold600']/span");

        public By Detailedpaymentamount => By.XPath(".//*[@id='repayments']//td[@class='descCol'][contains(text(),'1')]/following-sibling::td[@class='dateCol']");

        public By DetailedrepaymentscheduleButton => By.XPath(".//*[@id='detailsScheduleHeader']");

        public By ButtonSubmit => By.XPath(".//*[@id='submit']");

        public By FinalStepLabel => By.XPath(".//*[@id='contract-sign']/h1");

        public By Loancontract => By.XPath("//*[@id='contractScrollWrap_Mobile']");

        public By confirmLoancotract => By.XPath(".//input[@id='termsandconditions2_m']//following-sibling::div[@data-attached='termsandconditions2_m']");

        public By confirmpurpose => By.XPath(".//input[@id='confirmpurpose_m']//following-sibling::div[@data-attached='confirmpurpose_m']");

        public By confirmrepay => By.XPath(".//input[@id='confirmrepay_m']//following-sibling::div[@data-attached='confirmrepay_m']");

        public By confirmrepay1 => By.XPath(".//*[@id='confirmrepay_errorbox']/div[3]");

        public By EmailinDashboard => By.XPath(".//*[@id='debugLeftNav']/li[6]");

        public By GUIDDashboard => By.XPath(".//*[@id='debugLeftNav']/li[7]");

        public By LoanContractLabel => By.XPath(".//*[@id='contractScrollWrap_Mobile']/h3");

        public By Scrollbottom => By.XPath(".//div[@id='scrollBottom']");

        public By FundedAmount => By.XPath(".//*[@class='green font-70']");

        // submit contract button
        public By submitcontractButton => By.XPath(".//button[@id='confirm']");

        // existing User
        public By RequestMoney => By.XPath(".//*[@id='dashTop']/div/a/span[contains(text(),'Request Money')]");

        public By ExistingUserStartAppButon => By.XPath(".//*[@id='btnContinueNCCP_Returner']");

        //sms Input 
        public By SMSInput => By.XPath("//*[@id='smsinput']");

        public By SubmitPin => By.XPath("//*[@id='btnNext']");

        // acknowledge accept
        public By acknowledgebtn => By.XPath(".//*[@id='optInNVPC']/div/label");

        public By SubmitButton => By.XPath(".//*[@id='btnSubmit']");

        // Auto approved label
        public By LoanAutoApprovedLabel => By.XPath(".//*[@id='returnclient']/h1[contains(text(),'Congratulations!')]");

        //No Thanks
        public By NoThanksButton => By.XPath(".//*[@id='btnNoThanks']");

        //nimble card yes

        public By NimbleCardRbtn => By.XPath(".//input[@id='wantsavisacard']/following-sibling::div");

        public By NimblecardSubmitBtn => By.XPath(".//button[@id='btnSubmit']");

        //loan dashboard
        public By LoanDashBoard => By.XPath(".//*[@id='mobile-appendixmaincontractsignedreturner']/a");

        public By JustCheckingLabel => By.XPath(".//div[@class='width-90 block-center m-t-20 m-b-20 text-center']/h2");

        public By reasonspendless => By.XPath(".//label[@for='reason_YesSpendLess']");

        public By reasonsubmitBtn => By.XPath(".//button[@id='submit']");

        public By Logout => By.XPath(".//*[@id='mobile-more']//p[contains(text(),'Log out')]");

        public By DetailedTable => By.Id("repayments");

        public By More => By.XPath(".//div[@id='more']");

        public By FinalApprove => By.XPath(".//a[@href='/Account/DoFinalApproval']");

        public By LoanDashboardManual => By.XPath(".//a[@href='/Mobile/Home']");

        public By RefreshBtn => By.XPath("//a[@href='/Account/MobileHomeRefresh']//p[contains(text(),'Refresh')]");

        public By ManualApprove => By.XPath(".//*[@id='mobile-more']//p[contains(text(),'Approve')]");

        public By SliderLowestAmount => By.XPath("//div[@id='amtRequestedSlider']");

        public By SliderButtonLowestAmount => By.XPath("(//*[@class='ui-slider-handle ui-state-default ui-corner-all'])[last()]");

        public By loanSlider => By.XPath("(//*[@class='ui-slider-handle ui-state-default ui-corner-all'])[last()-2]");

        public By AmountDisplay => By.XPath("(//div[@class='display-value white text-center bold600']/span)[last()-1]");

        public By LeastAmount => By.XPath("(//*[@class='minAmount minmax f-left font-14 charcoal'])[last()-2]");
        public By RepaymentDateSlider => By.XPath("(//*[@class='ui-slider-handle ui-state-default ui-corner-all'])[last()-1]");
        public By RepaymentDateValue => By.XPath("(//div[@class='display-value white text-center bold600'])[last()-0]");

        public By MaxRepaymentAmount => By.XPath("(//div[@class='maxAmount minmax f-right font-14 charcoal'])[last()]");

        public By MinRepaymentAmount => By.XPath("(//div[@class='minAmount minmax f-left font-14 charcoal'])[last()]");

        public By AcctBSBLastPage => By.XPath("//h3[@class='m-b-20']");

        public By FirstDate => By.XPath("(//td[@class='dateCol'])[last()-8]");

        public By LastDate => By.XPath("(//td[@class='dateCol'])[last()]");

        public By RepaymentConfirmPage => By.XPath("(//td[@colspan='2'])[last()-9]");

        public By RepaymentSetupPage => By.XPath("//td[@id='totalRepayment']");

        public By RepaymentCount => By.XPath("//td[@id='repaymentCount']");

        public By FirstDateConfirmPage => By.XPath("(//td[@colspan='2'])[last()-11]");

        public By LastDateConfirmPage => By.XPath("(//td[@colspan='2'])[last()-10]");

        public By AmountOfCredit => By.XPath("(//td[@colspan='2'])[last()-13]");

        public By DisclosureDate => By.XPath("//td[contains(text(),'The information in this loan contract is prepared as at')]");

        public By emailSetupPage => By.XPath("(//li[@class='disabled'])[last()-1]");

        public By leavePopup => By.XPath("(//span[@class='ui-button-icon-primary ui-icon ui-icon-closethick'])[last()-5]");

        public By leavePopupDiv => By.XPath("//div[@class='ui-dialog ui-widget ui-widget-content ui-corner-all ui-front scale100']");

        public By FortNight => By.XPath("//label[@for='payFrequencyFort']");

        public By Monthly => By.XPath("//label[@for='payFrequencyMonth']");

        public By FinalRepaymentConfirmPage => By.XPath("(//div[@id='contractPage1']/table)[2]//tr//td[contains(text(),'A final repayment of $')]");

        public By ActivateCard => By.XPath("//a[text()='Activate Card']");

        public By SecurityQuestion => By.XPath("//select[@id='securityquestions']");

        public By SecurityAnswer => By.XPath("//input[@id='securityanswer']");

        public By LastFourDigits => By.XPath("//input[@id='cardconfirm']");

        public By Productdisclosurebutton => By.XPath("(//div[@class='checkbox white-bg large'])[last()-1]");

        public By Financialservicesbutton => By.XPath("(//div[@class='checkbox white-bg large'])[last()]");

        public By ActivateCardButton => By.XPath("//a[@id='ActivateCard']");

        public By ActivateDoneButton => By.XPath("//a[@id='ActivateDone']");

        public By Bpay => By.XPath("//span[@class='bpay']");

        public By BillerCode => By.XPath("//input[@id='billercode']");

        public By VerifyBillerCode => By.XPath("//a[@id='btnVerifyBiller']");

        public By BpayReference => By.XPath("//input[@id='reference']");

        public By BpayDescription => By.XPath("//input[@id='description']");

        public By BpayAmount => By.XPath("//input[@id='amount']");

        public By BpaySubmit => By.XPath("//a[@id='btnBPay']");

        public By BpayActivateButton => By.XPath("//a[@id='btnConfirm']");

        public By BpayTransactionHistoryButton => By.XPath("//a[@id='btnMembersArea']");

        public By TransactionAmount => By.XPath("//td[@class='negative']");

        public By RepaymentCountConfirmPage => By.XPath("//*[@id='contractPage1']/table[2]/tbody/tr[3]/td[2]");

        public By RepaymentCountSetupPage => By.XPath("//td[@id='repaymentCount']");

        public By FinalRepaymentDateSetupPage => By.XPath("//span[@id='finalRepayment']");

        public By LowestRepAmt => By.XPath("(//div[@class='minAmount minmax f-left font-14 charcoal'])[last()]");

        public By HighestRepAmt => By.XPath("(//div [@class='maxAmount minmax f-right font-14 charcoal'])[last()]");

        public By RepAmtInTable => By.XPath("//td[@id='repaymentAmount']");

        public By Unconfirmedcontractmsg => By.XPath(".//tr[@id='termsandconditions2_error']//p");

        public By Unconfirmedpurposemsg => By.XPath(".//tr[@id='confirmpurpose_error']//p");

        public By Unconfirmedrepaymsg => By.XPath(".//tr[@id='confirmrepay_error']//p");

        public By GetConfirmedTxt => By.XPath("//*[@id='MemberDashboard']/div[1]/div/p");

        #endregion

    }

    public class LoanSetupDetailsDesktopRLLoc : ILoanSetupDetails
    {
        #region Loan Progress Menu Items

        public By LoanApply => By.XPath("//div[@class='pli-icon sprite-common i-40-checkpoints']/following-sibling::div");

        public By Verify => By.XPath("//div[@class='pli-icon sprite-common i-40-pad-tick']/following-sibling::div");

        public By StepLoan => By.XPath("//div[@class='pli-icon sprite-common i-40-cog-grey']/following-sibling::div[contains(text(),'Set up loan')]");

        public By Confirm => By.XPath("//div[@class='pli-icon sprite-common i-40-pencil']/following-sibling::div");

        public By GetMoney => By.XPath("//div[@class='pli-icon sprite-common i-40-money']/following-sibling::div");

        #endregion

        #region Loan Progress Bottom Menu

        public By Dashboard => By.XPath("//p[contains(text(),'Dashboard')]");

        public By Card => By.XPath("//p[contains(text(),'Card')]");

        public By Timeline => By.XPath("//p[contains(text(),'Timeline')]");

        public By MoreButton => By.XPath("//p[contains(text(),'More')]");

        #endregion

        #region Loan setup locators

        public By RefreshButton => By.XPath(".//*[@id='linkMenuDesktopHomeRefresh']");

        public By SetupButton => By.XPath(".//span[@id='afterLoanAmount']/a[@class='pli-button button xsml gold']");

        public By VerifyButton => By.XPath(".//*[@id='LoanProgress']/div/div[2]/div[3]/div[2]/a");

        public By ApprovedloanAmount => By.XPath(".//*[@id='ReturnerCalc']/h1/span");

        public By firstrepaymentdate => By.XPath(".//*[@id='howLongSlider_wrap']/div[@class='display-value white text-center bold600']/span");

        public By Detailedpaymentamount => By.XPath(".//*[@id='repayments']//td[@class='descCol'][contains(text(),'1')]/following-sibling::td[@class='dateCol']");

        public By DetailedrepaymentscheduleButton => By.XPath(".//*[@class='ui-accordion-header ui-state-default ui-corner-all ui-accordion-icons']");

        public By ButtonSubmit => By.XPath(".//*[@id='SubmitButton']");

        public By FinalStepLabel => By.XPath(".//*[@id='contract-sign']/h1");

        public By Loancontract => By.XPath(".//*[@id='contractScroll']");

        public By confirmLoancotract => By.XPath("//*[contains(@data-attached,'termsandconditions2')]");

        // public By confirmpurpose => By.XPath(".//*[@id='confirmpurpose_errorbox']/div[3]");//label");//*[contains(@data-attached,'confirmpurpose')]

        public By confirmpurpose => By.XPath("//*[contains(@data-attached,'confirmpurpose')]");

        public By confirmrepay1 => By.XPath(".//*[@id='confirmrepay_errorbox']/div[3]");//label");////*[contains(@data-attached,'confirmrepay')]

        public By confirmrepay => By.XPath("//*[contains(@data-attached,'confirmrepay')]");

        public By EmailinDashboard => By.XPath(".//*[@id='debugLeftNav']/li[6]");

        public By GUIDDashboard => By.XPath(".//*[@id='debugLeftNav']/li[7]");

        public By LoanContractLabel => By.XPath(".//*[@id='contractScrollWrap']/h3");

        public By Scrollbottom => By.XPath(".//div[@id='scrollBottom']");

        public By FundedAmount => By.XPath(".//*[@id='contentholder']/h2[2]");

        // submit contract button
        public By submitcontractButton => By.XPath(".//button[@id='submitContract']");

        // existing User
        public By RequestMoney => By.XPath(".//*[@id='dashTop']/div/a/span[contains(text(),'Request Money')]");

        public By ExistingUserStartAppButon => By.XPath(".//*[@id='btnContinueNCCP_Returner']");

        //sms Input 
        public By SMSInput => By.XPath(".//input[@id='smsInput']");

        public By SubmitPin => By.XPath(".//button[@id='submitpin']");

        // acknowledge accept
        public By acknowledgebtn => By.XPath(".//*[@id='optInNVPC']/div/label");

        public By SubmitButton => By.XPath(".//*[@id='btnSubmit']");

        // Auto approved label
        public By LoanAutoApprovedLabel => By.XPath(".//*[@id='ReturnerCalc']/h1[contains(text(),'Congratulations!')]");

        //No thanks
        public By NoThanksButton => By.XPath(".//*[@id='btnNoThanks']");

        // nimble card yes
        public By NimbleCardRbtn => By.XPath(".//input[@id='wantsavisacard']/following-sibling::div");

        public By NimblecardSubmitBtn => By.XPath(".//button[@id='btnSubmit']");

        public By LoanDashBoard => By.XPath("//span[text()='Loan Dashboard']");

        public By LoanDashboardManual => By.XPath(".//a[@href='/Account/MemberHome']/span");

        public By JustCheckingLabel => By.XPath(".//div[@id='maincontent']//h2[contains(text(),'Just checking')]");

        public By reasonspendless => By.XPath(".//label[@for='reason_YesSpendLess']");

        public By reasonsubmitBtn => By.XPath(".//a[@id='submit']");

        public By Logout => By.XPath("//a[@href='/Account/Logout']");

        public By DetailedTable => By.Id("repayments");

        public By More => By.XPath(".//div[@id='more']");

        public By FinalApprove => By.XPath(".//a[@href='/Account/DoFinalApproval']");

        public By ManualApprove => By.XPath(".//*[@id='mobile-more']//p[contains(text(),'Approve')]");

        public By RefreshBtn => By.XPath("//a[@href='/Account/DesktopHomeRefresh']//p[contains(text(),'Refresh')]");

        public By SliderLowestAmount => By.XPath("//div[@id='amtRequestedSlider']");

        public By SliderButtonLowestAmount => By.XPath("(//*[@class='ui-slider-handle ui-state-default ui-corner-all'])[last()]");
        public By loanSlider => By.XPath("(//*[@class='ui-slider-handle ui-state-default ui-corner-all'])[last()-2]");
        public By AmountDisplay => By.XPath("(//div[@class='display-value white text-center bold600']/span)[last()-1]");

        public By LeastAmount => By.XPath("(//*[@class='minAmount minmax f-left font-14 charcoal'])[last()-2]");
        public By RepaymentDateSlider => By.XPath("(//*[@class='ui-slider-handle ui-state-default ui-corner-all'])[last()-1]");
        public By RepaymentDateValue => By.XPath("(//div[@class='display-value white text-center bold600'])[last()-0]");

        public By MaxRepaymentAmount => By.XPath("(//div[@class='maxAmount minmax f-right font-14 charcoal'])[last()]");

        public By MinRepaymentAmount => By.XPath("(//div[@class='minAmount minmax f-left font-14 charcoal'])[last()]");

        public By AcctBSBLastPage => By.XPath("//h3[@class='m-b-20']");

        public By FirstDate => By.XPath("(//td[@class='dateCol'])[last()-2]");

        public By LastDate => By.XPath("(//td[@class='dateCol'])[last()]");

        public By RepaymentConfirmPage => By.XPath("(//td[@colspan='2'])[last()-9]");

        public By RepaymentSetupPage => By.XPath("//td[@id='totalRepayment']");

        public By RepaymentCount => By.XPath("//td[@id='repaymentCount']");

        public By FirstDateConfirmPage => By.XPath("(//td[@colspan='2'])[last()-11]");

        public By LastDateConfirmPage => By.XPath("(//td[@colspan='2'])[last()-10]");

        public By AmountOfCredit => By.XPath("(//td[@colspan='2'])[last()-13]");

        public By DisclosureDate => By.XPath("//td[contains(text(),'The information in this loan contract is prepared as at')]");

        public By emailSetupPage => By.XPath("(//li[@class='disabled'])[last()-1]");

        public By leavePopup => By.XPath("(//button[@class='ui-button ui-widget ui-state-default ui-corner-all ui-button-icon-only ui-dialog-titlebar-close exitQuestionClose'])");

        public By leavePopupDiv => By.XPath("//div[@class='ui-dialog ui-widget ui-widget-content ui-corner-all ui-front scale100']");

        public By FortNight => By.XPath("//label[@for='payFrequencyFort']");

        public By Monthly => By.XPath("//label[@for='payFrequencyMonth']");

        public By FinalRepaymentConfirmPage => By.XPath("(//div[@id='contractPage1']/table)[2]//tr//td[contains(text(),'A final repayment of $')]");

        public By ActivateCard => By.XPath("//a[text()='Activate Card']");

        public By SecurityQuestion => By.XPath("//select[@id='securityquestions']");

        public By SecurityAnswer => By.XPath("//input[@id='securityanswer']");

        public By LastFourDigits => By.XPath("//input[@id='cardconfirm']");

        public By Productdisclosurebutton => By.XPath("(//div[@class='checkbox white-bg large'])[last()-1]");

        public By Financialservicesbutton => By.XPath("(//div[@class='checkbox white-bg large'])[last()]");

        public By ActivateCardButton => By.XPath("//a[@id='ActivateCard']");

        public By ActivateDoneButton => By.XPath("//a[@id='ActivateDone']");

        public By Bpay => By.XPath("//span[@class='bpay']");

        public By BillerCode => By.XPath("//input[@id='billercode']");

        public By VerifyBillerCode => By.XPath("//a[@id='btnVerifyBiller']");

        public By BpayReference => By.XPath("//input[@id='reference']");

        public By BpayDescription => By.XPath("//input[@id='description']");

        public By BpayAmount => By.XPath("//input[@id='amount']");

        public By BpaySubmit => By.XPath("//a[@id='btnBPay']");

        public By BpayActivateButton => By.XPath("//a[@id='btnConfirm']");

        public By BpayTransactionHistoryButton => By.XPath("//a[@id='btnMembersArea']");

        public By TransactionAmount => By.XPath("//td[@class='negative']");

        public By RepaymentCountConfirmPage => By.XPath("//*[@id='contractPage1']/table[2]/tbody/tr[3]/td[2]");

        public By RepaymentCountSetupPage => By.XPath("//td[@id='repaymentCount']");

        public By FinalRepaymentDateSetupPage => By.XPath("//span[@id='finalRepayment']");

        public By LowestRepAmt => By.XPath("(//div[@class='minAmount minmax f-left font-14 charcoal'])[last()]");

        public By HighestRepAmt => By.XPath("(//div [@class='maxAmount minmax f-right font-14 charcoal'])[last()]");

        public By RepAmtInTable => By.XPath("//td[@id='repaymentAmount']");

        public By Unconfirmedcontractmsg => By.XPath(".//tr[@id='termsandconditions2_error']//p");

        public By Unconfirmedpurposemsg => By.XPath(".//tr[@id='confirmpurpose_error']//p");

        public By Unconfirmedrepaymsg => By.XPath(".//tr[@id='confirmrepay_error']//p");

        public By GetConfirmedTxt => By.XPath("//*[@id='MemberDashboard']/div[1]/div/p");

        #endregion

    }
}
