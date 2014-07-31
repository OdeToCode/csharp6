using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LanguageFeatures;

namespace Tests
{
    [TestClass]
    public class User_Test
    {
        [TestMethod]
        public void Every_User_Has_An_Id()
        {
            var user = new User();

            Assert.IsTrue(user.Id != Guid.Empty);

        }
    }
}
