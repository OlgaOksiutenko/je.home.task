using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace JEHomeTask.Utils
{
    public static class BrowserUtils
    {
        private static IWebDriver _browser;

        public static IWebDriver Browser
        {
            get
            {
                return _browser;
            }
        }

        public static void CreateDriver()
        {
            _browser = new FirefoxDriver();
            _browser.Manage().Window.Maximize();
        }

        public static void CloseDriver()
        {
            _browser.Close();
        }
    }
}