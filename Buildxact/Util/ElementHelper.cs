using System;
using System.Collections.Generic;

using OpenQA.Selenium;

namespace Buildxact.Util
{
    public class ElementHelper
    {
       

        /// <summary>
        /// This class act as Element Helper
        /// which use to find the element in the page
        /// </summary>
      
     
            private IWebDriver driver;

            public ElementHelper(IWebDriver driver)
            {
                this.driver = driver;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

            public IWebElement GetElementByID(string element)
            {
                try
                {
                    return driver.FindElement(By.Id(element));
                }
                catch (NoSuchElementException)
                {
                    return null;
                }

            }
            public IWebElement GetElementByClassName(string element)
            {
                try
                {
                    return driver.FindElement(By.ClassName(element));
                }
                catch (NoSuchElementException)
                {
                    return null;
                }

            }
            public IWebElement GetElementByCss(string element)
            {
                try
                {
                    return driver.FindElement(By.CssSelector(element));
                }
                catch (NoSuchElementException)
                {
                    return null;
                }

            }
            public IWebElement GetElementByXPath(string element)
            {
                try
                {
                    return driver.FindElement(By.XPath(element));
                }
                catch (NoSuchElementException)
                {
                    return null;
                }
            }
            public IWebElement GetElementByLinkText(string element)
            {
                try
                {
                    return driver.FindElement(By.LinkText(element));
                }
                catch (NoSuchElementException)
                {
                    return null;
                }
            }
            public IWebElement GetElementByName(string element)
            {
                try
                {
                    return driver.FindElement(By.Name(element));
                }
                catch (NoSuchElementException)
                {
                    return null;
                }
            }
            public IWebElement GetElementByTag(string element)
            {
                try
                {
                    return driver.FindElement(By.TagName(element));
                }
                catch (NoSuchElementException)
                {
                    return null;
                }
            }
            public IWebElement GetElementByPartialLinkText(string element)
            {
                try
                {
                    return driver.FindElement(By.PartialLinkText(element));
                }
                catch (NoSuchElementException)
                {
                    return null;
                }
            }

         public IList<IWebElement> GetElementsByXpath(string element)
        {
            try{
                return driver.FindElements(By.XPath(element));
            }
            catch(Exception)
            {
                return null;
            }
        }
        }
    }
