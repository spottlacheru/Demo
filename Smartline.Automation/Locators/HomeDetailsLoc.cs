using System;
using System.Diagnostics;
using OpenQA.Selenium;

namespace Toyota.Automation.Repository
{
    public interface IHomeDetails
    {
        By NimbleLogo { get; }

        By linkMenuApply { get; }
        
       By EnterAmount { get; }
            
        By btnstartApplication { get; }

        By btnLogin { get; }

        By BtnHideShowDebug { get; }

        By BtnPassAllNobs { get; }

        By RequestMoney { get; }

        By LoginUsername { get; }

        By LoginPassword { get; }

        By LoginButton { get; }

        By DebugLogibBtn { get; }

        By PopupLogibBtn { get; }

        By CreateClient { get; }

        By OldProduct { get; }

        By ReturnerSingle { get; }

        By FetchEmailId { get; }

        By FetchEmailId2 { get; }

        By FetchEmailIdSACCOutGrace { get; }

        By FetchEmailIDSACCInGrace { get; }

        By FetchEmailIDDavidSACCOutGrace { get; }

        By DavidClientBtn { get; }

        By cancelPurposeLoanDialog { get; }

        By DavidTestClients { get; }

        By GracePeriodEmail { get; }//*[@id="sacc-failed-payment-outside-grace"]/td[1]/button

        By GracePeriodMakeButton { get; }
        // By LoanPurposeDetailsMobileNLLoc { get; }

        By ClickCreateClientGracePeriodBtn { get; }

        By ClickCreateClientSACCOutGraceBtn { get; }

        By ClickCreateClientSACCInGraceBtn { get; }

        By ClickDavidSACCOurGraceMakeBtn { get; }

        By ClickMakeRepaymentBtn { get; }

        By CheckRepaymentDirectDebitChkbx { get; }

        By CheckRepaymentDebitCardChkbx { get; }

        By CheckRepaymentBPAYChkbx { get; }

        By CheckRepaymentEFTChkbx { get; }

        By ClickRepaymentContinueBtn { get; }

        By ClickRepaymentDirectDebitBtn { get; }

        By ClickRepaymentDebitCardBtn { get; }

        By WaitForPaymentpage { get; }

        By ClickRepaymentBPAYBtn { get; }

        By ClickRepaymentEFTBtn { get; }

        By EnterRepaymentNameOnCardTxt { get; }

        By EnterRepaymentCardNumberTxt { get; }

        By EnterRepaymentExpiryTxt { get; }

        By EnterRepaymentSecurityTxt { get; }

        By ClickRepaymentBackBtn { get; }

        By ClickRepaymentConfirmBtn { get; }

        By ClickRepaymentDebitCardDoneBtn { get; }

        By ClickMemberAreaEditProfileLnk { get; }

        By ClickEditProfileContactDetailsBtn { get; }

        By EnterEditProfileStreetNameTxt { get; }

        By ClickEditProfileSaveBtn { get; }

        By ClickEditProfileLoanDashboardBtn { get; }

        By ClickMobileMoreBtn { get; }

        By ClickMobileYourProfileLnk { get; }

        By ClickMobileYourProfileContactLnk { get; }

        By EnterMobileYourProfileStreetNameTxt { get; }

        By ClickMobileYourProfileSaveBtn { get; }

        By ClickMobileDashboardLnk { get; }

        By ClickDesktopYourDashboardLnk { get; }

        By ClickMarketSurveyCloseBtn { get; }
    }

    public class HomeDetailsMobileNLLoc : IHomeDetails
    {
        //Enter Money amount

        public By EnterAmount => By.XPath("//*[@id='selPolSections - container']/div[1]/table/tbody/tr[2]/td[2]/div");

        //Nimble Logo
        public By NimbleLogo => By.XPath("//img[@src='/images/logo-basic.svg']");

        //Apply button MAIN
        public By linkMenuApply => By.XPath("(//*[@class='button'])[last()-2]");

        //Start Application Button

        // public By btnstartApplication => By.XPath("//a[@href='https://staging.inator.com.au/apply/']");
        public By btnstartApplication => By.XPath(".//div[@class='buttonWrap']/a[contains(text(),'Start your Application')]");

