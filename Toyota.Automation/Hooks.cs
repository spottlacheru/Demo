using BoDi;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Toyota.Automation
{

    [Binding]
    public class Hooks
    {

        private readonly IObjectContainer _objContainer;
        private IWebDriver _driver;

        public Hooks(IObjectContainer objcontainer)
        {
            _objContainer = objcontainer;
        }

        [BeforeScenario]
        public void TestInitialize()
        {
            DebugCloudAndroid();
            DebugCloudChrome();
            DebugCloudFireFox();
            DebugCloudIE();
            DebugCloudIOS();
            DebugLocalAndroid();
            DebugLocalChrome();
            DebugLocalFireFox();
            DebugLocalIE();

            _objContainer.RegisterInstanceAs<IWebDriver>(_driver);
        }

        [AfterScenario]
        public void TestCleanUp()
        {
            _driver.Quit();
        }

        [Conditional("DebugLocalChrome")]
        public void DebugLocalChrome()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
        }

        [Conditional("DebugLocalFireFox")]
        public void DebugLocalFireFox()
        {
            _driver = new FirefoxDriver();
        }

        [Conditional("DebugLocalIE")]
        public void DebugLocalIE()
        {
           
        }

        [Conditional("DebugLocalAndroid")]
        public void DebugLocalAndroid()
        {
            DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities.SetCapability(MobileCapabilityType.BrowserName, MobileBrowserType.Chrome);
            capabilities.SetCapability(MobileCapabilityType.DeviceName, "");
            capabilities.SetCapability(MobileCapabilityType.PlatformName, MobilePlatform.Android);
            capabilities.SetCapability("newCommandTimeout", TimeSpan.FromSeconds(120));
            _driver = new RemoteWebDriver(new Uri("http://127.0.0.1:4723/wd/hub"), capabilities);
            _driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(120));
        }

        [Conditional("DebugCloudChrome")]
        public void DebugCloudChrome()
        {
            DesiredCapabilities desiredCap = DesiredCapabilities.Chrome();
            ChromeOptions chrOpts = new ChromeOptions();
            chrOpts.AddArguments("test-type");
            chrOpts.AddArguments("--disable-extensions");
            //chrOpts.AddArgument("incognito");
            //desiredCap.SetCapability(ChromeOptions.Capability, chrOpts);    // updated                   
            desiredCap = (DesiredCapabilities)chrOpts.ToCapabilities();

            desiredCap.SetCapability("browserstack.user", "sunil406"); // browser stack username
            desiredCap.SetCapability("browserstack.key", "v6NkgMhsa78ukX7gcLAQ"); // browser stack account key
            desiredCap.SetCapability("platform", "WINDOWS");
            desiredCap.SetCapability("os", "WINDOWS");
            desiredCap.SetCapability("os_version", "8");
            // desiredCap.SetCapability("build", Environment.GetEnvironmentVariable("BS_AUTOMATE_BUILD"));
            desiredCap.SetCapability("browserstack.debug", true);
            // string strTestName = TestContext.CurrentContext.Test.Name.ToString();
            desiredCap.SetCapability("project", Environment.GetEnvironmentVariable("BS_AUTOMATE_PROJECT"));
            desiredCap.SetCapability("build", Environment.GetEnvironmentVariable("BS_AUTOMATE_BUILD"));

            _driver = new RemoteWebDriver(
              new Uri("http://hub-cloud.browserstack.com/wd/hub/"), desiredCap);

            _driver.Manage().Window.Maximize();

        }

        [Conditional("DebugCloudFireFox")]
        public void DebugCloudFireFox()
        {
            DesiredCapabilities desiredCap = DesiredCapabilities.Firefox();

            desiredCap.SetCapability("browserstack.user", "sunil406"); // browser stack username
            desiredCap.SetCapability("browserstack.key", "v6NkgMhsa78ukX7gcLAQ"); // browser stack account key
            desiredCap.SetCapability("platform", "WINDOWS");
            desiredCap.SetCapability("os", "WINDOWS");
            desiredCap.SetCapability("os_version", "8");
            // desiredCap.SetCapability("build", Environment.GetEnvironmentVariable("BS_AUTOMATE_BUILD"));
            desiredCap.SetCapability("browserstack.debug", true);
            // string strTestName = TestContext.CurrentContext.Test.Name.ToString();
            desiredCap.SetCapability("project", Environment.GetEnvironmentVariable("BS_AUTOMATE_PROJECT"));
            desiredCap.SetCapability("build", Environment.GetEnvironmentVariable("BS_AUTOMATE_BUILD"));

            _driver = new RemoteWebDriver(
              new Uri("http://hub-cloud.browserstack.com/wd/hub/"), desiredCap);

            _driver.Manage().Window.Maximize();

        }

        [Conditional("DebugCloudIE")]
        public void DebugCloudIE()
        {
        }

        [Conditional("DebugCloudAndroid")]
        public void DebugCloudAndroid()
        {
            DesiredCapabilities capability = DesiredCapabilities.Android();
            ChromeOptions chrOpts = new ChromeOptions();
            chrOpts.AddArguments("test-type");
            chrOpts.AddArguments("--disable-extensions");
            chrOpts.AddArgument("incognito");
            chrOpts.AddArgument("no-sandbox");
            capability = (DesiredCapabilities)chrOpts.ToCapabilities();
            capability.SetCapability("browserName", "android");
            capability.SetCapability("browserstack.user", "sunil406"); // browser stack username
            capability.SetCapability("browserstack.key", "v6NkgMhsa78ukX7gcLAQ"); // browser stack account key
            capability.SetCapability("deviceName", "Samsung Galaxy S5");
            capability.SetCapability("browserName", "chrome");
            capability.SetCapability("platform", MobilePlatform.Android);
            capability.SetCapability("browserstack.debug", true);
            capability.SetCapability("project", Environment.GetEnvironmentVariable("BS_AUTOMATE_PROJECT"));
            capability.SetCapability("build", Environment.GetEnvironmentVariable("BS_AUTOMATE_BUILD"));
            capability.SetCapability("browserstack.localIdentifier", Environment.GetEnvironmentVariable("BROWSERSTACK_LOCAL_IDENTIFIER"));
            capability.SetCapability("deviceReadyTimeout", TimeSpan.FromSeconds(200));
            capability.SetCapability("androidDeviceReadyTimeout", TimeSpan.FromSeconds(200));
            capability.SetCapability("avdLaunchTimeout", TimeSpan.FromSeconds(200));
            capability.SetCapability("appWaitDuration", TimeSpan.FromSeconds(200));
            capability.SetCapability("avdReadyTimeout", TimeSpan.FromSeconds(200));
            capability.SetCapability("idleTimeout", 300);
            _driver = new RemoteWebDriver(new Uri("http://hub-cloud.browserstack.com/wd/hub/"), capability, TimeSpan.FromSeconds(200));
            _driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(200));


        }

        [Conditional("DebugCloudIOS")]
        public void DebugCloudIOS()
        {
            DesiredCapabilities capability = DesiredCapabilities.IPhone();
            capability.SetCapability("browserstack.user", "sunil406"); // browser stack username
            capability.SetCapability("browserstack.key", "v6NkgMhsa78ukX7gcLAQ"); // browser stack account key
            capability.SetCapability("platform", "MAC");
            capability.SetCapability("browserName", "iPhone");
            capability.SetCapability("browserstack.debug", true);
            capability.SetCapability("device", "iPhone 5");
            capability.SetCapability("project", Environment.GetEnvironmentVariable("BS_AUTOMATE_PROJECT"));
            capability.SetCapability("build", Environment.GetEnvironmentVariable("BS_AUTOMATE_BUILD"));
            capability.SetCapability("browserstack.localIdentifier", Environment.GetEnvironmentVariable("BROWSERSTACK_LOCAL_IDENTIFIER"));
            capability.SetCapability("newCommandTimeout", TimeSpan.FromSeconds(120));
            capability.SetCapability("idleTimeout", TimeSpan.FromSeconds(120));
            _driver = new RemoteWebDriver(new Uri("http://hub-cloud.browserstack.com/wd/hub/"), capability, TimeSpan.FromSeconds(120));
        }


    }
}
