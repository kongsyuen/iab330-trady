using Microsoft.VisualStudio.TestTools.UnitTesting;
using Trady.ViewModels;
namespace Trady.Test
{
    [TestClass]
    public class RegisterPageTest
    {
        [TestMethod]
        public void TestUser1()
        {
            var register = new RegisterPageViewModels();
            //Arrange
            register.UserName = "abc123123";
            register.Password = "abc123123";
            register.Email = "abc@gmail.com";
            //Act
            register.SignUpCommand.Execute(null);
            //Assert
            Assert.AreEqual("abc123123", register.UserName, "errorUN");
            Assert.AreEqual("abc123123", register.Password, "errorPW");
            Assert.AreEqual("abc@gmail.com", register.Email, "errorEM");
        }

        [TestMethod]
        public void TestUser2()
        {
            //Arrange
            var register = new RegisterPageViewModels();
            register.UserName = "abc2222";
            register.Password = "abc2222";
            register.Email = "abc2222@gmail.com";
            //Assert
            Assert.AreEqual("abc2222", register.UserName, "errorUN");
            Assert.AreEqual("abc2222", register.Password, "errorPW");
            Assert.AreEqual("abc2222@gmail.com", register.Email, "errorEM");
        }

        [TestMethod]
        public void TestUser3()
        {
            //Arrange
            var register = new RegisterPageViewModels();
            register.UserName = "abc3333";
            register.Password = "abc3333";
            register.Email = "abc3333@gmail.com";
            //Assert
            Assert.IsFalse(register.UserName.Equals("abc2222"));
            Assert.IsTrue(register.UserName.Equals("abc3333"));
            Assert.IsTrue(register.Email.Equals("abc3333@gmail.com"));
            Assert.IsFalse(register.Email.Equals("abc2222@gmail.com"));
            Assert.IsTrue(register.Password.Equals("abc3333"));
            Assert.IsFalse(register.Password.Equals("abc2222"));
        }
        [TestMethod]
        public void TestPassWordLength()
        {
            //Arrange
            var register = new RegisterPageViewModels();
            register.Password = "123456";
            //Assert
            Assert.IsTrue(register.Password.Length >= 6);
            Assert.IsFalse(register.Password.Length < 6);
        }
    }
}
