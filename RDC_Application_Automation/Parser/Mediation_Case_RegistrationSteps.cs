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
    public class Mediation_Case_RegistrationSteps:DriverClass
    {
        Logger logger = LogManager.GetLogger("");
        [Given(@"Click at New Case Link")]
        public void GivenClickAtNewCaseLink()
        {
            logger.Debug("Test Case for Adding a Payment Started");
            logger.Debug("Every Step of this test case is Pre-Requisite");
            Selenium_Methods.Click(driver, "New Case", "LinkText");
            System.Threading.Thread.Sleep(3000);
        }
        
        [Given(@"Click the Mediation Case")]
        public void GivenClickTheMediationCase()
        {
            
                Selenium_Methods.Click(driver, "PageContent_btn_1", "Id");
                System.Threading.Thread.Sleep(1000);
            

        }
        
        [Given(@"Click at the EJARI button")]
        public void GivenClickAtTheEJARIButton()
        {
            
            Selenium_Methods.Click(driver, "PageContent_UCSelectContractMethod1_btnEjari", "Id");
            System.Threading.Thread.Sleep(1000);
        }
        
        [Given(@"Enter Text in Contract No and Dewa No")]
        public void GivenEnterTextInContractNoAndDewaNo()
        {
            
                Selenium_Methods.EnterText(driver, "PageContent_UCCaseContract1_UCSelectEjariContract1_txtEjariNo", "0120130902002772", "Id");
                Selenium_Methods.EnterText(driver, "PageContent_UCCaseContract1_UCSelectEjariContract1_txtDewa", "392029642", "Id");
               
        }
        
        [When(@"Click at Retrieve Ejari Information")]
        public void WhenClickAtRetrieveEjariInformation()
        {
            try
            {
               Selenium_Methods.Click(driver, "PageContent_UCCaseContract1_UCSelectEjariContract1_btnRetrieve", "Id");
               System.Threading.Thread.Sleep(30000);
            }
            catch (NoSuchElementException ex)
            {
                var ejari_service=driver.FindElement(By.PartialLinkText("Error : please try again or contact Administrator"));
                Assert.AreEqual("Error : please try again or contact Administrator", ejari_service);
                logger.Debug("Ejari Service is down, Please try again or Cotact Administrator");
                logger.Debug("Test Case Execution for Mediation Case will not run anymore");
            }
        }
        
        [Then(@"Ejari related Information should be retrieved or check for the exception that Ejari Service is down")]
        public void ThenEjariRelatedInformationShouldBeRetrievedOrCheckForTheExceptionThatEjariServiceIsDown()
        {
            var search_found = driver.FindElement(By.Id("PageContent_btnNext"));
            if(search_found.Displayed==true || search_found.Enabled==true)
            {
                logger.Debug("Tenancy Contract Information Found");
                logger.Debug("******************************");
            }
            else
            {
                logger.Debug("Tenancy Contract Information did not Found");
                logger.Debug("Please correct your entered data under Contract No and Dewa No");
                logger.Debug("******************************");
                
            }
        }
    }
}
