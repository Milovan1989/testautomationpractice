﻿using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using TestAutomationPractise.Helpers;
using TestAutomationPractise.Pages;

namespace TestAutomationPractise.Steps
{
    [Binding]
    public class FooterSteps : Base
    {
        FooterPage fp = new FooterPage(Driver);

        [When(@"user clicks on '(.*)' option")]
        public void WhenUserClicksOnOption(string link)
        {
            fp.ClickOnInformationLink(link);
        }

        [Then(@"correct '(.*)' is displayed")]
        public void ThenCorrectIsDisplayed(string page)
        {
            Assert.True(fp.InformationPageIsDisplayed(page), "Expected page is NOT displayed");
        }
    }
}