using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SFWSPAutomationFramework.PageObjects
{
    public class HomePage : BasePage
    {
        public static readonly string pageURL = baseURL + @"";

        static readonly By CHECKBOX_MODERN_WARFARE_3 = By.Id(@"checkModernWarfare3");
        static readonly By CHECKBOX_BLACK_OPS = By.Id(@"checkBlackOps");
        static readonly By CHECKBOX_MARIO_PAINT = By.Id(@"checkMarioPaint");
        static readonly By BTN_SUBMIT_GAMES = By.Id(@"btnSubmitGames");
        static readonly By BTN_RESET = By.Id(@"btnResetMessageBoard");

        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl(pageURL);
        }

        public static void CheckModernWarfare3()
        {
            Driver.Instance.FindElement(CHECKBOX_MODERN_WARFARE_3).Click();
        }

        public static void CheckBlackOps()
        {
            Driver.Instance.FindElement(CHECKBOX_BLACK_OPS).Click();
        }

        public static void CheckMarioPaint()
        {
            Driver.Instance.FindElement(CHECKBOX_MARIO_PAINT).Click();
        }

        public static void ClickSubmitGamesButton()
        {
            Driver.Instance.FindElement(BTN_SUBMIT_GAMES).Click();
        }

        public static void ClickResetButton()
        {
            Driver.Instance.FindElement(BTN_RESET).Click();
        }
    }
}
