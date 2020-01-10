using ClassLibUnitTest.PageObjects;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace ClassLibUnitTest.StepDefinition
{
    [Binding]

    public class VerifyingCartFunctionalitySteps
    {
        IWebDriver driver;
        HomePage page = new HomePage();

        [When(@"User navigates to HomePage")]
        public void WhenUserNavigatesToHomePage()
        {
            Console.WriteLine("Home page is displayed");
        }

        [When(@"User searches for ""(.*)""")]
        public void WhenUserSearchesFor(string searchString)
        {
            page.SearchBox(searchString);
        }

        [When(@"User adds the product to cart")]
        public void WhenUserAddsTheProductToCart()
        {
            page.AddingProductToCart();
        }

        [When(@"User removes the product from cart")]
        public void WhenUserRemovesTheProductFromCart()
        {
            page.RemoveTheItemFromCart();
        }

        [Then(@"Product should be added to cart")]
        public void ThenProductShouldBeAddedToCart()
        {
            page.ProductToBeDispalyed();
        }
    }
}
