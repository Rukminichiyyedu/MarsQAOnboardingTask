using System;
using TechTalk.SpecFlow;

namespace MarsQA1.EducationFeature
{
    [Binding]
    public class SellerAddEducationSteps
    {
        [Given(@"Seller enter Education Country as ""(.*)""")]
        public void GivenSellerEnterEducationCountryAs(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"Seller enter University as ""(.*)""")]
        public void GivenSellerEnterUniversityAs(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"Seller enter Title as ""(.*)""")]
        public void GivenSellerEnterTitleAs(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"Seller enter Degree as ""(.*)""")]
        public void GivenSellerEnterDegreeAs(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"Seller enter Graduation year as ""(.*)""")]
        public void GivenSellerEnterGraduationYearAs(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Seller clicks on Add button on AddEducation page")]
        public void WhenSellerClicksOnAddButtonOnAddEducationPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Education should be added to the profile\.The Alert message ""(.*)"" should pop up on right side of the screen\.")]
        public void ThenEducationShouldBeAddedToTheProfile_TheAlertMessageShouldPopUpOnRightSideOfTheScreen_(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
