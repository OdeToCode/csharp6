using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace Tests.Nameof
{
    [TestClass]
    public class NameofTests
    {
        [TestMethod]
        public void Can_Name_Local()
        {
            var x = 42;

            AreEqual("x", nameof(x));
        }

        [TestMethod]
        public void Can_Name_Methods()
        {
            AreEqual("Can_Name_Methods", nameof(NameofTests.Can_Name_Methods));
        }

        [TestMethod]
        public void Can_Name_Parameter()
        {
            var result = GetParameter(42);
            AreEqual("x", result);
            AreEqual("GetParameter", nameof(GetParameter));
        }

        [TestMethod]
        public void Can_Name_Class()
        {
            AreEqual("NameofTests", nameof(NameofTests));
        }

        // todo: overloaded methods, namespace, "hello"

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