        //BtnHideShowDebug
        public By BtnHideShowDebug => By.XPath(".//*[@id='debug-show']");

        //BtnPassAllNobs
        public By BtnPassAllNobs => By.XPath(".//*[@id='debugonlybuttons']/button[contains(text(),'Pass All (no bs)')]");

        //Not Used for Nl Scenarios.........................ignore..........................................................................................................................

        public By btnLogin => By.XPath("(//a[text()='Login'])[1]");
            //a[@href='/login/']");

        public By DebugLogibBtn => By.XPath("//a[@href='/account/login']");

        public By cancelPurposeLoanDialog => By.XPath(".//button[@id='cancelPolDlg']");

        public By RequestMoney => By.XPath(".//*[@class='width-80 block-center m-t-40 p-b-40']/a[contains(text(),'Request Money')]");

        public By LoginUsername => By.XPath(".//input[@id='username']");

        public By LoginPassword => By.XPath(".//input[@id='password']");

        public By LoginButton => By.XPath(".//*[@id='submit']");

        public By SelectFirstPurpose => By.XPath(".//*[@id='selPolSections-container']/div[1]//span[contains(text(),'- select purpose -')]");

        public By ClickFirstLoanPurposeMob => By.XPath("(//span[text()='- select purpose -'])[last()-1]");

        public By ClickSecondLoanPurposeMob => By.XPath("(//span[text()='- select purpose -'])[last()]");

        public By CreateClient => By.XPath(".//*[@id='content']/p[7]/a");

        public By OldProduct => By.XPath(".//*[@id='clientlist']/table/tbody/tr[32]/td");

        public By ReturnerSingle => By.XPath(".//*[@id='returner-clean-first-advance']/td[1]/button");

        public By FetchEmailId=>  By.XPath(".//tr[@style='display: table-row;']//td[2]/span[text()='Old Product: Returner - Single advance paid clean']/../div/a[1]");
            
        //public By FetchEmailId => By.XPath(".//*[@id='returner-clean-first-advance']/td[2]/div");

        public By FetchEmailId2 => By.XPath(".//*[@id='returner-clean-first-advance']/td[2]/div[2]");

        public By FetchEmailIdSACCOutGrace => By.XPath("//*[@id='sacc-failed-payment-outside-grace']/td[2]/div/a[1]");

        public By FetchEmailIDSACCInGrace => By.XPath("//*[@id='sacc-failed-payment-inside-grace']/td[2]/div[1]/a[1]");

        public By DavidClientBtn => By.XPath(".//*[@id='clientlist']/table/tbody/tr[67]/td");

        public By FetchEmailIDDavidSACCOutGrace => By.XPath(".//*[@id='david-MemberFailedFirstPayOutGrace']/td[2]/div/a[1]");
        
        //popup login button
        public By PopupLogibBtn => By.XPath("//span[text()='Login']");


        public By DavidTestClients => By.XPath("//*[@id='clientlist']/table/tbody/tr[67]/td");

        public By GracePeriodEmail => By.XPath("//*[@id='david-MemberFailedFirstPayOutGrace']/td[2]/div/a[1]");

        public By GracePeriodMakeButton => By.XPath("//*[@id='david-MemberFailedFirstPayOutGrace']/td[1]/button");

        public By ClickCreateClientGracePeriodBtn => By.XPath("//*[@id='clientlist']/table/tbody/tr[98]/td");

        public By ClickCreateClientSACCOutGraceBtn => By.XPath("//*[@id='sacc-failed-payment-outside-grace']/td[1]/button");

        public By ClickCreateClientSACCInGraceBtn => By.XPath("//*[@id='sacc-failed-payment-inside-grace']/td[1]/button");

        public By ClickDavidSACCOurGraceMakeBtn => By.XPath("//*[@id='david-MemberFailedFirstPayOutGrace']/td[1]/button");
              
        public By ClickMakeRepaymentBtn => By.XPath("//*[@id='overlay-buttons']/a");

        public By CheckRepaymentDirectDebitChkbx => By.XPath("//*[@id='paymentOptions']/table/tbody/tr[1]/td[1]/div");

        public By CheckRepaymentDebitCardChkbx => By.XPath("//*[@id='ccRadio']/td[1]/div");

