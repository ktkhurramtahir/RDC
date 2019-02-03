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
    class Selenium_Methods
    {

        private static NLog.Logger logger = NLog.LogManager.GetLogger("");

        public static void EnterText(IWebDriver driver, string element, string value, string elementtype)
        {

            if (elementtype == "Id")
            {
                var search_element = driver.FindElement(By.Id(element));
                if (search_element.Displayed == true || search_element.Enabled == true)
                {

                    logger.Debug(element + "   Found at the page in enabled form ");
                    search_element.SendKeys(value);
                    logger.Debug(value + " is entered as Test Criteria   ");
                }
                else
                {
                    logger.Debug(element + "  did Not Find at the page  ");
                }
            }

            if (elementtype == "Name")
            {
                var search_element = driver.FindElement(By.Name(element));
                if (search_element.Displayed == true || search_element.Enabled == true)
                {


                    logger.Debug(element + "   Found at the page in enabled form  ");
                    search_element.SendKeys(value);
                    logger.Debug(value + " is entered as Test Criteria   ");
                }
                else
                {
                    logger.Debug(element + "  did Not Find at the page  ");
                }
            }

        }

        //Click into a button, Checkbox, option etc
        public static void Click(IWebDriver driver, string element, string elementtype)
        {

            if (elementtype == "Id")
            {
                var search_element = driver.FindElement(By.Id(element));
                if (search_element.Displayed == true || search_element.Enabled == true)
                {

                    logger.Debug(element + "   Found at the page in enabled form ");
                    search_element.Click();
                    logger.Debug(element + " is Clicked   ");
                }
                else
                {
                    logger.Debug(element + "  did Not Find at the page  ");
                }
            }

            if (elementtype == "Name")
            {
                var search_element = driver.FindElement(By.Name(element));
                if (search_element.Displayed == true || search_element.Enabled == true)
                {


                    logger.Debug(element + "   Found at the page in enabled form  ");
                    search_element.Click();
                    logger.Debug(element + " is Clicked    ");
                }
                else
                {
                    logger.Debug(element + "  did Not Find at the page  ");
                }
            }

            if (elementtype == "LinkText")
            {
                var search_element = driver.FindElement(By.LinkText(element));
                if (search_element.Displayed == true || search_element.Enabled == true)
                {


                    logger.Debug(element + "   Found at the page in enabled form  ");
                    search_element.Click();
                    logger.Debug(element + " is Clicked    ");
                }
                else
                {
                    logger.Debug(element + "  did Not Find at the page  ");
                }
            }

            if (elementtype == "XPath")
            {
                var search_element = driver.FindElement(By.XPath(element));
                if (search_element.Displayed == true || search_element.Enabled == true)
                {


                    logger.Debug(element+ "   Found at the page in enabled form  ");
                    search_element.Click();
                    logger.Debug(element + " is Clicked    ");
                }
                else
                {
                    logger.Debug(element + "  did Not Find at the page  ");
                }

            }



        }


        public static void SelectDropDown(IWebDriver driver, string element, string value, string elementtype)
        {
            if (elementtype == "Id")
            {
                try
                {
                    var selec_drop_down = new SelectElement(driver.FindElement(By.Id(element)));
                    selec_drop_down.SelectByText(value);
                    logger.Debug(element + "   Found and Value selected");
                }
                catch (NoSuchElementException ex)
                {
                    logger.Debug(ex, element + "   No Such element found  ");

                }
            }
            if (elementtype == "Name")
                try
                {
                    var selec_drop_down = new SelectElement(driver.FindElement(By.Name(element)));
                    selec_drop_down.SelectByText(value);
                    logger.Debug(element + "   Found and Value selected");
                }
                catch (NoSuchElementException ex)
                {
                    logger.Debug(ex, "  No Such element found");
                }
        }

        public static void menu_selection(IWebDriver driver, string element, string value, string elementtype)
        {
            if (elementtype == "Id")
            {
                var search_element = driver.FindElement(By.Id(element));
                if (search_element.Text== "Mediation Case" ||     search_element.Displayed == true || search_element.Enabled == true)
                {

                    logger.Debug(element + "   Found at the page in enabled form ");
                    search_element.Click();
                    logger.Debug(element + " is Clicked   ");
                }
                else
                {
                    logger.Debug(element + "  did Not Find at the page  ");
                }
            }

            if (elementtype == "Name")
            {
                var search_element = driver.FindElement(By.Name(element));
                if (search_element.Text == "Mediation Case" || search_element.Displayed == true || search_element.Enabled == true)
                {


                    logger.Debug(element+ "   Found at the page in enabled form  ");
                    search_element.Click();
                    logger.Debug(element + " is Clicked    ");
                }
                else
                {
                    logger.Debug(element + "  did Not Find at the page  ");
                }
            }

            if (elementtype == "LinkText")
            {
                var search_element = driver.FindElement(By.LinkText(element));
                if (search_element.Text == "Mediation Case" || search_element.Displayed == true || search_element.Enabled == true)
                {


                    logger.Debug(element + "   Found at the page in enabled form  ");
                    search_element.Click();
                    logger.Debug(element + " is Clicked    ");
                }
                else
                {
                    logger.Debug(element + "  did Not Find at the page  ");
                }
            }

            if (elementtype == "XPath")
            {
                var search_element = driver.FindElement(By.XPath(element));
                if (search_element.Text == "Mediation Case" || search_element.Displayed == true || search_element.Enabled == true)
                {


                    logger.Debug(element + "   Found at the page in enabled form  ");
                    search_element.Click();
                    logger.Debug(element + " is Clicked    ");
                }
                else
                {
                    logger.Debug(element + "  did Not Find at the page  ");
                }

            }


        }
    }
}
        
