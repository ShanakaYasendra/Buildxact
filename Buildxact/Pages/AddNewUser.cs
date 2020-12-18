using System;

using Buildxact.Util;

using OpenQA.Selenium;

namespace Buildxact.Pages
{
    public class AddNewUser
    {
        private IWebDriver driver;
        private ElementHelper elementHelper;
        public AddNewUser()
        {
            driver = null;
        }
        public AddNewUser(IWebDriver webdriver)
        {
            driver = webdriver;

           

            elementHelper = new ElementHelper(driver);
        }

       public IWebElement addUser => elementHelper.GetElementByXPath("//button[contains(@ng-click,'vm.addUser()')]");
        public IWebElement firstName => elementHelper.GetElementByXPath("//input[contains(@ng-model,'vm.user.firstName')]");
        public IWebElement lastName => elementHelper.GetElementByXPath("//input[@ng-model='vm.user.lastName']");
        public IWebElement email => elementHelper.GetElementByXPath("//input[contains(@type,'email')]");
        public IWebElement okBtn => elementHelper.GetElementByXPath("//button[@type='button'][contains(.,'OK')]");
        public IWebElement mobile => elementHelper.GetElementByID("phone");

        public void AddUser(string firstNameval,string lastNameVal, string emailVal,string mobileVal)
        {
            
            addUser.Click();
            firstName.Clear();
            firstName.SendKeys(firstNameval);
            lastName.Clear();
            lastName.SendKeys(lastNameVal);
            email.Clear();
            email.SendKeys(emailVal);
            mobile.Clear();
            mobile.SendKeys(mobileVal);
            okBtn.Click();
        }
    }
}
