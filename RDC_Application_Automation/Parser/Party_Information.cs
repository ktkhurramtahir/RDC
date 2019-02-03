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

namespace RDC_Application_Automation
{
    [Binding]
    public class UserCanEnterTheParties_Steps : DriverClass
    {
        Logger logger = LogManager.GetLogger("");
        [Given(@"Select the First party and Edit")]
        public void GivenSelectTheFirstPartyAndEdit()
        {
            Selenium_Methods.Click(driver, "PageContent_btnNext", "Id");
            System.Threading.Thread.Sleep(5000);
            var page_landed = driver.FindElement(By.Id("PageContent_divHeader"));
            if(page_landed.Text=="Mediation Case")
            {
                logger.Debug("User has been Landed at Add Party Screen");
                Selenium_Methods.Click(driver, "PageContent_UCCaseParty1_grdCaseParty_lnkbtnEdit_0", "Id");
                var edit_info_loaded = driver.PageSource.Contains("Party Information");
                logger.Debug("Party Information loaded properly");
                System.Threading.Thread.Sleep(3000);
                Selenium_Methods.SelectDropDown(driver, "PageContent_UCCaseParty1_UCCasePartyDetail1_ddlCasePartyRole", "Claimant", "Id");
                System.Threading.Thread.Sleep(2000);
                var title=driver.FindElement(By.Id("PageContent_UCCaseParty1_UCCasePartyDetail1_ddlCasePartyTitle"));

                if (title.Enabled)
                {
                    Selenium_Methods.SelectDropDown(driver, "PageContent_UCCaseParty1_UCCasePartyDetail1_ddlCasePartyTitle", "Himself", "Id");
                }
                else
                {
                    logger.Debug("Title Already Selected");
                }

                
                System.Threading.Thread.Sleep(3000);
                Selenium_Methods.Click(driver, "PageContent_UCCaseParty1_UCCasePartyDetail1_btnAddPartyTitle", "Id");
                System.Threading.Thread.Sleep(2000);
                Selenium_Methods.EnterText(driver, "PageContent_UCCaseParty1_UCCasePartyDetail1_UCPartyInfo1_UCPersonInformation1_dpIssueDate_txtDate", "01/11/2017", "Id");
                Selenium_Methods.Click(driver, "PageContent_UCCaseParty1_UCCasePartyDetail1_UCPartyInfo1_UCPersonInformation1_dpIssueDate_txtDate", "Id");
                Selenium_Methods.EnterText(driver, "PageContent_UCCaseParty1_UCCasePartyDetail1_UCPartyInfo1_UCPersonInformation1_dpExpiryDate_txtDate", "01/11/2022", "Id");
                Selenium_Methods.Click(driver, "PageContent_UCCaseParty1_UCCasePartyDetail1_UCPartyInfo1_UCPersonInformation1_dpExpiryDate_txtDate", "Id");
                Selenium_Methods.EnterText(driver, "PageContent_UCCaseParty1_UCCasePartyDetail1_UCPartyInfo1_UCPersonInformation1_txtEmail", "khurram.tahir@eres.ae", "Id");
                Selenium_Methods.SelectDropDown(driver, "PageContent_UCCaseParty1_UCCasePartyDetail1_UCPartyInfo1_UCPersonInformation1_ddlMobileCountryCode", "+971", "Id");
                Selenium_Methods.SelectDropDown(driver, "PageContent_UCCaseParty1_UCCasePartyDetail1_UCPartyInfo1_UCPersonInformation1_ddlMobileOperatorCode", "56", "Id");
                Selenium_Methods.EnterText(driver, "ctl00_PageContent_UCCaseParty1_UCCasePartyDetail1_UCPartyInfo1_UCPersonInformation1_txtMobileNumber", "9073880", "Id");
                Selenium_Methods.EnterText(driver, "PageContent_UCCaseParty1_UCCasePartyDetail1_UCPartyInfo1_UCPersonInformation1_txtAddress", "Dubai", "Id");
                Selenium_Methods.EnterText(driver, "PageContent_UCCaseParty1_UCCasePartyDetail1_UCPartyInfo1_UCPersonInformation1_txtEmirateID", "123456789012345", "Id");
                Selenium_Methods.EnterText(driver, "PageContent_UCCaseParty1_UCCasePartyDetail1_UCPartyInfo1_UCPersonInformation1_txtPassportNum", "Passport0", "Id");
                Selenium_Methods.Click(driver, "PageContent_UCCaseParty1_UCCasePartyDetail1_UCPartyInfo1_UCPersonInformation1_dpExpiryDate_txtDate", "Id");      
                Selenium_Methods.Click(driver, "PageContent_UCCaseParty1_UCCasePartyDetail1_btnSaveParty", "Id");
                System.Threading.Thread.Sleep(3000);
                var information_already_available = driver.FindElement(By.Id("PageContent_UCCaseParty1_UCCasePartyDetail1_UCPartyInfo1_UCPersonInformation1_lblMessage"));
                if (information_already_available.Displayed==true || information_already_available.Text == "Party exist in the system.")
                {
                    logger.Debug("is already exist in the system, please reload or cancel.");
                    logger.Debug("Party data already exist");
                    Selenium_Methods.Click(driver, "PageContent_UCCaseParty1_UCCasePartyDetail1_UCPartyInfo1_UCPersonInformation1_btnDialogReload", "Id");
                    System.Threading.Thread.Sleep(2000);
                    Selenium_Methods.Click(driver, "PageContent_UCCaseParty1_UCCasePartyDetail1_btnSaveParty", "Id");
                    System.Threading.Thread.Sleep(2000);

                }
                else
                {
                    logger.Debug("Party data saved properly");
                }
            }
            else
            {
                logger.Debug("User has not been Landed at Add Party Screen");
            }
        }

