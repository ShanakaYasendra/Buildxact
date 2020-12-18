using System;

using Buildxact.Util;

using OpenQA.Selenium;

namespace Buildxact.Pages
{

    public class MenuBar
    {
        IWebDriver driver;
        ElementHelper elementHelper;
        public MenuBar()
        {
            driver = null;
        }
        public MenuBar(IWebDriver webDriver)
        {
            driver = webDriver;
           
            elementHelper = new ElementHelper(driver);
        
        }
        public LoginPage LogOut()
        {
           
            elementHelper.GetElementByXPath("//header[@ng-click='vm.fnSignOut()'][contains(.,'Log Out')]").Click();
            elementHelper.GetElementByCss(".swal2-confirm").Click();
            return new LoginPage();
    
        }
        public void ClickProfile()
        {
            elementHelper.GetElementByXPath("//span[@class='title'][contains(.,'My Profile')]").Click();
        }
        public void ResetPassword()
        {

            elementHelper.GetElementByXPath("//button[@type='button'][contains(.,'Reset Password')]").Click();
           elementHelper.GetElementByCss(".swal2-confirm").Click();
        }
        public void ClickBusiness()
        {
            elementHelper.GetElementByXPath("//span[@class='title'][contains(.,'My Business')]").Click();
        }

        public void ClickUsers()
        {
            elementHelper.GetElementByXPath("//label[contains(.,'Users')]").Click();
        }
    }
}
