using System;
using System.IO;
using Trady.Data;
using Trady.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Trady
{
    public partial class App : Application
    {
        static UserDatabase database;

        public static User CurrentUser { get; set; }

        public static string CurrentUserName { get; set; }

        public static UserDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new UserDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "UserDB.db3"));
                }
                return database;
            }
        }

        public App()
        {

            var databasePath = "";
            var sqlite = new SQLite.SQLiteConnection(databasePath);
            InitializeComponent();

            MainPage = new NavigationPage(new Views.LogInPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
