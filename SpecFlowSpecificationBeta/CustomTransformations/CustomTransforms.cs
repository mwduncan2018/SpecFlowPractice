using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowSpecificationBeta.CustomTransformations
{
    [Binding]
    public sealed class CustomTransforms
    {

        [StepArgumentTransformation(@"(.* Euros)")]
        public string EurosToDollarTransform(string strEuros)
        {
            Decimal.TryParse(strEuros, out decimal euros);
            return (1.1M * euros).ToString();
        }
    }
}
