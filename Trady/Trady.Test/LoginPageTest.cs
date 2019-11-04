using Microsoft.VisualStudio.TestTools.UnitTesting;
using Trady.ViewModels;

namespace Trady.Test
{
    [TestClass]
    public class LoginPageTest
    {
        [TestMethod]
        public void Login()
        {
            var UserRegis = new RegisterPageViewModels();
            var UserLogin1 = new LoginPageViewModels();
            //Arrange
            UserRegis.UserName = "username";
            UserRegis.Password = "password";
            UserLogin1.UserName = "username";
            UserLogin1.Password = "password";
            //Act
            UserRegis.SignUpCommand.Execute(null);
            UserLogin1.LoginCommand.Execute(null);
            //Assert
            Assert.IsTrue(UserRegis.UserName.Equals(UserLogin1.UserName) && UserRegis.Password.Equals(UserLogin1.Password));
        }

        [TestMethod]
        public void ShouldNotAllowLogin()
        {
            var UserRegis = new RegisterPageViewModels();
            var UserLogin1 = new LoginPageViewModels();
            //Arrange
            UserRegis.UserName = "username";
            UserRegis.Password = "password";
            UserLogin1.UserName = "username";
            UserLogin1.Password = "Badpassword";
            //Act
            UserRegis.SignUpCommand.Execute(null);
            UserLogin1.LoginCommand.Execute(null);
            //Assert
            Assert.IsFalse(UserRegis.UserName.Equals(UserLogin1.UserName) && UserRegis.Password.Equals(UserLogin1.Password));
        }
    }
}
