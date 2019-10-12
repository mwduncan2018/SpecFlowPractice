using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowSpecificationBeta.Hooks
{
    [Binding]
    public sealed class StepHooks
    {
        [BeforeStep]
        public void BeforeStep()
        {
        }

        [AfterStep]
        public void AfterStep()
        {
        }
    }
}
