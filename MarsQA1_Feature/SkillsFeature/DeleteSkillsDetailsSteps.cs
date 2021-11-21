using MarsQA1.SpecFlowPages.Pages;
using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace MarsQA1.SkillsFeature
{
    [Binding]
    public class SellerSkillsDetailsSteps
    {
        [Given(@"I click on Skill Tab")]
        public void GivenIClickOnSkillTab() => Skills.SelectSkillTab();
       
        
        [When(@"I click on deletebutton")]
        public void WhenIClickOnDeletebutton()
        {
            Skills.DeleteSkill();
        }

        [Then(@"Skill details are deleted successfully and message displayed ""(.*)""\.")]
        public void ThenSkillDetailsAreDeletedSuccessfullyAndMessageDisplayed_(string Expected)
        {
            Thread.Sleep(2000);
            Assert.AreEqual(Expected, Language.Alertpopup.Text);
        }

    }
}
