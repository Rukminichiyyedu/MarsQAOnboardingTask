using MarsQA1.SpecFlowPages.Pages;
using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace MarsQA1.LanguagesFeature
{
    [Binding]
    public class UpdateLanguageSteps
    {
        [Given(@"Seller click on Update Icon")]
        public void GivenSellerClickOnUpdateIcon()
        {
            Language.UpdateIcon();
        }
        
        [Given(@"I update Language as '(.*)'")]
        public void GivenIUpdateLanguageAs(string Hindi)
        {
            Language.UpdateLanguageName(Hindi);
        }
        
        [Given(@"I select level '(.*)'")]
        public void GivenISelectLevel(string Fluent)
        {
            Language.UpdateLevel(Fluent);
        }
        
        [When(@"click on Update button")]
        public void WhenClickOnUpdateButton()
        {
            Language.SaveActionButton();
        }
        
        [Then(@"Languageupdated successfully and pop up message displayed ""(.*)"" on the top right of web page\.")]
        public void ThenLanguageupdatedSuccessfullyAndPopUpMessageDisplayedOnTheTopRightOfWebPage_(string Expected)
        {
            Thread.Sleep(2000);
            Assert.AreEqual(Expected, Language.Alertpopup.Text);
        }
    }
}