        public By CheckRepaymentBPAYChkbx => By.XPath("//*[@id='paymentOptions']/table/tbody/tr[4]/td[1]/div");

        public By CheckRepaymentEFTChkbx => By.XPath("//*[@id='paymentOptions']/table/tbody/tr[5]/td[1]/div");

        public By ClickRepaymentContinueBtn => By.XPath("//*[@id='btnSelectPaymentOption']");

        public By ClickRepaymentDirectDebitBtn => By.XPath("//*[@id='btnDD']");

        public By ClickRepaymentDebitCardBtn => By.XPath("//*[@id='btnCC']");

        public By WaitForPaymentpage => By.XPath("//*[contains(text(),'Thanks for your payment')]");

        public By ClickRepaymentBPAYBtn => By.XPath("//*[@id='btnBPay']");

        public By ClickRepaymentEFTBtn => By.XPath("//*[@id='btnEFT']");

        public By EnterRepaymentNameOnCardTxt => By.XPath("//*[@id='cc_name']");

        public By EnterRepaymentCardNumberTxt => By.XPath("//*[@id='cc_number']");

        public By EnterRepaymentExpiryTxt => By.XPath("//*[@id='cc_expiry']");

        public By EnterRepaymentSecurityTxt => By.XPath("//*[@id='cc_security_code']");

        public By ClickRepaymentBackBtn => By.XPath(" //*[@id='btnConfirmBack']");

        public By ClickRepaymentConfirmBtn => By.XPath("//*[@id='btnConfirm']");

        public By ClickRepaymentDebitCardDoneBtn => By.XPath("//*[@id='btnCCDone']");

        public By ClickMemberAreaEditProfileLnk => By.XPath(""); //desktop only

        public By ClickEditProfileContactDetailsBtn => By.XPath(""); //desktop only

        public By EnterEditProfileStreetNameTxt => By.XPath(""); //desktop only

        public By ClickEditProfileSaveBtn => By.XPath(""); //desktop only

        public By ClickEditProfileLoanDashboardBtn => By.XPath(""); //desktop only

        public By ClickMobileMoreBtn => By.XPath("//*[@id='more']");

        public By ClickMobileYourProfileLnk => By.XPath("//*[@id='mobile-more']/ul/li[1]/a");

        public By ClickMobileYourProfileContactLnk => By.XPath("//*[@id='navbuttons']/li[2]/a");

        public By EnterMobileYourProfileStreetNameTxt => By.XPath("//*[@id='streetname']");

        public By ClickMobileYourProfileSaveBtn => By.XPath("//*[@id='submit-2']");

        public By ClickMobileDashboardLnk => By.XPath("//*[@id='dashboard']");

        public By ClickDesktopYourDashboardLnk => By.XPath("");

        public By ClickMarketSurveyCloseBtn => By.XPath(""); // desktop only


    }

    public class HomeDetailsDesktopNLLoc : IHomeDetails
    {
        //Enter Money amount

        public By EnterAmount => By.XPath("//*[@id='selPolSections - container']/div[1]/table/tbody/tr[2]/td[2]/div");
        //Nimble Logo
        public By NimbleLogo => By.XPath(".//*[@id='header-logo']/a/amp-img/img");

        //Apply button in the menu bar
        public By linkMenuApply => By.XPath("//a[text()='Apply']");
        //.//div[@class='width-100']/nav/a[contains(text(),'Apply')]

        //Start Application Button

        // public By btnstartApplication => By.XPath(".//a[@href='https://staging.inator.com.au/apply/']");

        public By btnstartApplication => By.XPath(".//div[@class='buttonWrap']/a[contains(text(),'Start your Application')]");


        //BtnHideShowDebug
        public By BtnHideShowDebug => By.XPath(".//*[@id='debug-show']");

        //BtnPassAllNobs
        public By BtnPassAllNobs => By.XPath(".//*[@id='debugonlybuttons']/button[contains(text(),'Pass All (no bs)')]");

        //Not Used for NL Scenarios.........................ignore................................................................................................................................

        // public By btnLogin => By.XPath(".//div[@id='header-logo']/following-sibling::nav/a[contains(text(),'Login')]");
        public By btnLogin => By.ClassName("nav-login");

        public By DebugLogibBtn => By.XPath(".//li[@id='linkMenuLogin']");

