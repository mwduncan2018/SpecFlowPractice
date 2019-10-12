using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SFWSPAutomationFramework.PageObjects
{
    public enum DriverBrowser
    {
        FIREFOX,
        CHROME,
        INTERNET_EXPLORER
    }

    public static class Driver
    {
        public static IWebDriver Instance { get; set; }

        public static void Initialize(DriverBrowser driverBrowser)
        {
            if (Instance is null)
            {
                if (driverBrowser == DriverBrowser.FIREFOX)
                {
                    Instance = new FirefoxDriver(@"C:\dev\Webdrivers\");
                }
            }
        }

        public static void Close()
        {
            Instance.Close();
            Instance = null;
        }


    }
}