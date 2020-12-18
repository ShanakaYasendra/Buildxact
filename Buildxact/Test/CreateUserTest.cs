using System;

using Buildxact.PageAssembly;

using NUnit.Framework;

namespace Buildxact.Test
{
    public class CreateUserTest:BaseClass
    {
        /// <summary>
        ///  Test 3 – Create a new user
        /// Steps: 
        /// 1.	Login to one or the other tenant
        /// 2.	Navigate to My Business > Users
        /// 3.	Click the Add User button
        /// 4.	Complete user information on New User form and submit
        /// 5.	Logout
        /// 6.	Navigate to the new user’s mailbox
        /// 7.	Open the Welcome email
        /// 8.	Click the Activate button to activate the new user
        /// 9.	Enter the new user’s password in the New Password field
        /// 10.	Enter the new password on the Confirm New Password field
        /// 11.	Click the login button
        /// 12.	Confirm user lands on the Dashboard page
       /// </summary>


       [Test,Order(1)]
       public void NewUserCreation()
        {
            browser.Init("https://app-v2-staging.buildxact.com/");
    
            pages.loginPage.EnterUsername("shanaka01@email.ghostinspector.com", "Test@1234");
            Assert.AreEqual(pages.homePage.GetTitle(), "Buildxact-stg: Dashboard");
            pages.menuBar.ClickBusiness();
            pages.menuBar.ClickUsers();
            pages.addNewUser.AddUser("sh", "sh", "sh@email.ghostinspector.com","0430123333");
            pages.menuBar.ClickProfile();
            pages.menuBar.LogOut();
            
        }

        [Test, Order(2)]
        public void AddUserEmailTest()
        {
            browser.Init("https://email.ghostinspector.com/sh");
       
            pages.emailPage.ClickWelcomeEmail();
            pages.emailPage.ClickActivate();
            pages.resetPasswordPage.EnterNewPassword("Test@1234");
            Assert.AreEqual(pages.homePage.GetTitle(), "Buildxact-stg: Dashboard");
            pages.menuBar.ClickProfile();
            pages.menuBar.LogOut();
        }
        
    }
}