        public By RequestMoney => By.XPath(".//*[@id='dashTop']/div/a/span[contains(text(),'Request Money')]");

        public By LoginUsername => By.XPath(".//input[@id='username']");

        public By LoginPassword => By.XPath(".//input[@id='password']");

        public By LoginButton => By.XPath(".//*[@class='button']");

        public By cancelPurposeLoanDialog => By.XPath(".//button[@id='cancelPolDlg']");

        public By CreateClient => By.XPath(".//*[@id='content']/p[7]/a");

        public By OldProduct => By.XPath(".//*[@id='clientlist']/table/tbody/tr[32]/td");

        public By ReturnerSingle => By.XPath(".//*[@id='returner-clean-first-advance']/td[1]/button");

        public By FetchEmailId => By.XPath(".//*[@id='returner-clean-first-advance']/td[2]/div");

        public By FetchEmailId2 => By.XPath(".//*[@id='returner-clean-first-advance']/td[2]/div[2]");

        public By FetchEmailIdSACCOutGrace => By.XPath("//*[@id='sacc-failed-payment-outside-grace']/td[2]/div/a[1]");

        public By FetchEmailIDSACCInGrace => By.XPath("//*[@id='sacc-failed-payment-inside-grace']/td[2]/div[1]/a[1]");

        public By DavidClientBtn => By.XPath(".//*[@id='clientlist']/table/tbody/tr[67]/td");

        public By FetchEmailIDDavidSACCOutGrace => By.XPath(".//*[@id='david-MemberFailedFirstPayOutGrace']/td[2]/div/a[1]");

        public By ClickDavidSACCOurGraceMakeBtn => By.XPath("//*[@id='david-MemberFailedFirstPayOutGrace']/td[1]/button");

        //popup login button
        public By PopupLogibBtn => By.XPath("//span[text()='Login']");


        public By DavidTestClients => By.XPath("//*[@id='clientlist']/table/tbody/tr[67]/td");

        public By GracePeriodEmail => By.XPath("//*[@id='david-MemberFailedFirstPayOutGrace']/td[2]/div/a[1]");

        public By GracePeriodMakeButton => By.XPath("//*[@id='david-MemberFailedFirstPayOutGrace']/td[1]/button");

        public By ClickCreateClientGracePeriodBtn => By.XPath("//*[@id='clientlist']/table/tbody/tr[98]/td");

        public By ClickCreateClientSACCOutGraceBtn => By.XPath("//*[@id='sacc-failed-payment-outside-grace']/td[1]/button");

        public By ClickCreateClientSACCInGraceBtn => By.XPath("//*[@id='sacc-failed-payment-inside-grace']/td[1]/button");

        public By ClickMakeRepaymentBtn => By.XPath("//*[@id='member-message']/div[2]/a/span");

        public By CheckRepaymentDirectDebitChkbx => By.XPath("//*[@id='paymentOptions']/table/tbody/tr[1]/td[1]/div");

        public By CheckRepaymentDebitCardChkbx => By.XPath("//*[@id='ccRadio']/td[1]/div");

        public By CheckRepaymentBPAYChkbx => By.XPath("//*[@id='paymentOptions']/table/tbody/tr[3]/td[1]/div");

        public By CheckRepaymentEFTChkbx => By.XPath("//*[@id='paymentOptions']/table/tbody/tr[4]/td[1]/div");

        public By ClickRepaymentContinueBtn => By.XPath("//*[@id='btnSelectPaymentOption']");

        public By ClickRepaymentDirectDebitBtn => By.XPath("//*[@id='btnDD']");

        public By ClickRepaymentDebitCardBtn => By.XPath("//*[@id='btnCC']");

        public By WaitForPaymentpage => By.XPath("//*[contains(text(),'Thanks for your payment')]");

        public By ClickRepaymentBPAYBtn => By.XPath("//*[@id='btnBPay']");

        public By ClickRepaymentEFTBtn => By.XPath("//*[@id='btnEFT']");

        public By EnterRepaymentNameOnCardTxt => By.XPath("//*[@id='cc_name']");

        public By EnterRepaymentCardNumberTxt => By.XPath("//*[@id='cc_number']");

