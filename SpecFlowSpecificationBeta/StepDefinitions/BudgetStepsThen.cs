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

        [Then(@"the validation message '(.*)' is displayed")]
        [Scope(Tag = "BudgetValidations")]
        // This method will only run for the tag "BudgetValidations".
        // If there were multiple methods with this same name that
        // check for validation messages, this method knows
        // how to do that for the Budget page.
        // The Scoped Binding allows this method to only execute
        // for the tag "BudgetValidations".
        public void ThenTheValidationMessageIsDisplayed(string message)
        {
            BudgetPage.VerifyValidationMessage(message);
        }
    }
}
