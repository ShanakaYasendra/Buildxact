using System;

using Buildxact.Pages;

namespace Buildxact.PageAssembly
{
    public class Page
    {
        public Page(Browser browsers)
        {
            _browser = browsers;
        }
        Browser _browser
        {
            get;
        }
        private T GetPages<T>() where T : new()
        {
            var page = (T)Activator.CreateInstance(typeof(T), _browser.getDriver);

            return page;
        }

        public LoginPage loginPage => GetPages<LoginPage>();
        public HomePage homePage => GetPages<HomePage>();
        public MenuBar menuBar => GetPages<MenuBar>();
        public EmailClass emailPage => GetPages<EmailClass>();
        public ResetPasswordPage resetPasswordPage => GetPages<ResetPasswordPage>();
        public AddNewUser addNewUser => GetPages<AddNewUser>();
    }
}