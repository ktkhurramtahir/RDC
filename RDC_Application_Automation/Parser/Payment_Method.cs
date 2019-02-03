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
using NUnit.Framework;
using System.Configuration;
using System.IO;
using NLog;
using System.Diagnostics;
using System.Drawing.Imaging;


namespace RDC_Application_Automation.Parser
{
    [Binding]
    public class Payment_MethodSteps:DriverClass
    {
        Logger logger = LogManager.GetLogger("");

        [Given(@"Click at Pay button")]
        public void GivenClickAtPayButton()
        {
            System.Threading.Thread.Sleep(3000);
            Selenium_Methods.Click(driver, "PageContent_UCCaseSaveResult1_btnPay", "Id");
            System.Threading.Thread.Sleep(3000);
            
        }
        
        

        [Given(@"Select Disclaimer and Click at Online button")]
        public void GivenSelectDisclaimerAndClickAtOnlineButton()
        {
            Selenium_Methods.Click(driver, "PageContent_cbDisclaimerAgree", "Id");
            Selenium_Methods.Click(driver, "PageContent_btnOnlinePayment", "Id");
            System.Threading.Thread.Sleep(5000);
        }

       
        [Given(@"Verify that naqoodi page loaded properly")]
        public void GivenVerifyThatNaqoodiPageLoadedProperly()
        {
            Selenium_Methods.Click(driver, "btnPayNow", "Id");
            System.Threading.Thread.Sleep(10000);

        }

        [Given(@"Enter the username,password and click at login at wallet")]
        public void GivenEnterTheUsernamePasswordAndClickAtLoginAtWallet()
        {
            Selenium_Methods.EnterText(driver, "userId", "dw100029", "Id");
            Selenium_Methods.EnterText(driver, "rawPasscode", "P@ss4321", "Id");
            System.Threading.Thread.Sleep(3000);
            Selenium_Methods.Click(driver, "paymentForm:loginButton", "Id");
            System.Threading.Thread.Sleep(1000);
        }

        [Given(@"Make the Payment")]
        public void GivenMakeThePayment()
        {
            System.Threading.Thread.Sleep(3000);
            Selenium_Methods.Click(driver, "payNow", "Id");
            System.Threading.Thread.Sleep(10000);
        }

        [Then(@"Make sure payment done successfully")]
        public void ThenMakeSurePaymentDoneSuccessfully()
        {
            var success_message = driver.FindElement(By.Id("PageContent_UCAlertMessage1_lblMessage"));
            if(success_message.Text== "Payment Completed")
            {
                logger.Debug("Payment has been completed");
                logger.Debug("******************************");
                System.Threading.Thread.Sleep(3000);
            }
            else
            {
                logger.Debug("Payment has not been completed");
                logger.Debug("******************************");
                System.Threading.Thread.Sleep(3000);
            }
        }


    }
}
