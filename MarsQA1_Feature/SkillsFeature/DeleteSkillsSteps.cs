using MarsQA1.SpecFlowPages.Pages;
using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace MarsQA1.SkillsFeature
{
    [Binding]
    public class DeleteSkillsSteps
    {
        [Given(@"I click on SkillTab for delete")]
        public void GivenIClickOnSkillTabForDelete() => Skills.SelectSkillTab();

        [When(@"I click on cross icon")]
        public void WhenIClickOnCrossIcon()
        {
            Skills.DeleteSkill();
        }
        
        [Then(@"""(.*)"" message is displayed")]
        public void ThenMessageIsDisplayed(string Expected)
        {
            Thread.Sleep(2000);
            Assert.AreEqual(Expected, Language.Alertpopup.Text);
        }
    }
}
