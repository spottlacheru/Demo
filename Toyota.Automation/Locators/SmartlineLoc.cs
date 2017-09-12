using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toyota.Automation.Locators
{

    public interface ISmartLineLoc
    {
        By HomeLoans { get; }

        By firsthomebuyers { get; }

        By smartlineadviser { get; }

        By firstname { get; }

        By lastname { get; }

        By phonenumber { get; }

        By postcode { get; }

        By emailid { get; }

        By subscribe { get; }

        By submit { get; }

        By errormessage { get; }

    }

    public class SmartLineMobileLoc : ISmartLineLoc
    {
        public By HomeLoans => By.XPath(".//*[@id='menu-item-33']/a");

        public By firsthomebuyers => By.XPath(".//ul[@id='menu-secondary']//ul[@class='sub-menu']/li/a[text()='First Home Buyers']");

        public By smartlineadviser => By.XPath(".//a[@href='/how-we-help-you/talk-adviser/']");

        public By firstname => By.XPath(".//div[@class='half']/input[@name='FirstName']");

        public By lastname => By.XPath(".//div[@class='half']/input[@name='Surname']");

        public By phonenumber => By.XPath(".//div[@class='half']/input[@name='Phone']");

        public By postcode => By.XPath(".//div[@class='half']/input[@name='PostCode']");

        public By emailid => By.XPath(".//div[@class='half']/input[@name='Email']");

        public By subscribe => By.XPath(".//*[@id='subscribe']");

        public By submit => By.XPath(".//input[@value='Submit']");

        public By errormessage => By.XPath(".//div[@class='failed'][@style='display: block;']");

    }

    public class SmartLineDesktopLoc : ISmartLineLoc
    {
        public By HomeLoans => By.XPath(".//*[@id='menu-item-33']/a");

        public By firsthomebuyers => By.XPath(".//ul[@id='menu-secondary']//ul[@class='sub-menu']/li/a[text()='First Home Buyers']");

        public By smartlineadviser => By.XPath(".//a[@href='/how-we-help-you/talk-adviser/']");

        public By firstname => By.XPath(".//div[@class='half']/input[@name='FirstName']");

        public By lastname => By.XPath(".//div[@class='half']/input[@name='Surname']");

        public By phonenumber => By.XPath(".//div[@class='half']/input[@name='Phone']");

        public By postcode => By.XPath(".//div[@class='half']/input[@name='PostCode']");

        public By emailid => By.XPath(".//div[@class='half']/input[@name='Email']");

        public By subscribe => By.XPath(".//*[@id='subscribe']");

        public By submit => By.XPath(".//input[@value='Submit']");

        public By errormessage => By.XPath(".//div[@class='half']//div[@class='failed']");

    }


}
