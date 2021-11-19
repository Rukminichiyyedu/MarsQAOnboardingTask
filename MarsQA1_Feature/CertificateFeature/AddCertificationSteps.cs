using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace MarsQA1.CertificateFeature
{
    [Binding]
    public class AddCertificationSteps
    {
        [Given(@"I select Certification tab")]
        public void GivenISelectCertificationTab() => Certificate.SelectCertificationTab(); 
        
        [Given(@"I click on AddNew button\.")]
        public void GivenIClickOnAddNewButton_()
        {
            Certificate.ClickAddNew();
        }
        
        [Given(@"I enter '(.*)' in Certificate/Award field")]
        public void GivenIEnterInCertificateAwardField(string TestingCertificate)
        {
            Certificate.CertificateName(TestingCertificate);
            
        }
        
        [Given(@"I enter '(.*)' in Certified  field")]
        public void GivenIEnterInCertifiedField(string Microsoft)
        {
            Certificate.CertifiedFrom(Microsoft);
        }
        
        [Given(@"I select '(.*)' in Year of Graduation field")] 
        public void GivenISelectInYearOfGraduationField(string varYear)
        {
            Certificate.CertificateYear(varYear);
        }
        
        [When(@"I click on '(.*)'  button")]
        public void WhenIClickOnButton(string p0)
        {
            Certificate.ClickAdd();
        }
        
        [Then(@"Certification details should add successfully and a message ""(.*)"" should display on top of your screen\.")]
        public void ThenCertificationDetailsShouldAddSuccessfullyAndAMessageShouldDisplayOnTopOfYourScreen_(string Expected)
        {
            Thread.Sleep(2000);
            Assert.AreEqual(Expected, Certificate.Alertpopup.Text);
        }
    }
}
