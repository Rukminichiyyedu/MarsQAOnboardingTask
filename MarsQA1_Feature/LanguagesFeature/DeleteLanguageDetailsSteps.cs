using MarsQA1.SpecFlowPages.Pages;
using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace MarsQA1.LanguagesFeature
{
    [Binding]
    public class DeleteLanguageDetailsSteps
    {
        [Given(@"I click on languageTab")]
        public void GivenIClickOnLanguageTab() => Language.SelectLanguageTab();
        
        [When(@"I click on Delete button")]
        public void WhenIClickOnDeleteButton()
        {
            Language.ClickDeleteButton();
        }

        [Then(@"Language deleted successfully and pop up message displayed ""(.*)"" on the top right of web page\.")]
        public void ThenLanguageDeletedSuccessfullyAndPopUpMessageDisplayedOnTheTopRightOfWebPage_(string Expected)
        {
            Thread.Sleep(2000);
            Assert.AreEqual(Expected, Language.Alertpopup.Text);
        }

    }
}
