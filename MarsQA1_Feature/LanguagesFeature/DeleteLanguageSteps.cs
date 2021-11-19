using MarsQA1.SpecFlowPages.Pages;
using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace MarsQA1.LanguagesFeature
{
    [Binding]
    public class DeleteLanguageSteps
    {
        [Given(@"I select '(.*)' language to delete")]
        public void GivenISelectLanguageToDelete(string p0)
        {
            Language.ClickDeleteButton();
        }
        
        [Then(@"Language is deleted successfully and pop up message displayed ""(.*)"" on the top right of web page\.")]
        public void ThenLanguageIsDeletedSuccessfullyAndPopUpMessageDisplayedOnTheTopRightOfWebPage_(string Expected)
        {
            Thread.Sleep(2000);
            Assert.AreEqual(Expected, Language.Alertpopup.Text);
        }
    }
}
