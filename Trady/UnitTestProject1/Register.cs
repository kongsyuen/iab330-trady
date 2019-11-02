using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Trady.ViewModels;

namespace UnitTestProject1
{
    [TestClass]
    public class Register
    {
        [TestMethod]
        public void TestUser1()
        {
            //Arrange
            var register = new RegisterPageViewModels();
            register.UserName = "abc123123";
            register.Password = "abc123123";
            register.Email = "abc@gmail.com";
            // Act
            register.SignUpCommand.Execute(null);
            //Assert
            Assert.AreEqual("abc123123",register.UserName,"errorUN");
            Assert.AreEqual("abc123123", register.Password, "errorPW");
            Assert.AreEqual("abc@gmail.com", register.Email, "errorEM");
        }

        [TestMethod]
        public void TestUser2()
        {
            //Arrange
            var register = new RegisterPageViewModels();
            register.UserName = "abc2";
            register.Password = "abc2";
            register.Email = "abc2@gmail.com";
            // Act
            register.SignUpCommand.Execute(null);
            //Assert
            Assert.AreEqual("abc2", register.UserName, "errorUN");
            Assert.AreEqual("abc2", register.Password, "errorPW");
            Assert.AreEqual("abc2@gmail.com", register.Email, "errorEM");
        }
    }
}
