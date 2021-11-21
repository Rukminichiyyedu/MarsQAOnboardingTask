using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using MarsQA1.SpecFlowPages.Pages;
using TechTalk.SpecFlow.Assist;

namespace MarsQA1.LoginFeature1
{
    [Binding]
    public class LoginFeatureSteps
    {
        
        [Given(@"I click login")]
        public void GivenIClickLogin()
        {
            Thread.Sleep(1000);
            //SignIn.SigninStep();

        }
        
        //[Then(@"I should see user logged in to the application")]
        //public void ThenIShouldSeeUserLoggedInToTheApplication()
        //{
        //    var element = _driver.FindElement(By.XPath("//h1[contains(text(),'Execute Automation Selenium')]"));
        //    Assert.Multiple(() =>
        //    {
        //        //Assert.That(element.Text, Is.Null, "Header text not found !!!");
        //        Assert.That(element.Text, Is.Null, "Header text not found !!!");
        //    });
        //}
    }
}
