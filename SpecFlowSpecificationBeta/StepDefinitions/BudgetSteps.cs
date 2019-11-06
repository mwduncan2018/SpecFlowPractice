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

        [Given(@"I have navigated to the budget page")]
        public void GivenIHaveNavigatedToTheBudgetPage()
        {
            BudgetPage.GoTo();
        }

        [Given(@"the salary is not populated")]
        public void GivenTheSalaryIsNotPopulated()
        {
            BudgetPage.Salary = @"";
        }

        [Given(@"the traditional 401k is not populated")]
        public void GivenTheTraditional401kIsNotPopulated()
        {
            BudgetPage.Traditional401k = @"";
        }

        [Given(@"the tax rate is not populated")]
        public void GivenTheTaxRateIsNotPopulated()
        {
            BudgetPage.TaxRate = @"";
        }

        [Given(@"the salary is set to (.*)")]
        public void GivenTheSalaryIsSetTo(string salary)
        {
            BudgetPage.Salary = salary;
        }


        [Given(@"the tax rate is set to (.*)")]
        public void GivenTheTaxRateIsSetTo(string taxRate)
        {
            BudgetPage.TaxRate = taxRate;
        }

        [Given(@"the traditional 401k is set to (.*)")]
        public void GivenTheTraditionalKIsSetTo(string traditional401k)
        {
            BudgetPage.Traditional401k = traditional401k;
        }

        [When(@"the budget is calculated")]
        public void WhenTheBudgetIsCalculated()
        {
            BudgetPage.CalculateBudget();
        }https://www.pornhub.com/view_video.php?viewkey=ph5da0bdc65387a

        [Given(@"I have entered (.* Euros)")]
        public void GivenIHaveEnteredEuros(string dollars)
        {
            BudgetPage.Salary = dollars.ToString();
        }

    }
}