        public By EnterRepaymentExpiryTxt => By.XPath("//*[@id='cc_expiry']");

        public By EnterRepaymentSecurityTxt => By.XPath("//*[@id='cc_security_code']");

        public By ClickRepaymentBackBtn => By.XPath(" //*[@id='btnConfirmBack']");

        public By ClickRepaymentConfirmBtn => By.XPath("//*[@id='btnConfirm']");

        public By ClickRepaymentDebitCardDoneBtn => By.XPath("//*[@id='btnCCDone']");

        public By ClickMemberAreaEditProfileLnk => By.XPath("//*[@id='member-leftnav']/ul[5]/li/a");

        public By ClickEditProfileContactDetailsBtn => By.XPath("//*[@id='contactDetailsHeader']/span");

        public By EnterEditProfileStreetNameTxt => By.XPath("//*[@id='streetname']");

        public By ClickEditProfileSaveBtn => By.XPath("//*[@id='SaveButton']");

        public By ClickEditProfileLoanDashboardBtn => By.XPath("//*[@id='member-maincontent']/div/div/a");

        public By ClickMobileMoreBtn => By.XPath(""); // Mobile only

        public By ClickMobileYourProfileLnk => By.XPath(""); // Mobile only

        public By ClickMobileYourProfileContactLnk => By.XPath(""); // Mobile only

        public By EnterMobileYourProfileStreetNameTxt => By.XPath(""); // Mobile only

        public By ClickMobileYourProfileSaveBtn => By.XPath(""); // Mobile only

        public By ClickMobileDashboardLnk => By.XPath(""); // Mobile only

        public By ClickDesktopYourDashboardLnk => By.XPath("//*[@id='linkMenuMemberHome']");

        public By ClickMarketSurveyCloseBtn => By.XPath("(//button[@type='button' and @title='Close']//span[text()='Close'])[1]");
            //html/body/div[6]/div[1]/button/span[1]");

    }

    //Returner Loan Xpaths..............................................................................................................................................................



    //RL-Mobile.........................................................................................................................................................................

    public class HomeDetailsMobileRLLoc : IHomeDetails
    {
        //Enter Money amount

        public By EnterAmount => By.XPath("//*[@id='selPolSections - container']/div[1]/table/tbody/tr[2]/td[2]/div");
        //Create client link
        public By CreateClient => By.XPath(".//*[@id='content']/p[7]/a");

        //Old Product Link
        public By OldProduct => By.XPath(".//*[@id='clientlist']/table/tbody/tr[32]/td");

        //Make Button
        public By ReturnerSingle => By.XPath(".//*[@id='returner-clean-first-advance']/td[1]/button");

        //First Email
        public By FetchEmailId => By.XPath(".//*[@id='returner-clean-first-advance']/td[2]/div");

        //Second Email
        public By FetchEmailId2 => By.XPath(".//*[@id='returner-clean-first-advance']/td[2]/div[2]");

        public By FetchEmailIdSACCOutGrace => By.XPath("//*[@id='sacc-failed-payment-outside-grace']/td[2]/div/a[1]");

        public By FetchEmailIDSACCInGrace => By.XPath("//*[@id='sacc-failed-payment-inside-grace']/td[2]/div[1]/a[1]");

        public By DavidClientBtn => By.XPath(".//*[@id='clientlist']/table/tbody/tr[67]/td");

        public By FetchEmailIDDavidSACCOutGrace => By.XPath(".//*[@id='david-MemberFailedFirstPayOutGrace']/td[2]/div/a[1]");

        public By ClickDavidSACCOurGraceMakeBtn => By.XPath("//*[@id='david-MemberFailedFirstPayOutGrace']/td[1]/button");

        //Login button in the debug page
        public By DebugLogibBtn => By.XPath("//a[@href='/account/login']");

        //popup login button
        public By PopupLogibBtn => By.XPath("//span[text()='Login']");

        //Username Textbox
        public By LoginUsername => By.XPath(".//input[@id='username']");

        //Password Textbox
        public By LoginPassword => By.XPath(".//input[@id='password']");

        //Login Button after giving username and password
        public By LoginButton => By.XPath(".//*[@class='button']");

        //Login Button in the menu bar
        public By btnLogin => By.XPath("(//a[text()='Login'])[1]");

