using LanguageFeatures.AutoPropInit;
using LanguageFeatures.PrimaryCtor;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using System;

namespace Tests.Interpolation
{
    [TestClass]
    public class String_Interpolation
    {
      
        [TestMethod]
        public void Using_Interpolations()
        {
            var x = 10;
            var y = 12;

            var result2 = "\{y}:\{x}";

            AreEqual("12:10", result2);


            var money = new Money("EUR", 45.3m);

            var result3 = "\{money.Amount:F4} \{money.Currency}";

            AreEqual("45.3000 EUR", result3);

        }
    }
}
