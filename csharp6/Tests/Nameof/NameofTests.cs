using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using System;

namespace Tests.Name_Of
{
    [TestClass]
    public class Name_Of_Tests
    {
        [TestMethod]
        public void Using_nameof()
        {
            var x = 42;
            AreEqual("x", nameof(x));

            AreEqual("GetType", nameof(Int32.GetType));

            AreEqual("Name_Of_Tests", nameof(Name_Of_Tests));

            AreEqual("Name_Of_Tests", nameof(Tests.Name_Of.Name_Of_Tests));

            AreEqual("Name_Of", nameof(Tests.Name_Of));
        }

        [TestMethod]
        public void Can_Name_Methods()
        {
            AreEqual("Can_Name_Methods", nameof(Name_Of_Tests.Can_Name_Methods));
        }

        [TestMethod]
        public void Can_Name_Parameter()
        {
            var result = GetParameter(42);
            AreEqual("x", result);
            AreEqual("GetParameter", nameof(GetParameter));
        }

     
        [TestMethod]
        public void Generics()
        {
            AreEqual("List", nameof(System.Collections.Generic.List));
        }

        string GetParameter(int x)
        {
            return nameof(x);
        }
    }
}
