using System;
using System.IO;
using System.Reflection;

using AventStack.ExtentReports;

using Buildxact.Test;

using NUnit.Framework;
using NUnit.Framework.Interfaces;

using OpenQA.Selenium;

namespace Buildxact.PageAssembly
{
    public class BaseClass
    {
        public IWebDriver driver;
        public ExtentTest test;
        protected Browser browser;
        protected Page pages;
        [SetUp]
        public void initialize()
        {
            browser = new Browser();
            pages = new Page(browser);
           
          

        }


        [TearDown]
        public void AfterTest()
        {
          
           browser.Close();
        }
     
    }

    
}