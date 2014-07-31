using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LanguageFeatures;
using LanguageFeatures.AutoPropInit;

namespace Tests
{
    [TestClass]
    public class Person_Test
    {
        [TestMethod]
        public void Every_Customer_Has_Orders()
        {
            var p1 = new Person();
            var c1 = new Customer();


            Assert.IsNull(p1.Orders);
            Assert.IsNotNull(c1.Orders);

        }
    }
}
