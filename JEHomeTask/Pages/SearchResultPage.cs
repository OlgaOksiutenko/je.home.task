using System;
using JEHomeTask.Utils;
using OpenQA.Selenium;

namespace JEHomeTask.Pages
{
    class SearchResultPage 
    {
        public const string viewMenuCssSelector = ".openRestaurants .firstRestaurant .viewMenu";
        public const string restaurantCssSelector = ".openRestaurants .firstRestaurant";
        public const string restaurantClass = "firstRestaurant";
        public const string resultTextID = "searchResultsHeaderInner";

        public bool IsAnyRestaurantExist()
        {
            return BrowserUtils.Browser.FindElement(By.ClassName(restaurantClass)).Displayed;
        }

        public string SearchResultText()
        {
           return BrowserUtils.Browser.FindElement(By.Id(resultTextID)).Text;

        }

        public void ClickOnFirstRestaurantViewButton()
        {
            BrowserUtils.Browser.FindElement(By.CssSelector(viewMenuCssSelector)).Click();
        }
    }
}