        [Given(@"Select the Second party and Edit it")]
        public void GivenSelectTheSecondPartyAndEditIt()
        {
            Selenium_Methods.Click(driver, "PageContent_UCCaseParty1_grdCaseParty_lnkbtnEdit_1", "Id");
            var edit_info_loaded = driver.PageSource.Contains("Party Information");
            logger.Debug("Party Information loaded properly");
            System.Threading.Thread.Sleep(3000);
            Selenium_Methods.SelectDropDown(driver, "PageContent_UCCaseParty1_UCCasePartyDetail1_ddlCasePartyRole", "Defendant", "Id");
            System.Threading.Thread.Sleep(2000);
            var title = driver.FindElement(By.Id("PageContent_UCCaseParty1_UCCasePartyDetail1_ddlCasePartyTitle"));

            if (title.Enabled)
            {
                Selenium_Methods.SelectDropDown(driver, "PageContent_UCCaseParty1_UCCasePartyDetail1_ddlCasePartyTitle", "Himself", "Id");
            }
            else
            {
                logger.Debug("Title Already Selected");
            }


            System.Threading.Thread.Sleep(3000);
            Selenium_Methods.Click(driver, "PageContent_UCCaseParty1_UCCasePartyDetail1_btnAddPartyTitle", "Id");
            System.Threading.Thread.Sleep(2000);
            Selenium_Methods.EnterText(driver, "PageContent_UCCaseParty1_UCCasePartyDetail1_UCPartyInfo1_UCPersonInformation1_dpIssueDate_txtDate", "01/11/2016", "Id");
            Selenium_Methods.Click(driver, "PageContent_UCCaseParty1_UCCasePartyDetail1_UCPartyInfo1_UCPersonInformation1_dpIssueDate_txtDate", "Id");
            Selenium_Methods.EnterText(driver, "PageContent_UCCaseParty1_UCCasePartyDetail1_UCPartyInfo1_UCPersonInformation1_dpExpiryDate_txtDate", "01/11/2021", "Id");
            Selenium_Methods.Click(driver, "PageContent_UCCaseParty1_UCCasePartyDetail1_UCPartyInfo1_UCPersonInformation1_dpExpiryDate_txtDate", "Id");
            var email_address = driver.FindElement(By.Id("PageContent_UCCaseParty1_UCCasePartyDetail1_UCPartyInfo1_UCPersonInformation1_txtEmail"));
            email_address.Clear();
            Selenium_Methods.EnterText(driver, "PageContent_UCCaseParty1_UCCasePartyDetail1_UCPartyInfo1_UCPersonInformation1_txtEmail", "khurram.tahir@eres.ae", "Id");
            Selenium_Methods.SelectDropDown(driver, "PageContent_UCCaseParty1_UCCasePartyDetail1_UCPartyInfo1_UCPersonInformation1_ddlMobileCountryCode", "+971", "Id");
            Selenium_Methods.SelectDropDown(driver, "PageContent_UCCaseParty1_UCCasePartyDetail1_UCPartyInfo1_UCPersonInformation1_ddlMobileOperatorCode", "56", "Id");
            Selenium_Methods.EnterText(driver, "ctl00_PageContent_UCCaseParty1_UCCasePartyDetail1_UCPartyInfo1_UCPersonInformation1_txtMobileNumber", "1234567", "Id");
            var address = driver.FindElement(By.Id("PageContent_UCCaseParty1_UCCasePartyDetail1_UCPartyInfo1_UCPersonInformation1_txtAddress"));
            if (address.Enabled == true) {
                Selenium_Methods.EnterText(driver, "PageContent_UCCaseParty1_UCCasePartyDetail1_UCPartyInfo1_UCPersonInformation1_txtAddress", "Dubai", "Id");
            }
            else
            {
                logger.Debug("Address already entered and control is disable");
            }
            Selenium_Methods.EnterText(driver, "PageContent_UCCaseParty1_UCCasePartyDetail1_UCPartyInfo1_UCPersonInformation1_txtEmirateID", "123456789012346", "Id");
            var passport= driver.FindElement(By.Id("PageContent_UCCaseParty1_UCCasePartyDetail1_UCPartyInfo1_UCPersonInformation1_txtPassportNum"));
            if (passport.Enabled == true)
            {
                Selenium_Methods.EnterText(driver, "PageContent_UCCaseParty1_UCCasePartyDetail1_UCPartyInfo1_UCPersonInformation1_txtPassportNum", "Passport0", "Id");
            }
            else
            {
                logger.Debug("Passport already entered and control is disable");
            }
            
            Selenium_Methods.Click(driver, "PageContent_UCCaseParty1_UCCasePartyDetail1_UCPartyInfo1_UCPersonInformation1_dpExpiryDate_txtDate", "Id");


            
            try
            {
                Selenium_Methods.Click(driver, "PageContent_UCCaseParty1_UCCasePartyDetail1_btnSaveParty", "Id");
                System.Threading.Thread.Sleep(3000);
            }
            catch(NoSuchElementException ex)
            {
                var information_already_available = driver.FindElement(By.Id("PageContent_UCCaseParty1_UCCasePartyDetail1_UCPartyInfo1_UCPersonInformation1_lblMessage"));
                logger.Debug("is already exist in the system, please reload or cancel.");
                logger.Debug("Party data already exist");
                Selenium_Methods.Click(driver, "PageContent_UCCaseParty1_UCCasePartyDetail1_UCPartyInfo1_UCPersonInformation1_btnDialogReload", "Id");
                System.Threading.Thread.Sleep(3000);
                Selenium_Methods.Click(driver, "PageContent_UCCaseParty1_UCCasePartyDetail1_btnSaveParty", "Id");
                System.Threading.Thread.Sleep(3000);
            }
            //check for third party
            var third_party = driver.FindElement(By.Id("PageContent_UCCaseParty1_grdCaseParty_lnkDelete_2"));
            if(third_party.Displayed==true || third_party.Enabled == true)
            {
                Selenium_Methods.Click(driver, "PageContent_UCCaseParty1_grdCaseParty_lnkDelete_2", "Id");
                System.Threading.Thread.Sleep(2000);
                IWebElement approve_tl_confirm = driver.FindElement(By.Id("cmodal_yes"));
                IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
                executor.ExecuteScript("arguments[0].click();", approve_tl_confirm);
                System.Threading.Thread.Sleep(2000);

            }

}
        
