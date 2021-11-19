using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace MarsQA1.LoginFeature1
{
    [Binding]
    public class LoginFeatureSteps
    {
        private RemoteWebDriver _driver;

        public LoginFeatureSteps(RemoteWebDriver driver) => _driver = driver;

        [Given(@"I navigate to application")]
        public void GivenINavigateToApplication()
        {
            _driver.Navigate().GoToUrl("https://Localhost:5000");
        }
        
        [Given(@"I enter username and password")]
        public void GivenIEnterUsernameAndPassword(Table table)
        {
            dynamic data = table.CreateDynamicInstance();

            _driver.FindElement(By.Name("UserName")).SendKeys((String)data.UserName);
            _driver.FindElement(By.Name("Password")).SendKeys((String)data.Password);
 
        }
        
        [Given(@"I click login")]
        public void GivenIClickLogin()
        {
            Thread.Sleep(1000);
            _driver.FindElement(By.Name("Login")).Submit();
            Thread.Sleep(2000);
        }
        
        [Then(@"I should see user logged in to the application")]
        public void ThenIShouldSeeUserLoggedInToTheApplication()
        {
            var element = _driver.FindElement(By.XPath("//h1[contains(text(),'Execute Automation Selenium')]"));
            Assert.Multiple(() =>
            {
                //Assert.That(element.Text, Is.Null, "Header text not found !!!");
                Assert.That(element.Text, Is.Null, "Header text not found !!!");
            });
        }
    }
}
