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
    class registering_rentalcase_without_ejari : DriverClass
    {
        [Given(@"Click the Rental Case")]
        public void GivenClickTheRentalCase()
        {
            Selenium_Methods.Click(driver, "PageContent_btn_2", "Id");
            System.Threading.Thread.Sleep(3000);
        }

        [Given(@"Click at Register a new request")]
        public void GivenClickAtRegisterANewRequest()
        {
            Selenium_Methods.Click(driver, "PageContent_UCRequestStartPoint1_rblRegistrationBasedOn_2", "Id");
            System.Threading.Thread.Sleep(3000);
            
        }

        [Then(@"Click at the No EJARI button")]
        public void ThenClickAtTheNoEJARIButton()
        {
            Selenium_Methods.Click(driver, "PageContent_UCSelectContractMethod1_btnNoEjari", "Id");
            System.Threading.Thread.Sleep(2000);
        }

        [Then(@"Enter the Contract Tenancy Detial")]
        public void ThenEnterTheContractTenancyDetial()
        {
            
            //Tenancy Contract Detial
            Selenium_Methods.EnterText(driver, "PageContent_UCCaseContract1_UCContractInfo1_txtContractValue", "100000", "Id");
            Selenium_Methods.Click(driver, "PageContent_UCCaseContract1_UCContractInfo1_dpStartDate_txtDate", "Id");
            Selenium_Methods.EnterText(driver, "PageContent_UCCaseContract1_UCContractInfo1_dpStartDate_txtDate", "01/01/2018", "Id");
            Selenium_Methods.Click(driver, "PageContent_UCCaseContract1_UCContractInfo1_dpEndDate_txtDate", "Id");
            Selenium_Methods.EnterText(driver, "PageContent_UCCaseContract1_UCContractInfo1_dpEndDate_txtDate", "31/12/2018", "Id");
            Selenium_Methods.Click(driver, "PageContent_UCCaseContract1_UCContractInfo1_btnCalculateAnnualAmount", "Id");
            System.Threading.Thread.Sleep(2000);
            //Property Information
            Selenium_Methods.SelectDropDown(driver, "PageContent_UCCaseContract1_UCPropertyInformation1_ddlUnitType", "Land", "Id");
            System.Threading.Thread.Sleep(2000);
            Selenium_Methods.SelectDropDown(driver, "PageContent_UCCaseContract1_UCPropertyInformation1_ddlUsage", "Residential", "Id");
            Selenium_Methods.SelectDropDown(driver, "PageContent_UCCaseContract1_UCPropertyInformation1_ddlArea", "Al Buteen", "Id");
            Selenium_Methods.EnterText(driver, "PageContent_UCCaseContract1_UCPropertyInformation1_txtPlotNo", "123", "Id");
            Selenium_Methods.Click(driver, "PageContent_UCCaseContract1_UCPropertyInformation1_btnAddProperty", "Id");
            System.Threading.Thread.Sleep(2000);
            Selenium_Methods.Click(driver, "PageContent_btnNext", "Id");
            System.Threading.Thread.Sleep(3000);

            

        }


    }
}
