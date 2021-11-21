using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace MarsQA1.CertificateFeature
{
    [Binding]
    public class DeleteCertificateSteps
    {
        [Given(@"I select Certification tab for delete")]
        public void GivenISelectCertificationTabForDelete() => Certificate.SelectCertificationTab();
        
        
        [Given(@"I select '(.*)' Certificate to delete")]
        public void GivenISelectCertificateToDelete(string p0)
        {
            Certificate.DeleteCertification();
        }
        
        [Then(@"Certification details are deleted successfully and message displayed ""(.*)""")]
        public void ThenCertificationDetailsAreDeletedSuccessfullyAndMessageDisplayed(string Expected)
        {
            Thread.Sleep(2000);
            Assert.AreEqual(Expected, Certificate.Alertpopup.Text);
        }
    }
}
