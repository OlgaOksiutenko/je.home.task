using JEHomeTask.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace JEHomeTask.Tests
{
    [Binding]
    public class SearchTestsSteps
    {
        [Given(@"I want food in ""(.*)""")]
        public void GivenIWantFoodIn(string postcode)
        {
            HomePage homePage = new HomePage();
            homePage.NavigateToPage();
            homePage.SetPostcode(postcode);
        }

        [When(@"I search for restaurants")]
        public void WhenISearchForRestaurants()
        {
            HomePage homePage = new HomePage();
            homePage.ClickSearchButton();
        }

        [Then(@"I should see some restaurants in ""(.*)""")]
        public void ThenIShouldSeeSomeRestaurantsIn(string postcode)
        {
            SearchResultPage resultPage = new SearchResultPage();
            Assert.AreEqual(true, resultPage.IsAnyRestaurantExist());
            Assert.IsTrue(resultPage.SearchResultText().Contains(postcode));
        }
    }
}
