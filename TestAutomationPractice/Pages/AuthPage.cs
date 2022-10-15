using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestAutomationPractice.Pages
{
    public class AuthPage
    {
        readonly IWebDriver driver;
        public By AuthentificationPage = By.Id("authentication");
        public By username = By.Id("email");
        public By Password = By.Id("passwd");

        public AuthPage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(AuthentificationPage));
        }

    }
}
