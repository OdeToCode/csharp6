using System.Linq;
using LanguageFeatures;
using LanguageFeatures.Initializers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
 
namespace Tests.Initializers
{
    [TestClass]
    public class Initializer_Tests
    {
        [TestMethod]
        public void Can_Add_Users_With_Initializer()
        {
            var store = new UserStore
            {
                new User(), new User(), new User()
            };

            Assert.AreEqual(3, store.Count());
        }

        //[TestMethod]
        //public void Can_Wire_Event_In_Initializer()
        //{
        //    var count = 0;
        //    var store = new UserStore
        //    {
        //        UserAdded = (o, e) => { count++; }
        //    };

        //    Assert.AreEqual(3, store.Count());
        //}
    }
}
