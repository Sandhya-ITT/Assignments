using ClassLibUnitTest.PageObjects;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace ClassLibUnitTest.StepDefinition
{
    [Binding]
    public class VerifyingProductIsRemovedFromCartSteps
    {
        IWebDriver driver;
        HomePage page = new HomePage();

        [When(@"User clicks on carticon")]
        public void WhenUserClicksOnCarticon()
        {
            page.ClickOnCartIcon();
        }
        
        [When(@"User clicks on remove button")]
        public void WhenUserClicksOnRemoveButton()
        {
            page.RemoveTheItemFromCart();
        }
        
        [Then(@"The product should be successfully removed from cart")]
        public void ThenProductShouldBeSuccessfullyRemovedFromCart()
        {
            page.ProductRemovedFromCart();
        }
    }
}