        //Request Money
        public By RequestMoney => By.XPath(".//*[@class='width-80 block-center m-t-40 p-b-40']/a[contains(text(),'Request Money')]");
                                              
        //Start Application Button
        public By btnstartApplication => By.XPath("//*[@id='btnContinueNCCP_Returner']");

        //Apply button in the menu bar......Not available in mobile
        public By linkMenuApply => By.XPath(".//div[@class='width-100']/nav/a[contains(text(),'Apply')]");

        //Nimble Logo......Not available in mobile
        public By NimbleLogo => By.XPath(".//*[@id='header-logo']/a/amp-img/img");

        //BtnHideShowDebug
        public By BtnHideShowDebug => By.XPath(".//*[@id='debug-show']");

        //BtnPassAllNobs
        public By BtnPassAllNobs => By.XPath(".//*[@id='debugonlybuttons']/button[contains(text(),'Pass All (no bs)')]");

        //For closing the pol popup
        public By cancelPurposeLoanDialog => By.XPath(".//button[@id='cancelPolDlg']");

        public By DavidTestClients => By.XPath("//*[@id='clientlist']/table/tbody/tr[67]/td");

        public By GracePeriodEmail => By.XPath("//*[@id='david - MemberFailedFirstPayOutGrace']/td[2]/div/a[1]");

        public By GracePeriodMakeButton => By.XPath("//*[@id='david-MemberFailedFirstPayOutGrace']/td[1]/button");

        public By ClickCreateClientGracePeriodBtn => By.XPath("//*[@id='clientlist']/table/tbody/tr[98]/td");

        public By ClickCreateClientSACCOutGraceBtn => By.XPath("//*[@id='sacc-failed-payment-outside-grace']/td[1]/button");

        public By ClickCreateClientSACCInGraceBtn => By.XPath("//*[@id='sacc-failed-payment-inside-grace']/td[1]/button");

        public By ClickMakeRepaymentBtn => By.XPath("//*[@id='overlay-buttons']/a");

        public By CheckRepaymentDirectDebitChkbx => By.XPath("//*[@id='paymentOptions']/table/tbody/tr[1]/td[1]/div");

        public By CheckRepaymentDebitCardChkbx => By.XPath("//*[@id='ccRadio']/td[1]/div");

        public By CheckRepaymentBPAYChkbx => By.XPath("//*[@id='paymentOptions']/table/tbody/tr[4]/td[1]/div");

        public By CheckRepaymentEFTChkbx => By.XPath("//*[@id='paymentOptions']/table/tbody/tr[5]/td[1]/div");

        public By ClickRepaymentContinueBtn => By.XPath("//*[@id='btnSelectPaymentOption']");

        public By ClickRepaymentDirectDebitBtn => By.XPath("//*[@id='btnDD']");

        public By ClickRepaymentDebitCardBtn => By.XPath("//*[@id='btnCC']");

        public By WaitForPaymentpage => By.XPath("//*[contains(text(),'Thanks for your payment')]");

        public By ClickRepaymentBPAYBtn => By.XPath("//*[@id='btnBPay']");

        public By ClickRepaymentEFTBtn => By.XPath("//*[@id='btnEFT']");

        public By EnterRepaymentNameOnCardTxt => By.XPath("//*[@id='cc_name']");

        public By EnterRepaymentCardNumberTxt => By.XPath("//*[@id='cc_number']");

        public By EnterRepaymentExpiryTxt => By.XPath("//*[@id='cc_expiry']");

        public By EnterRepaymentSecurityTxt => By.XPath("//*[@id='cc_security_code']");

        public By ClickRepaymentBackBtn => By.XPath(" //*[@id='btnConfirmBack']");

        public By ClickRepaymentConfirmBtn => By.XPath("//*[@id='btnConfirm']");

        public By ClickRepaymentDebitCardDoneBtn => By.XPath("//*[@id='btnCCDone']");

        public By ClickMemberAreaEditProfileLnk => By.XPath(""); //desktop only

        public By ClickEditProfileContactDetailsBtn => By.XPath(""); //desktop only

        public By EnterEditProfileStreetNameTxt => By.XPath(""); //desktop only

        public By ClickEditProfileSaveBtn => By.XPath(""); //desktop only

