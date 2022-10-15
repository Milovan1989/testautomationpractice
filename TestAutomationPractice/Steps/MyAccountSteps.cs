using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TestAutomationPractice.Helpers;
using TestAutomationPractice.Pages;

namespace AutomationPracticeFramework.Steps
{
    [Binding]
    public class MyAccountSteps : Base
    {
        Utilities ut = new Utilities(Driver);
        HomePage hp = new HomePage(Driver);

        [Given(@"user opens sign in page")]
        public void GivenUserOpensSignInPage()
        {
            ut.ClickOnElement(hp.signin);
        }

        [Given(@"enters correct credentials")]
        public void GivenEntersCorrectCredentials()
        {
            AuthPage ap = new AuthPage(Driver);
            ut.EnterTextInElement(ap.username, TestConstants.Username);
            ut.EnterTextInElement(ap.Password, TestConstants.Password); 
        }

        [When(@"user submits the login form")]
        public void WhenUserSubmitsTheLoginForm()
        {
            ut.ClickOnElement(hp.submitSignIn);
        }

        [Then(@"user will be logged in")]
        public void ThenUserWillBeLoggedIn()
        {
            MyAccountPage map = new MyAccountPage(Driver);
            Assert.True((bool)ut.ElementExists(map.signOutbtn), "User is not logged in");
        }
    }
}
