using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestAutomationPractice.Pages
{
    public class AuthPage
    {
        readonly IWebDriver driver;

        public By authentificationPage = By.Id("authentication");
        public By username = By.Id("email");
        public By password = By.Id("passwd");
        public By email = By.Id("email_create");
        public By createAcc = By.Id("SubmitCreate");

        public AuthPage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(authentificationPage));
        }

    }
}
