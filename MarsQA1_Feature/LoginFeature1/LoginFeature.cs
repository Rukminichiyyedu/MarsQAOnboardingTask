using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;


namespace MarsQA1.LoginFeature1
{
    public partial class LoginFeature
    {

        private TechTalk.SpecFlow.ITestRunner testRunner;
        private RemoteWebDriver driver;

        public LoginFeature(RemoteWebDriver driver)
        {
            this.driver = driver;
        }

        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Login", "\tCheck if login functionality works", null);
            testRunner.OnFeatureStart(featureInfo);
        }
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        public virtual void TestInitialize()
        {
        }
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }

        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart();
        }

        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        public virtual void LoginUserAsAdministrator()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Login user as Seller","Test", new string[] {
                        "mytag"},null);
            testRunner.Given("user is on Application landing page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "UserName",
                        "Password"});
            table1.AddRow(new string[] {
                        "rukku.chiyyedu970@gmail.com",
                        "Testing123"});
            testRunner.And("I enter username and password", ((string)(null)), table1, "And ");
            testRunner.And("I click login", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("I should see user logged in to the application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();

        }
    }
}