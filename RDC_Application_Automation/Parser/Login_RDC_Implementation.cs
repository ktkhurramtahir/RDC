using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Interactions;
using TechTalk.SpecFlow.Assist;
//using NUnit.Framework;
using System.Configuration;
using System.IO;
using NLog;
using System.Diagnostics;
using System.Drawing.Imaging;

namespace RDC_Application_Automation.Parser
{
    [Binding]
    class Login_RDC_Implementation : DriverClass
    {
        Logger logger = LogManager.GetLogger("");


        [Given(@"Go to the URL of RDC")]
        public void GivenGoToTheURLOfRDC()
        {
            //new line added
            // one more commit
            string URL = System.Configuration.ConfigurationSettings.AppSettings["app_url"];
            string App_Version = System.Configuration.ConfigurationSettings.AppSettings["app_version"];
            logger.Debug("Current code is running for" + App_Version);
            logger.Debug("******************************");
            driver.Navigate().GoToUrl(URL);
            driver.Manage().Window.Maximize();
            System.Threading.Thread.Sleep(3000);
            var page_load=driver.FindElement(By.LinkText("English"));

            if (page_load.Displayed ==true)
            {
                logger.Debug("url has been launched successfully, Please check the screenshot");
                //ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
                //Screenshot screenshot = screenshotDriver.GetScreenshot();
                //String fp = "c:\\screenshot\\" + "snapshot" + "_" + DateTime.Now.ToString("dd_MMMM_hh_mm_ss_tt") + ".Png";
                //screenshot.SaveAsFile(fp, OpenQA.Selenium.ScreenshotImageFormat.Png);
                //System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            else
            {
                logger.Debug("url has been launched failed");
            }
        }

        [Given(@"Change the Language from Arabic to English")]
        public void GivenChangeTheLanguageFromArabicToEnglish()
        {
            Selenium_Methods.Click(driver, "English", "LinkText");
            System.Threading.Thread.Sleep(3000);

           
        }

        [Given(@"Enter the User Name and Password")]
        public void GivenEnterTheUserNameAndPassword()
        {
            IWebElement approve_tl_confirm = driver.FindElement(By.XPath("//*[@id='headerR1']/div[2]/div[1]/div[2]"));
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("arguments[0].click();", approve_tl_confirm);

            Selenium_Methods.EnterText(driver, "PageContent_txtUser", "hali", "Id");
            Selenium_Methods.EnterText(driver, "PageContent_txtPassword", "12345", "Id");
            

        }

        [When(@"User Clicked at Login button")]
        public void WhenUserClickedAtLoginButton()
        {
            Selenium_Methods.Click(driver, "PageContent_btnSignIn", "Id");
            System.Threading.Thread.Sleep(1000);
        }

        [Then(@"He should be redirected to the login page")]
        public void ThenHeShouldBeRedirectedToTheLoginPage()
        {
           
                var log_out_check_point = driver.FindElement(By.Id("ucHeader_lnkBtnLogout"));
                logger.Debug("Dash Board Loaded Properly and User is able to Login to the RDC Application");
                logger.Debug("Test Case Completed");
                logger.Debug("******************************");
                

        }

    }
}
