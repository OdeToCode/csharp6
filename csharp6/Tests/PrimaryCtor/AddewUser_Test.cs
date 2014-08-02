using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LanguageFeatures;
using LanguageFeatures.PrimaryCtor;

namespace Tests.PrimaryCtor
{
    [TestClass]
    public class AddewUser_Test
    {
        [TestMethod]
        public void Can_Set_User_And_Creator()
        {
            var newUser = new User();
            var creator = new User();
            var command = new AddUserCommand(newUser, creator);

            Assert.IsTrue(Object.ReferenceEquals(command.NewUser, newUser));
            Assert.IsTrue(Object.ReferenceEquals(command.Creator, creator));
            Assert.AreEqual(command.Creator.Id, command.CreatorId);

        }

        [TestMethod]
        public void Will_Throw_If_No_Creator()
        {
            var threw = false;
            var newUser = new User();

            try
            {
                var command = new AddUserCommand(newUser, null);
            }
            catch (ArgumentNullException)
            {
                threw = true;
            }

            Assert.IsTrue(threw);
        }


        [TestMethod]
        public void Can_Have_Other_Ctors()
        {
            var user = new User();
            var command = new AddUserCommand(user);

            Assert.AreEqual(command.NewUser, command.Creator);
        }
    }
}
