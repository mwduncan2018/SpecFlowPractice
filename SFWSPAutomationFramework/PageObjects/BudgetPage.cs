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

        static readonly By TEXTBOX_SALARY = By.Id(@"salary");
        static readonly By TEXTBOX_401K_INVESTMENT = By.Id(@"traditional401k");
        static readonly By TEXTBOX_TAX_RATE = By.Id(@"taxRate");
        static readonly By BTN_CALCULATE = By.Id(@"calculateBudget");
        static readonly By VALIDATION_MESSAGES = By.Id(@"validationMessages");

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

        public static void CalculateBudget()
        {
            Driver.Instance.FindElement(BTN_CALCULATE).Click();
        }

        public static bool VerifyValidationMessage(string message)
        {
            return Driver.Instance.FindElement(VALIDATION_MESSAGES).Text.Contains(message);
        }

    }
}
