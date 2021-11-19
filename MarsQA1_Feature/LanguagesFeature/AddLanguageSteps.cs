using MarsQA1.SpecFlowPages.Pages;
using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace MarsQA1.LanguagesFeature
{
    [Binding]
    public class AddLanguageSteps
    {
        [Given(@"Seller select language tab")]
        public void GivenSellerSelectLanguageTab() => Language.SelectLanguageTab();
        
           
        [Given(@"Seller click on Add button")]
        public void GivenSellerClickOnAddButton()
        {
            Language.ClickAddNew();
        }
        
        [Given(@"Seller enter Language as '(.*)'")]
        public void GivenSellerEnterLanguageAs(string English)
        {
            Language.AddLanguageName(English);
        }
        
        [Given(@"select level '(.*)'")]
        public void GivenSelectLevel(string Basic)
        {
            Language.SelectLevel(Basic);
        }
        
        [When(@"click on Add button")]
        public void WhenClickOnAddButton()
        {
            Language.ClickAdd();
        }
        
        [Then(@"Language added successfully and pop up message displayed ""(.*)"" on the top right of web page\.")]
        public void ThenLanguageAddedSuccessfullyAndPopUpMessageDisplayedOnTheTopRightOfWebPage_(string Expected)
        {
            Thread.Sleep(2000);
            Assert.AreEqual(Expected, Language.Alertpopup.Text);
        }
    }
}
