using JEHomeTask.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace JEHomeTask.Tests
{
    [Binding]
    public class SearchWithInvalidPostcodeTestSteps
    {
        [Given(@"I want see restaurants in ""(.*)""")]
        public void GivenIWantSeeRestaurantsIn(string postcode)
        {
            HomePage homePage = new HomePage();
            homePage.NavigateToPage();
            homePage.SetPostcode(postcode);
        }
        
        [When(@"I search for restaurant")]
        public void WhenISearchForRestaurant()
        {
            HomePage homePage = new HomePage();
            homePage.ClickSearchButton();
        }
        
        [Then(@"I sould see validation message")]
        public void ThenISouldSeeValidationMessage()
        {
            HomePage homePage = new HomePage();
            Assert.IsTrue(homePage.IsErrorMessageDisplayed());
        }
    }
}
