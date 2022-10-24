using OpenQA.Selenium;
using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TestAutomationPractice.Helpers;
using TestAutomationPractice.Pages;

namespace TestAutomationPractice.Steps
{
    [Binding]
    public class PDPSteps : Base
    {
        Utilities ut = new Utilities(Driver);
        HomePage hp = new HomePage(Driver);

        private readonly ProductData productData;

        public PDPSteps(ProductData productData)
        {
            this.productData = productData;
        }

        [Given(@"users opens '(.*)' section")]
        public void GivenUsersOpensSection(string cat)
        {
            hp.ReturnCategoryList(cat)[1].Click();
        }
        
        [Given(@"opens first product from list")]
        public void GivenOpensFirstProductFromList()
        {
            PLPage plp = new PLPage(Driver);
            ut.ClickOnElement(plp.fistProduct);
        }
        
        [Given(@"increases quantity to (.*)")]
        public void GivenIncreasesQuantityTo(string qty)
        {
            //locirali smo i prebacili fokus na novi prozor koji se otvorio
            By iframe = By.ClassName("fancybox-iframe");
            Driver.SwitchTo().Frame(Driver.FindElement(iframe));

            //obrisali smo vrednost za qty i uneli novi qty
            PDPage pdp = new PDPage(Driver);
            Driver.FindElement(pdp.qantitiy).Clear();
            ut.EnterTextInElement(pdp.qantitiy, qty);

            //nova klasa je napravljena i uz pomoc konteks. inj. smo izvukli ime proizvoda da bismo potvrdii kasnije da je bas taj proizvod u korpi
            productData.ProductName = ut.ReturnTextFromElement(pdp.productName);
        }
        
        [When(@"users click on add to cart buton")]
        public void WhenUsersClickOnAddToCartButon()
        {
            PDPage pdp = new PDPage(Driver);
            ut.ClickOnElement(pdp.addToCartBtn);
        }
        
        [When(@"user proceeds to checkout")]
        public void WhenUserProceedsToCheckout()
        {
            PDPage pdp = new PDPage(Driver);
            ut.ClickOnElement(pdp.procedToChck);
        }
        
        [Then(@"cart summary is displayed and product is added to cart")]
        public void ThenCartSummaryIsDisplayedAndProductIsAddedToCart()
        {
            ShoppingCartPage scp = new ShoppingCartPage(Driver);
            Assert.That(ut.ReturnTextFromElement(scp.productName), Is.EqualTo(productData.ProductName), "Product is not added to cart");
        }
    }
}
