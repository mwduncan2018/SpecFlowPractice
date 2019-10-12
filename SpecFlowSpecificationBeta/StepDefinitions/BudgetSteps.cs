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
    public sealed class BudgetSteps
    {
        private readonly BudgetData _budgetData;

        public BudgetSteps(BudgetData budgetData)
        {
            _budgetData = budgetData;
        }

        [Given(@"I have navigated to the Budget page")]
        public void GivenIHaveNavigatedToTheBudgetPage()
        {
            BudgetPage.GoTo();
        }

        [Given(@"the salary is not populated")]
        public void GivenTheSalaryIsNotPopulated()
        {
            BudgetPage.Salary = @"";
        }

        [Given(@"the traditional 401k value is not populated")]
        public void GivenTheTraditionalKValueIsNotPopulated()
        {
            BudgetPage.Traditional401k = @"";
        }

        [When(@"the budget is calculated")]
        public void WhenTheBudgetIsCalculated()
        {
            BudgetPage.CalculateBudget();
        }

    }
}
