using JEHomeTask.Utils;
using OpenQA.Selenium;

namespace JEHomeTask.Pages
{
    internal class DeliveryPage
    {
        private string mobileFieldID = "Phone";
        private string addressID = "Address_Line1";
        private string cityID = "Address_City";
        private string continueButtonClass = "submit";


        public void SetDeliveryData(string number, string address, string city)
        {
            BrowserUtils.Browser.FindElement(By.Id(mobileFieldID)).SendKeys(number);
            BrowserUtils.Browser.FindElement(By.Id(addressID)).SendKeys(address);
            BrowserUtils.Browser.FindElement(By.Id(cityID)).SendKeys(city);
            BrowserUtils.Browser.FindElement(By.ClassName(continueButtonClass)).Click();
        }
    }
}