using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace MarsQA1.CertificateFeature
{
    [Binding]
    public class UpdateCertificationSteps
    {
        [Given(@"I click on Update button")]
        public void GivenIClickOnUpdateButton() => Certificate.SelectCertificationTab();
        
        [Given(@"Enter '(.*)' in Certificate/Award field")]
        public void GivenEnterInCertificateAwardField(string ISTQBCertificate)
        {
            Certificate.UpdateCertificate(ISTQBCertificate);
        }
        
        [Given(@"Enter '(.*)' in Certified From field")]
        public void GivenEnterInCertifiedFromField(string Testing)
        {
            Certificate.FromTextFieldUpdate(Testing);
        }
        
        [Given(@"Select '(.*)' in Year of Graduation field\.")]
        public void GivenSelectInYearOfGraduationField_(string Year)
        {
            Certificate.ModifyCertificateYear(Year);
        }
        
        [When(@"Click on '(.*)' action button\.")]
        public void WhenClickOnActionButton_(string p0)
        {
            Certificate.ClickUpdate();
        }
        
        [Then(@"Certification details should updated successfully and a message  ""(.*)"" should display on top of your screen\.")]
        public void ThenCertificationDetailsShouldUpdatedSuccessfullyAndAMessageShouldDisplayOnTopOfYourScreen_(string Expected)
        {
            Thread.Sleep(2000);
            Assert.AreEqual(Expected, Certificate.Alertpopup.Text);
        }
    }
}
