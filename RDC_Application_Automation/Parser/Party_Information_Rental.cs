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
    
    class Party_Information_Rental : DriverClass
    {
        Logger logger = LogManager.GetLogger("");

        [Given(@"User should click at Add Party button")]
        public void GivenUserShouldClickAtAddPartyButton()
        {
            
            Selenium_Methods.Click(driver, "PageContent_UCCaseParty1_UCCasePartyDetail1_btnAddParty", "Id");
            System.Threading.Thread.Sleep(2000);
        }

        [Given(@"User will add the first party")]
        public void GivenUserWillAddTheFirstParty()
        {
            Selenium_Methods.SelectDropDown(driver, "PageContent_UCCaseParty1_UCCasePartyDetail1_ddlCasePartyRole", "Claimant", "Id");
            System.Threading.Thread.Sleep(2000);
            Selenium_Methods.SelectDropDown(driver, "PageContent_UCCaseParty1_UCCasePartyDetail1_ddlContractPartyType", "Tenant", "Id");
            System.Threading.Thread.Sleep(2000);
            Selenium_Methods.SelectDropDown(driver, "PageContent_UCCaseParty1_UCCasePartyDetail1_ddlCasePartyTitle", "Himself", "Id");
            System.Threading.Thread.Sleep(2000);
            Selenium_Methods.Click(driver, "PageContent_UCCaseParty1_UCCasePartyDetail1_btnAddPartyTitle", "Id");
            System.Threading.Thread.Sleep(2000);
            Selenium_Methods.SelectDropDown(driver, "PageContent_UCCaseParty1_UCCasePartyDetail1_UCPartyInfo1_UCSelectCaseParty1_ddlIdType", "Emirates ID Number", "Id");
            System.Threading.Thread.Sleep(2000);
            Selenium_Methods.EnterText(driver, "PageContent_UCCaseParty1_UCCasePartyDetail1_UCPartyInfo1_UCSelectCaseParty1_txtId", "784197109698023", "Id");
            Selenium_Methods.Click(driver, "PageContent_UCCaseParty1_UCCasePartyDetail1_UCPartyInfo1_UCSelectCaseParty1_btnRetrieveFromEgov", "Id");
            System.Threading.Thread.Sleep(3000);
            Selenium_Methods.Click(driver, "PageContent_UCCaseParty1_UCCasePartyDetail1_btnSaveParty", "Id");
            System.Threading.Thread.Sleep(3000);

        }

        [When(@"User will add the second party")]
        public void WhenUserWillAddTheSecondParty()
        {
            Selenium_Methods.SelectDropDown(driver, "PageContent_UCCaseParty1_UCCasePartyDetail1_ddlCasePartyRole", "Defendant", "Id");
            System.Threading.Thread.Sleep(2000);
            Selenium_Methods.SelectDropDown(driver, "PageContent_UCCaseParty1_UCCasePartyDetail1_ddlContractPartyType", "Lessor", "Id");
            System.Threading.Thread.Sleep(2000);
            Selenium_Methods.SelectDropDown(driver, "PageContent_UCCaseParty1_UCCasePartyDetail1_ddlCasePartyTitle", "Himself", "Id");
            System.Threading.Thread.Sleep(2000);
            Selenium_Methods.Click(driver, "PageContent_UCCaseParty1_UCCasePartyDetail1_btnAddPartyTitle", "Id");
            System.Threading.Thread.Sleep(2000);
            Selenium_Methods.SelectDropDown(driver, "PageContent_UCCaseParty1_UCCasePartyDetail1_UCPartyInfo1_UCSelectCaseParty1_ddlIdType", "Emirates ID Number", "Id");
            System.Threading.Thread.Sleep(2000);
            Selenium_Methods.EnterText(driver, "PageContent_UCCaseParty1_UCCasePartyDetail1_UCPartyInfo1_UCSelectCaseParty1_txtId", "784197637919057", "Id");
            Selenium_Methods.Click(driver, "PageContent_UCCaseParty1_UCCasePartyDetail1_UCPartyInfo1_UCSelectCaseParty1_btnRetrieveFromEgov", "Id");
            System.Threading.Thread.Sleep(3000);
            Selenium_Methods.Click(driver, "PageContent_UCCaseParty1_UCCasePartyDetail1_btnSaveParty", "Id");

        }

        [When(@"User will click at decleration checkbox")]
        public void WhenUserWillClickAtDeclerationCheckbox()
        {
            System.Threading.Thread.Sleep(2000);
            Selenium_Methods.Click(driver, "PageContent_UCCaseParty1_chkTermAndCondition", "Id");
            System.Threading.Thread.Sleep(2000);
            
        }

        [Given(@"User landed on the page and select party")]
        public void GivenUserLandedOnThePageAndSelectParty()
        {
            logger.Debug("User can Add the Business Object");
            var element_found = driver.FindElement(By.ClassName("panel-heading"));
            if (element_found.Text == "Vouchers" || element_found.Text == "Case Summary")
            {
                logger.Debug(" Page loaded properly");
                System.Threading.Thread.Sleep(2000);
                Selenium_Methods.SelectDropDown(driver, "ctl00_PageContent_UCCaseVoucher1_grdVoucherDetails_ctl00_ctl04_ddlPartyName", "عبدالغنى عبدالستار خترى", "Id");

                System.Threading.Thread.Sleep(2000);

            }
            else
            {
                logger.Debug("Vouchers page did not load properly");
            }
        }

    }
}
