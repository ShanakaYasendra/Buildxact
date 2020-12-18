using System;

using Buildxact.PageAssembly;

using NUnit.Framework;

namespace Buildxact.Test
{
    public class LoginTest:BaseClass
    {

        /// <summary>
        /// Test 1 – Login, and logout
        /// 1.	Login to one of the tenants provided to you
        /// 2.	Confirm user lands on the Dashboard page
        /// 3.	Logout of the tenant and confirm user lands on the login page.
        /// </summary>

        [Test]
        public void UserLoginTest()
        {
            browser.Init("https://app-v2-staging.buildxact.com/");
           
            pages.loginPage.EnterUsername("shanaka01@email.ghostinspector.com", "Test@1234");
            Assert.AreEqual(pages.homePage.GetTitle(), "Buildxact-stg: Dashboard");
            pages.menuBar.ClickProfile();
            pages.menuBar.LogOut();
            Assert.AreEqual(pages.loginPage.GetTitle(), "Buildxact-stg: Login");
        }

       
      
    }
}