        public By ClickEditProfileLoanDashboardBtn => By.XPath(""); //desktop only

        public By ClickMobileMoreBtn => By.XPath("//*[@id='more']"); // Mobile only

        public By ClickMobileYourProfileLnk => By.XPath("//*[@id='mobile-more']/ul/li[1]/a");

        public By ClickMobileYourProfileContactLnk => By.XPath("//*[@id='navbuttons']/li[2]/a");

        public By EnterMobileYourProfileStreetNameTxt => By.XPath("//*[@id='streetname']");

        public By ClickMobileYourProfileSaveBtn => By.XPath("//*[@id='submit-2']");

        public By ClickMobileDashboardLnk => By.XPath("//*[@id='dashboard']");

        public By ClickDesktopYourDashboardLnk => By.XPath("");

        public By ClickMarketSurveyCloseBtn => By.XPath(""); // desktop only

    }


    //RL-Desktop...............................................................................................................................................................

    public class HomeDetailsDesktopRLLoc : IHomeDetails
    {

        //Enter Money amount

        public By EnterAmount => By.XPath("//*[@id='selPolSections - container']/div[1]/table/tbody/tr[2]/td[2]/div");

        //Create client link
        public By CreateClient => By.XPath(".//*[@id='content']/p[7]/a");

        //Old Product Link
        public By OldProduct => By.XPath(".//*[@id='clientlist']/table/tbody/tr[32]/td");

        //Make Button
        public By ReturnerSingle => By.XPath(".//*[@id='returner-clean-first-advance']/td[1]/button");

        //First Email
        public By FetchEmailId => By.XPath(".//*[@id='returner-clean-first-advance']/td[2]/div");

        //Second Email
        public By FetchEmailId2 => By.XPath(".//*[@id='returner-clean-first-advance']/td[2]/div[2]");

        public By FetchEmailIdSACCOutGrace => By.XPath("//*[@id='sacc-failed-payment-outside-grace']/td[2]/div/a[1]");

        public By FetchEmailIDSACCInGrace => By.XPath("//*[@id='sacc-failed-payment-inside-grace']/td[2]/div[1]/a[1]");

        public By DavidClientBtn => By.XPath(".//*[@id='clientlist']/table/tbody/tr[67]/td");

        public By FetchEmailIDDavidSACCOutGrace => By.XPath(".//*[@id='david-MemberFailedFirstPayOutGrace']/td[2]/div/a[1]");

        public By ClickDavidSACCOurGraceMakeBtn => By.XPath("//*[@id='david-MemberFailedFirstPayOutGrace']/td[1]/button");

        //Login button in the debug page
        public By DebugLogibBtn => By.XPath(".//li[@id='linkMenuLogin']");

        //popup login button
        public By PopupLogibBtn => By.XPath("//span[text()='Login']");

        //Username Textbox
        public By LoginUsername => By.XPath(".//input[@id='username']");

        //Password Textbox
        public By LoginPassword => By.XPath(".//input[@id='password']");

        //Login Button after giving username and password
        public By LoginButton => By.XPath(".//*[@class='button']");

        //Login Button in the menu bar
        public By btnLogin => By.ClassName("nav-login");
        //[@id='linkMenuLogin']/a");

        //Request Money
        public By RequestMoney => By.XPath(".//*[@id='dashTop']/div/a/span[contains(text(),'Request Money')]");

        //Start Application Button
        public By btnstartApplication => By.XPath("//*[@id='btnContinueNCCP_Returner']");

        //Apply button in the menu bar
        public By linkMenuApply => By.XPath(".//div[@class='width-100']/nav/a[contains(text(),'Apply')]");

        //Nimble Logo
        public By NimbleLogo => By.XPath(".//*[@id='header-logo']/a/amp-img/img");

        //BtnHideShowDebug
        public By BtnHideShowDebug => By.XPath(".//*[@id='debug-show']");

        //BtnPassAllNobs
        public By BtnPassAllNobs => By.XPath(".//*[@id='debugonlybuttons']/button[contains(text(),'Pass All (no bs)')]");

        //For closing the pol popup
        public By cancelPurposeLoanDialog => By.XPath(".//button[@id='cancelPolDlg']");

