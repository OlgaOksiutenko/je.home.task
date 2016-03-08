using System;
using JEHomeTask.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace JEHomeTask.Tests
{
    [Binding]
    public class OrderTestSteps
    {
        [When(@"I select first restaurant")]
        public void WhenISelectFirstRestaurant()
        {
            SearchResultPage searchResult = new SearchResultPage();
            searchResult.ClickOnFirstRestaurantViewButton();
        }
        
        [When(@"I add items to basket")]
        public void WhenIAddItemsToBasket()
        {
            MenuOrderPage menuOrder = new MenuOrderPage();
            menuOrder.ChooseItemsAndSubmit();
        }
        
        [When(@"I proceed with checkout")]
        public void WhenIProceedWithCheckout()
        {
            MenuOrderPage menuOrder = new MenuOrderPage();
            menuOrder.ClickCheckoutButton();
        }
        
        [When(@"I login with ""(.*)"" and ""(.*)""")]
        public void WhenILoginWithAnd(string email, string password)
        {
            LoginPage login = new LoginPage();
            login.LoginWithUser(email, password);
        }
        
        [When(@"I fill in delivery details with data:")]
        public void WhenIFillInDeliveryDetailsWithData(Table table)
        {
            string mobile = GetKeyValueFromTable(table, "mobile");
            string address = GetKeyValueFromTable(table, "address");
            string city = GetKeyValueFromTable(table, "city");

            DeliveryPage deliveryPage = new DeliveryPage();
            deliveryPage.SetDeliveryData(mobile, address, city);

        }
        
        [When(@"I proceed to confirmation time and date")]
        public void WhenIProceedToConfirmationTimeAndDate()
        {
            ConfirmPage confirm = new ConfirmPage();
            confirm.ConfirmOrder();
        }
        
     
        [When(@"I choose pay with cash")]
        public void WhenIChoosePayWithCash()
        {
            PaymentPage paymentPage = new PaymentPage();
            paymentPage.PayWithCash();
        }
        
        [Then(@"I see confirmation message")]
        public void ThenISeeConfirmationMessage()
        {
            OrderConfirmationPage orderConfirmation = new OrderConfirmationPage();
            Assert.IsTrue(orderConfirmation.IsMessageDisplayed());
        }

        private string GetKeyValueFromTable(Table table, string key)
        {
            var value = string.Empty;
            foreach (var row in table.Rows)
            {
                if (row[0].Equals(key, StringComparison.OrdinalIgnoreCase))
                {
                    value = row[1];
                    break;
                }
            }
            return value;
        }

    }
}
