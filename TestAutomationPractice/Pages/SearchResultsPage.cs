using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestAutomationPractice.Pages
{
    public class SearchResultPages
    {
        readonly IWebDriver driver;

        public By searchPage = By.Id("search");
        public By searchResult = By.ClassName("lighter");
        
        public SearchResultPages(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(searchPage));
        }
    }
}