        public By DavidTestClients => By.XPath("//*[@id='clientlist']/table/tbody/tr[67]/td");

        public By GracePeriodEmail => By.XPath("//*[@id='david-MemberFailedFirstPayOutGrace']/td[2]/div/a[1]");

        public By GracePeriodMakeButton => By.XPath("//*[@id='david-MemberFailedFirstPayOutGrace']/td[1]/button");

        public By ClickCreateClientGracePeriodBtn => By.XPath("//*[@id='clientlist']/table/tbody/tr[98]/td");

        public By ClickCreateClientSACCOutGraceBtn => By.XPath("//*[@id='sacc-failed-payment-outside-grace']/td[1]/button");

        public By ClickCreateClientSACCInGraceBtn => By.XPath("//*[@id='sacc-failed-payment-inside-grace']/td[1]/button");

        public By ClickMakeRepaymentBtn => By.XPath("//*[@id='member-message']/div[2]/a/span");

        public By CheckRepaymentDirectDebitChkbx => By.XPath("//*[@id='paymentOptions']/table/tbody/tr[1]/td[1]/div");

        public By CheckRepaymentDebitCardChkbx => By.XPath("//*[@id='ccRadio']/td[1]/div");

        public By CheckRepaymentBPAYChkbx => By.XPath("//*[@id='paymentOptions']/table/tbody/tr[3]/td[1]/div");

        public By CheckRepaymentEFTChkbx => By.XPath("//*[@id='paymentOptions']/table/tbody/tr[4]/td[1]/div");

        public By ClickRepaymentContinueBtn => By.XPath("//*[@id='btnSelectPaymentOption']");

        public By ClickRepaymentDirectDebitBtn => By.XPath("//*[@id='btnDD']");

        public By ClickRepaymentDebitCardBtn => By.XPath("//*[@id='btnCC']");

        public By WaitForPaymentpage => By.XPath("//*[contains(text(),'Thanks for your payment')]");

        public By ClickRepaymentBPAYBtn => By.XPath("//*[@id='btnBPay']");

        public By ClickRepaymentEFTBtn => By.XPath("//*[@id='btnEFT']");

        public By EnterRepaymentNameOnCardTxt => By.XPath("//*[@id='cc_name']");

        public By EnterRepaymentCardNumberTxt => By.XPath("//*[@id='cc_number']");

        public By EnterRepaymentExpiryTxt => By.XPath("//*[@id='cc_expiry']");

        public By EnterRepaymentSecurityTxt => By.XPath("//*[@id='cc_security_code']");

        public By ClickRepaymentBackBtn => By.XPath(" //*[@id='btnConfirmBack']");

        public By ClickRepaymentConfirmBtn => By.XPath("//*[@id='btnConfirm']");

        public By ClickRepaymentDebitCardDoneBtn => By.XPath("//*[@id='btnCCDone']");

        public By ClickMemberAreaEditProfileLnk => By.XPath("//*[@id='member-leftnav']/ul[5]/li/a");

        public By ClickEditProfileContactDetailsBtn => By.XPath("//*[@id='contactDetailsHeader']/span");

        public By EnterEditProfileStreetNameTxt => By.XPath("//*[@id='streetname']");

        public By ClickEditProfileSaveBtn => By.XPath("//*[@id='SaveButton']");

        public By ClickEditProfileLoanDashboardBtn => By.XPath("//*[@id='member-maincontent']/div/div/a");

        public By ClickMobileMoreBtn => By.XPath(""); // Mobile only

        public By ClickMobileYourProfileLnk => By.XPath(""); // Mobile only

        public By ClickMobileYourProfileContactLnk => By.XPath(""); // Mobile only

        public By EnterMobileYourProfileStreetNameTxt => By.XPath(""); // Mobile only

        public By ClickMobileYourProfileSaveBtn => By.XPath(""); // Mobile only

        public By ClickMobileDashboardLnk => By.XPath(""); // Mobile only

        public By ClickDesktopYourDashboardLnk => By.XPath("//*[@id='linkMenuMemberHome']");

        public By ClickMarketSurveyCloseBtn => By.XPath("(//button[@type='button' and @title='Close']//span[text()='Close'])[1]");
            //html/body/div[6]/div[1]/button/span[1]");

    }
}
