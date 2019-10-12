using SFWSPAutomationFramework.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowSpecificationBeta.Hooks
{
    [Binding]
    public sealed class TestRunHooks
    {
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            Driver.Initialize(DriverBrowser.FIREFOX);
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            Driver.Close();
        }
    }
}
