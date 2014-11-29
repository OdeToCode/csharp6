using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace Tests.Templates
{
    [TestClass]
    public class MyTestClass
    {
        [TestMethod]
        public void Simple_Interpolation()
        {
            var x = 10;
            var y = 12;
            var result = "\{y}:\{x}";
            AreEqual("12:10", result);
        }
    }
}
