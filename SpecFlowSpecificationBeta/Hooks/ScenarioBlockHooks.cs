using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowSpecificationBeta.Hooks
{
    [Binding]
    public sealed class ScenarioBlockHooks
    {
        [BeforeScenarioBlock]
        public void BeforeScenarioBlock()
        {
        }

        [AfterScenarioBlock]
        public void AfterScenarioBlock()
        {
        }
    }
}