        [When(@"Acknowledge the Information as Corrected")]
        public void WhenAcknowledgeTheInformationAsCorrected()
        {
            Selenium_Methods.Click(driver, "PageContent_UCCaseParty1_chkTermAndCondition", "Id");
        }
        
        [Then(@"Click at Next  button")]
        public void ThenClickAtNextButton()
        {
            
            Selenium_Methods.Click(driver, "PageContent_btnNext", "Id");
            logger.Debug("Test Case Completed, Business Object Added");
            logger.Debug("******************************");
            System.Threading.Thread.Sleep(3000);

        }
        [Then(@"Click at Submit button")]
        public void ThenClickAtSubmitButton()
        {
            try {
                Selenium_Methods.Click(driver, "PageContent_btnSubmitCase", "Id");
                logger.Debug("Test Case Completed, Business Object Added");
                logger.Debug("******************************");
                System.Threading.Thread.Sleep(5000);
                var success_message = driver.FindElement(By.PartialLinkText("Your case has been registered succesfully."));
                Assert.AreEqual("Your case has been registered succesfully.", success_message);
                logger.Debug("Medication Case Filing has been completed");
            }
            catch (NoSuchElementException ex)
            {
                logger.Debug("Your case has not been registered");
            }
           
            

        }

    }
}
