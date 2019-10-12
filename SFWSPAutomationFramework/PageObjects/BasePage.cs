using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SFWSPAutomationFramework.PageObjects
{
    public class BasePage
    {
        public static readonly string baseURL = @"http://localhost:1234/";

        static readonly By FOOTER = By.Id("footer");
        
        public static bool VerifyFooterContainsTheText(string text)
        {
            var footerText = Driver.Instance.FindElement(FOOTER).Text;
            return footerText.Contains(text);
        }

        public static bool VerifyFooterContainsTheCurrentYear()
        {
            var footerText = Driver.Instance.FindElement(FOOTER).Text;
            return footerText.Contains(DateTime.Now.Year.ToString());
        }

    }
}
