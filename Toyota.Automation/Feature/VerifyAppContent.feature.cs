﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Toyota.Automation.Feature
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Content")]
    public partial class ContentFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "VerifyAppContent.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Content", "\tVerify the display content in all the web pages", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify display content")]
        [NUnit.Framework.CategoryAttribute("smoke_test")]
        public virtual void VerifyDisplayContent()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify display content", new string[] {
                        "smoke_test"});
#line 5
this.ScenarioSetup(scenarioInfo);
#line 6
 testRunner.Given("The User has Launched URL", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 7
 testRunner.When("The User click on \"Home\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 8
 testRunner.Then("The Page Navigates to \"Home\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 9
    testRunner.And("The User Sees \"Display\" image", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
    testRunner.And("The User Sees \"Details\" table", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify login")]
        [NUnit.Framework.CategoryAttribute("smoke_test")]
        [NUnit.Framework.CategoryAttribute("Browser:Chrome")]
        public virtual void VerifyLogin()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify login", new string[] {
                        "smoke_test",
                        "Browser:Chrome"});
#line 15
this.ScenarioSetup(scenarioInfo);
#line 16
 testRunner.Given("The User has Launched URL", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 17
 testRunner.When("The User click on Apply button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 18
 testRunner.Then("The Page Navigates to \"Login\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 19
    testRunner.And("The User Sees StartApplication button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
    testRunner.And("The User Selects LoanAmount slider", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
    testRunner.Then("The User enters LoanAmount entry", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 22
    testRunner.Then("The User click on Continue button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
