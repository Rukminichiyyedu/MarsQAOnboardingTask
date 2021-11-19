using MarsQA_1.SpecflowPages.Pages;
using MarsQA1.SpecFlowPages.Pages;
using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace MarsQA1.SkillsFeature
{
    [Binding]
    public class AddSkillsSteps
    {
        [Given(@"I click on SkillTab")]
        public void GivenIClickOnSkillTab() =>  Skills.SelectSkillTab();
          
        [Given(@"I click AddNew ActionButton")]
        public void GivenIClickAddNewActionButton()
        {
            Skills.ClickAddNew();
        }
        
        [Given(@"I enter '(.*)' in Skills")]
        public void GivenIEnterInSkills(string Automation)
        {

            Skills.NewSkill(Automation);
        }
        
        [Given(@"I select '(.*)' in Level")]
        public void GivenISelectInLevel(string Beginner)
        {
            Skills.SLevel(Beginner);
        }
        
        [When(@"I click Add ActionButton")]
        public void WhenIClickAddActionButton()
        {
            Skills.SaveSkill();
        }
        
        [Then(@"""(.*)"" message displayed\.")]
        public void ThenMessageDisplayed_(string Expected)
        {
            Thread.Sleep(2000);
            Assert.AreEqual(Expected, Certificate.Alertpopup.Text);
        }
    }
}
