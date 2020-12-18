using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace Buildxact.PageAssembly
{
    public class Browser
    {

        private IWebDriver webDriver;
      //  private string baseURL;
        private string browser;
        public Browser()
        {
           // baseURL = url;
            browser = "Chrome";
        }


        /// <summary>
        /// Initialize the Browser
        /// </summary>
        public void Init(string url)
        {
            switch (browser)
            {
                case "Chrome":
                    webDriver = new ChromeDriver();
                    break;
                case "Firefox":
                    webDriver = new FirefoxDriver();
                    break;
                default:
                    webDriver = new ChromeDriver();
                    break;
            }


            Goto(url);


        }


        /// <summary>
        /// return the current driver
        /// </summary>
        /// <returns> return type is IWebdriver</returns>
        public IWebDriver GetDriver()
        {
            return webDriver;
        }


        /// <summary>
        /// get the title of the page
        /// </summary>
        public string Title
        {
            get { return webDriver.Title; }
        }
        public IWebDriver getDriver
        {
            get { return webDriver; }

        }
        /// <summary>
        /// Navigate to the web site
        /// </summary>
        /// <param name="url"></param>
        public void Goto(string url)
        {
            webDriver.Url = url;
        }

        /// <summary>
        /// Close the web driver
        /// </summary>
        public void Close()
        {
            webDriver.Quit();
        }
    }

}