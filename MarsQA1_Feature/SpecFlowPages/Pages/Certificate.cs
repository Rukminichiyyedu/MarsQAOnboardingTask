using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MarsQA1.SpecFlowPages.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace MarsQA_1.SpecflowPages.Pages
{
    public class Certificate
    {
        // public string CertificateOrAward { get; set; }
        // public string CertifiedFrom { get; set; }
        public int Year { get; set; }
        // public string CertificationMessage { get; set; }




        private static IWebElement CertificationsTab => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
        private static IWebElement AddNewButton => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
        private static IWebElement CertifiedTextField => Driver.driver.FindElement(By.Name("certificationName"));
        private static IWebElement CertifiedFromTextField => Driver.driver.FindElement(By.Name("certificationFrom"));
        private static IWebElement SelectYear => Driver.driver.FindElement(By.Name("certificationYear"));

        private static IWebElement AddButtonClick => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));

        private static IWebElement UpdateAction => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[1]/i"));
      //private static IWebElement UpdateAction => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
        private static IWebElement CertNameUpdate => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/div/div[1]/input"));
        //private static IWebElement UpdateLanguage => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
        //private static IWebElement CertNameUpdate => Driver.driver.FindElement(By.Name("certificationName"));
        private static IWebElement CertFromupdate => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div/div[2]/div/table/tbody/tr/td/div/div/div[2]/input"));

        private static IWebElement UpdateYear => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div/div[2]/div/table/tbody/tr/td/div/div/div[3]/select"));

        private static IWebElement SaveUpdate => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/span/input[1]"));

        private static IWebElement Delete => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[2]/i"));

        private static string Alertpopuppath = "//div[@class='ns-box-inner']";
        public static IWebElement Alertpopup => Driver.driver.FindElement(By.XPath(Alertpopuppath));


        public static void SelectCertificationTab()
        {
            CertificationsTab.Click();
            Thread.Sleep(1000);
        }
        public static void ClickAddNew()
        {
            AddNewButton.Click();
        }

        public static void CertificateName(string language)
        {
            CertifiedTextField.SendKeys(language);
        }

        public static void CertifiedFrom(string name)
        {
            CertifiedFromTextField.SendKeys(name);
        }


        public static void CertificateYear(string Year)
        {
            //create select element object 
            var yearselectElement = new SelectElement(SelectYear);

            // select by text
            yearselectElement.SelectByText(Year);
        }

        public static void ClickAdd()
        {
            AddButtonClick.Click();
        }

        public static void UpdatePenIcon()
        {

            UpdateAction.Click();
            //Thread.Sleep(1000);
        }

        public static void UpdateCertificate(string Cname)
        {
            CertNameUpdate.Click();
            CertNameUpdate.Clear();
            CertNameUpdate.SendKeys(Cname);

        }

        public static void FromTextFieldUpdate(string name)
        {
            CertFromupdate.Click();
            CertFromupdate.Clear();
            CertFromupdate.SendKeys(name);

        }

        public static void ModifyCertificateYear(string Year)
        {
            //create select element object 
            var yearselectElement = new SelectElement(UpdateYear);

            // select by text
            yearselectElement.SelectByText(Year);
        }

        public static void ClickUpdate()
        {
            SaveUpdate.Click();
            Thread.Sleep(2000);
        }

        public static void DeleteCertification()

        {
            Thread.Sleep(2000);
            Delete.Click();
        }

    }
}