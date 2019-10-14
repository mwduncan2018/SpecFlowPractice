using System;
using TechTalk.SpecFlow;
using SFWSPAutomationFramework;
using SFWSPAutomationFramework.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SpecFlowSpecificationBeta.StepDefinitions
{
    [Binding]
    public class FooterSteps : Steps
    {
        [Given(@"the web application is at the Home page")]
        [Given(@"I have navigated to the SpecFlowWebSiteProject website")]
        public void GivenTheWebApplicationIsAtTheHomePage()
        {
            HomePage.GoTo();
        }
        
        [Then(@"the footer should contain the name (.*)")]
        public void ThenTheFooterShouldContainTheName(string name)
        {
            Assert.IsTrue(HomePage.VerifyFooterContainsTheText(name));
        }

        [Then(@"the footer should contain the current year")]
        public void ThenTheFooterShouldContainTheCurrentYear()
        {
            Assert.IsTrue(HomePage.VerifyFooterContainsTheCurrentYear());
        }

        [Then(@"the footer should not contain the name (.*)")]
        public void ThenTheFooterShouldNotContainTheName(string name)
        {
            Assert.IsFalse(HomePage.VerifyFooterContainsTheText(name));
        }
    }
}
