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
    public class Add_VouchersSteps:DriverClass

    {
        Logger logger = LogManager.GetLogger("");
        [Given(@"User landed on the page")]
        public void GivenUserLandedOnThePage()
        {
            logger.Debug("User can Add the Business Object");
            var element_found = driver.FindElement(By.ClassName("panel-heading"));
            if (element_found.Text == "Vouchers" || element_found.Text=="Case Summary")
            {
                logger.Debug(" Page loaded properly");
                System.Threading.Thread.Sleep(2000);
                Selenium_Methods.SelectDropDown(driver, "ctl00_PageContent_UCCaseVoucher1_grdVoucherDetails_ctl00_ctl04_ddlPartyName", "اختبار المستخدم", "Id");
                
                System.Threading.Thread.Sleep(2000);
             
            }
            else
            {
                logger.Debug("Vouchers page did not load properly");
            }
        }
        
    }
}
