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
            decimal euros;
            Decimal.TryParse(strEuros, out euros);
            decimal dollars = 1.1M * euros;
            string strDollars = dollars.ToString();
            return strDollars;
        }
    }
}
