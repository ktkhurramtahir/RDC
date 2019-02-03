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
    class Request_Case:DriverClass
    {
        Logger logger = LogManager.GetLogger("");
        [Given(@"User should add the Request")]
        public void GivenUserShouldAddTheRequest()
        {

            logger.Debug("User can Add the Request");
            var element_found = driver.FindElement(By.ClassName("panel-heading"));
            if (element_found.Displayed == true)
            {
                logger.Debug("Case Request page loaded properly");
                System.Threading.Thread.Sleep(3000);
                Selenium_Methods.SelectDropDown(driver, "PageContent_UCCaseRequest1_ddlRequestTypeNew", "Evacuation Request", "Id");
                System.Threading.Thread.Sleep(5000);
                Selenium_Methods.SelectDropDown(driver, "PageContent_UCCaseRequest1_ddlRequestSubTypeNew", "الإخلاء لإخلال المستأجر بالتزام فرضه عليه القانون او نص بالعقد", "Id");
                System.Threading.Thread.Sleep(5000);
                Selenium_Methods.Click(driver, "PageContent_UCCaseRequest1_btnAddRequest", "Id");
                System.Threading.Thread.Sleep(3000);



                

            }
            else
            {
                logger.Debug("Case Request page did not load properly");
            }
        }

    }
}
