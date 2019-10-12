using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowSpecificationBeta.Hooks
{
    [Binding]
    public sealed class ScenarioHooks
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
        }

        [AfterScenario]
        public void AfterScenario()
        {
        }
    }
}
