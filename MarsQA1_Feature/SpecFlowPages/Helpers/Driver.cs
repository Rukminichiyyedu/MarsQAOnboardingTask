using MarsQA1.SpecFlowPages.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsQA1.SpecFlowPages.Helpers
{
    public class Driver
    {
        
           
            public static IWebDriver driver { get; set; }

            public void Initialize()
            {
               
                driver = new ChromeDriver();
                TurnOnWait();

               
                driver.Manage().Window.Maximize();
            }

            public static string BaseUrl
            {
                get { return ConstantHelpers.Url; }
            }


            //Implicit Wait
            public static void TurnOnWait()
            {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            }

            public static void NavigateUrl()
            {
                driver.Navigate().GoToUrl(BaseUrl);
            }

            //Close the browser
            public void Close()
            {
                driver.Quit();
            }

                                  
        }
    }

