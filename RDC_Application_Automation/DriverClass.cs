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

namespace RDC_Application_Automation
{
    public class DriverClass
    {
        public DriverClass()
        {
            if (driver == null)
            {
                driver = new ChromeDriver();
            }
        }
        public static IWebDriver driver;
    }
}

