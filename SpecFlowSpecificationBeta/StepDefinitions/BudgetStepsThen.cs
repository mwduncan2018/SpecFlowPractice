using Microsoft.VisualStudio.TestTools.UnitTesting;
using SFWSPAutomationFramework.PageObjects;
using SpecFlowSpecificationBeta.SharedData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowSpecificationBeta.StepDefinitions
{
    [Binding]
    public sealed class BudgetStepsThen
    {
        private readonly BudgetData _budgetData;

        public BudgetStepsThen(BudgetData budgetData)
        {
            _budgetData = budgetData;
        }

        [Then(@"the validation message (.*) is displayed")]
        [Scope(Tag = "BudgetValidations")]
        // This method will only run for the tag "BudgetValidations".
        // If there were multiple methods with this same name that
        // check for validation messages, this method knows
        // how to do that for the Budget page.
        // The Scoped Binding allows this method to only execute
        // for the tag "BudgetValidations".
        public void ThenTheValidationMessageIsDisplayed(string message)
        {
            Assert.IsTrue(BudgetPage.VerifyValidationMessageIsDisplayed(message));
        }

        [Then(@"no validation messages should be displayed")]
        public void ThenNoValidationMessagesShouldBeDisplayed()
        {
            Assert.IsTrue(BudgetPage.VerifyNoValidationMessagesAreDisplayed());
        }

        [Then(@"salary by year should be (.*)")]
        public void ThenSalaryByYearShouldBe(string salaryByYear)
        {
            Assert.IsTrue(BudgetPage.VerifySalaryByYearIs(salaryByYear));
        }

        [Then(@"401k by year should be (.*)")]
        public void ThenKByYearShouldBe(string traditional401kByYear)
        {
            Assert.IsTrue(BudgetPage.Verify401kByYearIs(traditional401kByYear));
        }

        [Then(@"taxes by year should be (.*)")]
        public void ThenTaxesByYearShouldBe(string taxesByYear)
        {
            Assert.IsTrue(BudgetPage.VerifyTaxesByYearIs(taxesByYear));
        }

        [Then(@"cash by year should be (.*)")]
        public void ThenCashByYearShouldBe(string cashByYear)
        {
            Assert.IsTrue(BudgetPage.VerifyCashByYearIs(cashByYear));
        }

    }
}
