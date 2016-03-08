using JEHomeTask.Utils;
using OpenQA.Selenium;

namespace JEHomeTask.Pages
{
    class ConfirmPage
    {
        private string confirmButtonClass = "submit";

        public void ConfirmOrder()
        {
            BrowserUtils.Browser.FindElement(By.ClassName(confirmButtonClass)).Click();
        }
    }
}