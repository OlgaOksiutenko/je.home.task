using JEHomeTask.Utils;
using OpenQA.Selenium;

namespace JEHomeTask.Pages
{
    class PaymentPage
    {
        private string payWithCashID = "Cash-Option";
        private string placeOrderButtonID = "placeOrder";

        public void PayWithCash()
        {
            BrowserUtils.Browser.FindElement(By.Id(payWithCashID)).Click();
            BrowserUtils.Browser.FindElement(By.Id(placeOrderButtonID)).Click();
        }
    }
}
