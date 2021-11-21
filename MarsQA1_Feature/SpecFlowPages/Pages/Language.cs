using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MarsQA1.SpecFlowPages.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace MarsQA1.SpecFlowPages.Pages
{
    public class Language
    {
        /*public string LanguageName { get; set; }
        public string Level { get; set; }*/
        //public string Message { get; set; }

        private static IWebElement LanguageTab => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
        private static IWebElement AddNewActionButton => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
        private static IWebElement AddLanguage => Driver.driver.FindElement(By.Name("name"));
        private static IWebElement LanguageLevel => Driver.driver.FindElement(By.Name("level"));
        private static IWebElement AddActionButton => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));

        private static IWebElement LanguageRow => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[1]"));

        private static IWebElement LevelRow => Driver.driver.FindElement(By.XPath(" //*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[2]"));


        private static string Alertpopuppath = "//div[@class='ns-box-inner']";
        public static IWebElement Alertpopup => Driver.driver.FindElement(By.XPath(Alertpopuppath));
        private static IWebElement UpdateActionBttn => Driver.driver.FindElement(By.XPath("//*//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
        private static IWebElement UpdateLanguage => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
        private static IWebElement UpdateLanguageLevel => Driver.driver.FindElement(By.Name("level"));
        private static IWebElement SaveUpdate => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td/div/span/input[1]"));

        private static IWebElement Delete => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[2]/i"));

        public static void SelectLanguageTab()
        {
            Thread.Sleep(1000);
            LanguageTab.Click();
        }

        public static void ClickAddNew()
        {
            AddNewActionButton.Click();
        }

        public static void AddLanguageName(string language)
        {
            AddLanguage.SendKeys(language);
        }

        public static void SelectLevel(string Level)
        {
            LanguageLevel.SendKeys(Level);

        }

        public static void ClickAdd()
        {
            AddActionButton.Click();
        }

        public static void UpdateIcon()
        {
            Thread.Sleep(1000);
            UpdateActionBttn.Click();
            //Thread.Sleep(1000);
        }

        public static void UpdateLanguageName(string language)
        {
            UpdateLanguage.Click();
            UpdateLanguage.Clear();
            UpdateLanguage.SendKeys(language);

        }

        public static void UpdateLevel(string level)
        {
            UpdateLanguageLevel.SendKeys(level);
        }

        public static void SaveActionButton()
        {
            SaveUpdate.Click();
            Thread.Sleep(1000);
        }

        public static void ClickDeleteButton()
        {
            Thread.Sleep(2000);
            Delete.Click();
        }

        /* public void PopupMessage()
         {
             Message = Alertpopup.Text;
         }*/

        /* public static void ViewLanguageDetails(String language, String lvl)
         {
             Thread.Sleep(2000);
             Assert.AreEqual(language, LanguageRow.Text);
             Assert.AreEqual(lvl, LevelRow.Text);
         }*/



    }
}