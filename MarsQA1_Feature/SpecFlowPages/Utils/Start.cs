using MarsQA1.SpecFlowPages.Helpers;
using MarsQA1.SpecFlowPages.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace MarsQA_1.Utils
{
    [Binding]
    public class Start : Driver
    {

        [BeforeScenario]
        public void Setup()
        {
                
            //launch the browser
            Initialize();

            string path = AppDomain.CurrentDomain.BaseDirectory;
            ExcelLibHelper.PopulateInCollection( @"C:\Users\Rukmi\OneDrive\Desktop\MarsQA1_Feature\MarsQA1_Feature\SpecFlowTests\Data\Mars.xlsx", "Credentials");

            //ExcelLibHelper.PopulateInCollection(@" C:\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\Mars.xlsx", "Credentials");


            //call the SignIn class
            SignIn.SigninStep();
        }

        [AfterScenario]
        public void TearDown()
        {

            // Screenshot
            //string img = SaveScreenShotClass.SaveScreenshot(Driver.driver, "Report");
            //test.Log(LogStatus.Info, "Snapshot below: " + test.AddScreenCapture(img));
            //Close the browser
            Close();

            // end test. (Reports)
            //  Extent.EndTest(test);

            // calling Flush writes everything to the log file (Reports)
            //   Extent.Flush();


        }
    }
}