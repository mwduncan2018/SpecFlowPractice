using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFWSPAutomationFramework.PageObjects
{
    public class BudgetPage : BasePage
    {
        public static readonly string pageURL = baseURL + @"/Home/Budget";

        // Input textboxes and submit button
        static readonly By TEXTBOX_SALARY = By.Id(@"salary");
        static readonly By TEXTBOX_401K_INVESTMENT = By.Id(@"traditional401k");
        static readonly By TEXTBOX_TAX_RATE = By.Id(@"taxRate");
        static readonly By BTN_CALCULATE = By.Id(@"calculateBudget");

        // Validation messages are found here
        static readonly By VALIDATION_MESSAGES = By.CssSelector(@"#validationMessages p");

        // Salary results
        static readonly By SALARY_BY_YEAR = By.Id(@"salaryByYear");

        // 401k results
        static readonly By TRADITIONAL_401K_BY_YEAR = By.Id(@"investByYear");

        // Tax results
        static readonly By TAXES_BY_YEAR = By.Id(@"taxesByYear");

        // Cash results
        static readonly By CASH_BY_YEAR = By.Id(@"cashByYear");


        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl(pageURL);
        }

        public static string Salary
        {
            get { return Driver.Instance.FindElement(TEXTBOX_SALARY).Text; }
            set { Driver.Instance.FindElement(TEXTBOX_SALARY).SendKeys(value); }
        }
        public static string Traditional401k
        {
            get { return Driver.Instance.FindElement(TEXTBOX_401K_INVESTMENT).Text; }
            set { Driver.Instance.FindElement(TEXTBOX_401K_INVESTMENT).SendKeys(value); }
        }
        public static string TaxRate
        {
            get { return Driver.Instance.FindElement(TEXTBOX_TAX_RATE).Text; }
            set { Driver.Instance.FindElement(TEXTBOX_TAX_RATE).SendKeys(value); }
        }

        public static void CalculateBudget()
        {
            Driver.Instance.FindElement(BTN_CALCULATE).Click();
        }

        public static bool VerifySalaryByYearIs(string salaryByYear)
        {
            return Driver.Instance.FindElement(SALARY_BY_YEAR)
                .Text.Equals(salaryByYear, StringComparison.Ordinal);
        }

        public static bool Verify401kByYearIs(string traditional401kByYear)
        {
            return Driver.Instance.FindElement(TRADITIONAL_401K_BY_YEAR)
                .Text.Equals(traditional401kByYear, StringComparison.Ordinal);
        }

        public static bool VerifyValidationMessageIsDisplayed(string message)
        {
            return Driver.Instance.FindElements(VALIDATION_MESSAGES).Select(x => x.Text).Contains(message);
        }

        public static bool VerifyTaxesByYearIs(string taxesByYear)
        {
            return Driver.Instance.FindElement(TAXES_BY_YEAR)
                .Text.Equals(taxesByYear, StringComparison.Ordinal);
        }

        public static bool VerifyCashByYearIs(string cashByYear)
        {
            var result = Driver.Instance.FindElement(CASH_BY_YEAR)
                .Text.Equals(cashByYear, StringComparison.Ordinal);

            return result;
        }

        public static bool VerifyNoValidationMessagesAreDisplayed()
        {
            return Driver.Instance.FindElements(VALIDATION_MESSAGES).Count == 0;
        }

    }
}
