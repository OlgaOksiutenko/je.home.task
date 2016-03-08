using JEHomeTask.Utils;
using OpenQA.Selenium;

namespace JEHomeTask.Pages
{
    class OrderConfirmationPage
    {
        private string successfullMessageClass = "orderConfirmation";

        public bool IsMessageDisplayed()
        {
           return BrowserUtils.Browser.FindElement(By.ClassName(successfullMessageClass)).Displayed;

        }
    }
    
}
