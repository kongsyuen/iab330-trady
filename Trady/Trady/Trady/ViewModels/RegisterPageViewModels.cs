using Trady.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace Trady.ViewModels
{
    /// <summary>
    /// ViewModel for sign-up page.
    /// </summary>
    [Preserve(AllMembers = true)]
    public class RegisterPageViewModels : TradyBaseViewModels
    {
        private string email;

        private string password;

        /// <summary>
        /// Initializes a new instance for the <see cref="SimpleSignUpPageViewModel" /> class.
        /// </summary>
        public RegisterPageViewModels()
        {
            this.SignUpCommand = new Command(this.SignUpClicked);
        }

        /// <summary>
        /// Gets or sets the property that bounds with an entry that gets the name from user in the Sign Up page.
        /// </summary>
        public string Email
        {
            get
            {
                return this.email;
            }

            set
            {
                if (this.email == value)
                {
                    return;
                }

                this.email = value;
                this.OnPropertyChanged(nameof(Email));
            }
        }

        /// <summary>
        /// Gets or sets the property that bounds with an entry that gets the password from users in the Sign Up page.
        /// </summary>
        public string Password
        {
            get
            {
                return this.password;
            }

            set
            {
                if (this.password == value)
                {
                    return;
                }

                this.password = value;
                this.OnPropertyChanged(nameof(Password));
            }
        }

        /// <summary>
        /// Gets or sets the command that is executed when the Sign Up button is clicked.
        /// </summary>
        public Command SignUpCommand { get; set; }

        private async void SignUpClicked(object obj)
        {
            try
            {
                if (UserName.Length < 6 )
                {
                    await Application.Current.MainPage.DisplayAlert("Sorry!", "Username is invalid or not given!", "OK");
                    return;
                }

                if (Email.Length == 0  && (!(Email.Contains("@")) ))
                {
                    await Application.Current.MainPage.DisplayAlert("Sorry!", "Please type in your email!", "OK");
                    return;
                }

                if (Password.Length < 6)
                {
                    await Application.Current.MainPage.DisplayAlert("Sorry!", "Password is invalid or not given!", "OK");
                    return;
                }
                else
                {
                    User user = new User
                    {
                        UserName = UserName,
                        Email = Email,
                        Password = Password
                    };

                    await App.Database.SaveUserAsync(user);
                    Application.Current.MainPage = new NavigationPage(new Views.LogInPage());
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Sorry! There was an error: {ex.Message}");
            }

        }

    }
}