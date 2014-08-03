using LanguageFeatures.PrimaryCtor;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.PrimaryCtor
{
    [TestClass]
    public class Money_Tests
    {
        [TestMethod]
        public void Can_Add_Money()
        {
            var m1 = new Money("usd", 1.0m);
            var m2 = new Money("usd", 1.0m);
            var m3 = m1 + m2;

            Assert.AreEqual(2.0m, m3.Amount);
        }

        [TestMethod]
        public void Throws_When_Different_Currency()
        {
            var m1 = new Money("usd", 1.0m);
            var m2 = new Money("nok", 1.0m);
            var threw = false;

            try
            {
                var m3 = m1 + m2;
            }
            catch (InvalidOperationException)
            {
                threw = true;
            }

            Assert.IsTrue(threw);
        }
    }
}
