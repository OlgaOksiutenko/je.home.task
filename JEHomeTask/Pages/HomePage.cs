using System;
using JEHomeTask.Utils;
using OpenQA.Selenium;

namespace JEHomeTask.Pages
{
    class HomePage
    {
        private const String inputFieldID = "where";
        private const String searchButtonID = "btnSearch";
        private string errorMessageClass = "error";

        public void NavigateToPage()
        {
            BrowserUtils.Browser.Url = "http://www.just-eat.co.uk/";
        }

        public void SetPostcode(String postcode)
        {
            BrowserUtils.Browser.FindElement(By.Id(inputFieldID)).SendKeys(postcode);
        }

        public void ClickSearchButton()
        {
            BrowserUtils.Browser.FindElement(By.Id(searchButtonID)).Click();
        }

        public bool IsErrorMessageDisplayed()
        {
            return BrowserUtils.Browser.FindElement(By.ClassName(errorMessageClass)).Displayed;

        }
    }
}
