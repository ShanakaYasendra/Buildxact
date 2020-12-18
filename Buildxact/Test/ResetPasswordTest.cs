using System;

using Buildxact.PageAssembly;

using NUnit.Framework;

namespace Buildxact.Test
{
    public class ResetPasswordTest:BaseClass

    {
        /// <summary>
        /// Test 2 – Reset Primary User password via logged-in Session
        ///       Steps:
        /// 1.	Login to a second tenant provided to you
        /// 2.	Navigate to My Profile
        /// 3.	Click Reset Password
        /// 4.	Click OK in the confirmation pop-up
        /// 5.	Logout of the Buildxact app
        /// 
        /// Please Update the password before you run the test

        /// </summary>
        [Test, Order(1)]
        public void ResetUserPasswordTest()
        {
            browser.Init("https://app-v2-staging.buildxact.com/");
            
            pages.loginPage.EnterUsername("shanaka02@email.ghostinspector.com", "Test@1234"); // Please Update the password before you run the test
            pages.menuBar.ClickProfile();
            pages.menuBar.ResetPassword();
        
            pages.menuBar.LogOut();

        }

        /// <summary>
        /// 6.	Navigate to the user’s mailbox
        /// 7.	Open the Password Reset request email
        /// 8.	Click the link to reset the user’s password
        /// 9.	Enter the new password in the New Password field
        /// 10.	Enter the new password on the Confirm New Password field
        /// 11.	Login and confirm user lands on the Dashboard page
        /// 12.	Logout
        ///
        ///  Please Update the password before you run the test
        /// </summary>
        [Test, Order(2)]
        public void EmailCheck()
        {
            browser.Init("https://email.ghostinspector.com/shanaka02");

            pages.emailPage.ClickResetEmail();
            pages.emailPage.ClickResetLink();
            pages.resetPasswordPage.EnterNewPassword("Test@123"); // Please Update the password before you run the test
            Assert.AreEqual(pages.homePage.GetTitle(), "Buildxact-stg: Dashboard");
            pages.menuBar.ClickProfile();
            pages.menuBar.LogOut();
            Assert.AreEqual(pages.loginPage.GetTitle(), "Buildxact-stg: Login");

        }
        /// <summary>
        /// 13.	Attempt to login with the old password, confirm this fails
        ///  Please Update the password before you run the test
        /// </summary>
        [Test, Order(3)]
        public void OldPasswordTest()
        {
            browser.Init("https://app-v2-staging.buildxact.com/");

            pages.loginPage.EnterUsername("shanaka02@email.ghostinspector.com", "Test@1234"); // Please Update the password before you run the test
            Assert.IsTrue(pages.loginPage.error.Displayed);
        }
    }
}
