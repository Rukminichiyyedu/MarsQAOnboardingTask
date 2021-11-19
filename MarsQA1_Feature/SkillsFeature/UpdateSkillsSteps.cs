using MarsQA_1.SpecflowPages.Pages;
using MarsQA1.SpecFlowPages.Pages;
using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace MarsQA1.SkillsFeature
{
    [Binding]
    public class UpdateSkillsSteps
    {
        [Given(@"I click on SkillTab for update")]
        public void GivenIClickOnSkillTabForUpdate() => Skills.SelectSkillTab();

        [Given(@"I click on Pen icon")]
        public void GivenIClickOnPenIcon()
        {
            Skills.ClickPenIcon();
        }
        
        [Given(@"I update '(.*)' in Skills")]
        public void GivenIUpdateInSkills(string Java)
        {

            Skills.SkillUpdate(Java);
        }
        
        [Given(@"I select '(.*)' Level")]
        public void GivenISelectLevel(string Intermediate)
        {
            Skills.LevelUpdate(Intermediate);
        }
        
        [When(@"I click Update ActionButton")]
        public void WhenIClickUpdateActionButton()
        {
            Skills.SaveUpdateSkill();
        }
        
        [Then(@"""(.*)"" message displayed")]
        public void ThenMessageDisplayed(string Expected)
        {
            Thread.Sleep(2000);
            Assert.AreEqual(Expected, Certificate.Alertpopup.Text);
        }
    }
}
