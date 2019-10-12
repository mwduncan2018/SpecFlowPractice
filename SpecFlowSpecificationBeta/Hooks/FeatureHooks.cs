using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowSpecificationBeta.Hooks
{
    [Binding]
    public sealed class FeatureHooks
    {
        [BeforeFeature]
        public static void BeforeFeature()
        {

        }

        [AfterFeature]
        public static void AfterFeature()
        {
            
        }
    }
}
