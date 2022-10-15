using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestAutomationPractice.Pages
{
    public class MyAccountPage
    {
        readonly IWebDriver driver;
        public By myAccountPage = By.Id("my-account");
        public By signOutbtn = By.ClassName("logout");

        public MyAccountPage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(myAccountPage));
        }

    }
}
