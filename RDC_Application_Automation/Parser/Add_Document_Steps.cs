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
using OpenQA.Selenium.Remote;
using System.Windows.Forms;

namespace RDC_Application_Automation.Parser
{
    [Binding]
    public class UserCanEnterTheParties_Steps:DriverClass
    {
        Logger logger = LogManager.GetLogger("");

        [Given(@"User should add the document")]
        public void GivenUserShouldAddTheDocument()
        {
            logger.Debug("User can Add the Request");
            var element_found = driver.FindElement(By.ClassName("panel-heading"));
            if (element_found.Displayed == true)
            {
                logger.Debug("Document page loaded properly");
                System.Threading.Thread.Sleep(3000);
                /*Selenium_Methods.Click(driver, "//*[@id='PageContent_UCDocuments2_divAddDocument']/div[2]/a", "XPath");
                System.Threading.Thread.Sleep(2000);
                Selenium_Methods.EnterText(driver, "PageContent_UCDocuments2_UCAddDocument1_txtDate", "01/11/2017", "Id");
                Selenium_Methods.Click(driver, "PageContent_UCDocuments2_UCAddDocument1_txtDate", "Id");
                Selenium_Methods.EnterText(driver, "PageContent_UCDocuments2_UCAddDocument1_txtTitle", "test document", "Id");

                System.Threading.Thread.Sleep(2000);
                //IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
                //executor.ExecuteScript("alert('here');");
                //System.Threading.Thread.Sleep(3000);
                var El = driver.FindElement(By.TagName("button"));
                //El.FindElement(By.Name("ctl00_PageContent_UCDocuments2_UCAddDocument1_fuDocumentfile0")).FindElement(By.Id("ctl00_PageContent_UCDocuments2_UCAddDocument1_fuDocumentfile0"));


                El.FindElement(By.TagName("input")).FindElement(By.Name("ctl00_PageContent_UCDocuments2_UCAddDocument1_fuDocumentfile0")).FindElement(By.Id("//*[@id='ctl00_PageContent_UCDocuments2_UCAddDocument1_fuDocumentfile0']"));
                if (El.Displayed == true)
                {
                    logger.Debug("document control found");
                    System.Threading.Thread.Sleep(3000);

                    SendKeys.SendWait(@"C:\RDC Applicatoin Automation\test.PNG");
                    System.Threading.Thread.Sleep(5000);
                    SendKeys.SendWait(@"{Enter}");
                    System.Threading.Thread.Sleep(5000);

                }
                else
                {
                    logger.Debug("document control did not find");
                }


                //IWebElement approve_tl_confirm = driver.FindElement(By.XPath("//*[@id='PageContent_UCDocuments2_UCAddDocument1_btnSubmit']"));
                //IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
                //executor.ExecuteScript("arguments[0].click();", approve_tl_confirm);
                //IWebElement El = driver.FindElement(By.Id("ctl00_PageContent_UCDocuments2_UCAddDocument1_fuDocumentfile0"));

                //IWebElement El = driver.FindElement(By.XPath("//*[@id='PageContent_UCDocuments2_UCAddDocument1_btnSubmit']"));
                //String script = "document.getElementById('ctl00_PageContent_UCDocuments2_UCAddDocument1_fuDocumentfile0').value='" + "C:\\RDC Applicatoin Automation\\test.PNG" + "';";
                //((IJavaScriptExecutor)driver).ExecuteScript(script);
                //El.SendKeys("C:\\RDC Applicatoin Automation\\test.PNG");
                System.Threading.Thread.Sleep(3000);
                Selenium_Methods.Click(driver, "PageContent_UCDocuments2_UCAddDocument1_btnSubmit", "Id");
                


                System.Threading.Thread.Sleep(3000);*/

            }
            else
            {
                logger.Debug("Document Request page did not load properly");
            }
        }
    }
}
