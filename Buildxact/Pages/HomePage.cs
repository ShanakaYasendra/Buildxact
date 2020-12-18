using System;

using Buildxact.Util;

using OpenQA.Selenium;

namespace Buildxact.Pages
{
    public class HomePage
    {
        private IWebDriver driver;
        private ElementHelper elementHelper;
        public HomePage()
        {
            driver = null;
        }
        public HomePage(IWebDriver webdriver)
        {
            driver = webdriver;

         //   driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            elementHelper = new ElementHelper(driver);
        }


        public IWebElement menuBtn => elementHelper.GetElementByID("my-business-button");
        public IWebElement profileClass => elementHelper.GetElementByClassName("sidebar-v2-link my-business");
        public string GetTitle()
        {
            if (menuBtn.Displayed)
            {
                return driver.Title;
            }
            else
            {
                return null;
            }
        }

        
    }
}
