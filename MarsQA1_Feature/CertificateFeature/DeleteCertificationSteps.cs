using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace MarsQA1.CertificateFeature
{
    [Binding]
    public class DeleteCertificationSteps
    {
        [Given(@"I select '(.*)' Certificate")]
        public void GivenISelectCertificateTab(string p0) => Certificate.SelectCertificationTab();

        [When(@"I click on delete button")]
        public void WhenIClickOnDeleteButton()
        {
            Certificate.DeleteCertification();
        }
        
        [Then(@"Certification details are deleted successfully and a message should display saying ""(.*)""")]
        public void ThenCertificationDetailsAreDeletedSuccessfullyAndAMessageShouldDisplaySaying(string Expected)
        {
            Thread.Sleep(2000);
            Assert.AreEqual(Expected, Certificate.Alertpopup.Text);
        }
    }
}
