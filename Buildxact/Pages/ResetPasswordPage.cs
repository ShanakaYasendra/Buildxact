using System;

using Buildxact.Util;

using OpenQA.Selenium;

namespace Buildxact.Pages
{
    public class ResetPasswordPage

    {
        private IWebDriver driver;
        private ElementHelper elementHelper;
        public ResetPasswordPage()
        
            {
                driver = null;
            }
            public ResetPasswordPage(IWebDriver webdriver)

            {
                driver = webdriver;

                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

                elementHelper = new ElementHelper(driver);
            }

        public void EnterNewPassword(string newPassword)
        {
           
            elementHelper.GetElementByID("pswd").SendKeys(newPassword);

            elementHelper.GetElementByID("pswd-rpt").SendKeys(newPassword);
            elementHelper.GetElementByXPath("//button[@type='submit']").Click();

            
        }
    }
    }

