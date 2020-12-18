
using Buildxact.Util;

using OpenQA.Selenium;

namespace Buildxact.Pages
{
    public class LoginPage
    {

        private IWebDriver driver;
        private ElementHelper elementHelper;
      
        public LoginPage()
        {
            driver = null;
        }
        public LoginPage(IWebDriver webdriver)

        {
            driver = webdriver;
            elementHelper = new ElementHelper(driver);
        }
        public IWebElement username => elementHelper.GetElementByID("username");
        public IWebElement continueBtn => elementHelper.GetElementByID("bx-continue");
        public IWebElement password => elementHelper.GetElementByID("password");
        public IWebElement login => elementHelper.GetElementByXPath("//button[@type='submit']");
        public IWebElement error => elementHelper.GetElementByXPath("//span[contains(.,'The user name or password is incorrect.')]");

        public void EnterUsername(string email, string passwordTxt)
        {
            username.Clear();
            username.SendKeys(email);
            continueBtn.Click();
            password.Clear();
            password.SendKeys(passwordTxt);
            login.Click();
        }
        public string GetTitle()
        {
            return driver.Title;
        }
        
    }
}
