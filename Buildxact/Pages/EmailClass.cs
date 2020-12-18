using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

using Buildxact.Util;

using OpenQA.Selenium;

namespace Buildxact.Pages
{
    public class EmailClass
    {
        IWebDriver driver;
        private ElementHelper elementHelper;
        public EmailClass()
        {
            driver = null;
        
        }
        public EmailClass(IWebDriver webDriver)
        {
            driver = webDriver;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            elementHelper = new ElementHelper(driver);
        }

     
        public void ClickResetEmail()
        {
          IList<IWebElement> resetEmail = elementHelper.GetElementsByXpath("(//a[contains(.,'Reset your Buildxact account password')])");
            
            resetEmail[0].Click();
        }

        public void ClickResetLink()
        {
            
            Thread.Sleep(100);
           IWebElement resetBtn = elementHelper.GetElementByLinkText("RESET PASSWORD");
            resetBtn.Click();

            ((IJavaScriptExecutor)driver).ExecuteScript("window.open();");
            driver.SwitchTo().Window(driver.WindowHandles.Last());

        }
        public void ClickWelcomeEmail()
        {
            IList<IWebElement> activateEmail = elementHelper.GetElementsByXpath("//a[contains(.,'Welcome to Buildxact')]");
            activateEmail[0].Click();
        }
        public void ClickActivate()
        {
            Thread.Sleep(100);
            IWebElement resetBtn = elementHelper.GetElementByLinkText("ACTIVATE");
            resetBtn.Click();

            ((IJavaScriptExecutor)driver).ExecuteScript("window.open();");
            driver.SwitchTo().Window(driver.WindowHandles.Last());
        }
       
    }
}
