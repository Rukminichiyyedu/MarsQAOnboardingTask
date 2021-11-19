using MarsQA1.SpecFlowPages.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MarsQA1.SpecFlowPages.Pages
{
        public class Skills
        {
            private static IWebElement SkillTab => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));

            private static IWebElement AddButton => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));

            private static IWebElement AddSkill => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));

            private static IWebElement AddSkillLevel => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));

            private static IWebElement SaveAddButton => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));

            private static string Alertpopuppath = "//div[@class='ns-box-inner']";
            public static IWebElement Alertpopup => Driver.driver.FindElement(By.XPath(Alertpopuppath));

            private static IWebElement UpdateButton => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));

            private static IWebElement UpdateSkill => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));

            private static IWebElement UpdateSkillLevel => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select"));

            private static IWebElement SaveUpdateButton => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));

            private static IWebElement DeleteButton => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));

            public static void SelectSkillTab()
            {
                Thread.Sleep(1000);
                SkillTab.Click();

            }

            public static void ClickAddNew()
            {
                AddButton.Click();
            }

            public static void NewSkill(string name)
            {
                AddSkill.SendKeys(name);
            }

            public static void SLevel(string Level)
            {
                AddSkillLevel.SendKeys(Level);

            }

            public static void SaveSkill()
            {
                SaveAddButton.Click();
            }

            public static void ClickPenIcon()
            {
                Thread.Sleep(1000);
                UpdateButton.Click();
            }

            public static void SkillUpdate(string name)
            {
                UpdateSkill.Click();
                UpdateSkill.Clear();
                UpdateSkill.SendKeys(name);
            }

            public static void LevelUpdate(string Level)
            {

                UpdateSkillLevel.SendKeys(Level);

            }

            public static void SaveUpdateSkill()
            {
                SaveUpdateButton.Click();
            }

            public static void DeleteSkill()
            {
                DeleteButton.Click();
            }

        }
    }

