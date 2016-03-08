using System;
using System.Threading;
using JEHomeTask.Utils;
using OpenQA.Selenium;

namespace JEHomeTask.Pages
{
    internal class MenuOrderPage
    {
        private string addFirstElementCssSelector = ".addButton";
        private string checkoutButtonClass = "checkoutButton";

        public void ChooseItemsAndSubmit()
        {
            IWebElement addFirstMenuItem = BrowserUtils.Browser.FindElement(By.CssSelector(addFirstElementCssSelector));
            IWebElement checkoutButton = BrowserUtils.Browser.FindElement(By.ClassName(checkoutButtonClass));

            while (!checkoutButton.Enabled)
            {
                addFirstMenuItem.Click();
                Thread.Sleep(TimeSpan.FromSeconds(2));
            }
        }

        public void ClickCheckoutButton()
        {
            BrowserUtils.Browser.FindElement(By.ClassName(checkoutButtonClass)).Click();
        }

    }
}