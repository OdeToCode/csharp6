using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LanguageFeatures.DeclExpression;

namespace Tests.DeclExpression
{
    [TestClass]
    public class DeclExpression_Tests
    {
        [TestMethod]
        public void Can_Parse()
        {
            var result = new TryDecl().WithParsing("123");
            Assert.AreEqual(123, result);
        }

        [TestMethod]
        public void Can_Use_In_ForEach()
        {
            var result = new TryDecl().WithLinq(new[] { 1, 2, 3, 4, 5 });
            Assert.AreEqual(18, result);
        }
    }
}
