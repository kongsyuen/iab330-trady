using System;
using System.Collections.Generic;
using System.IO;
using Trady.Data;
using Trady.Interface;
using Trady.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XLabs.Ioc;

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


            IItemRepository actorRepository =
                Resolver.Resolve<IItemRepository>();

            actorRepository.DeleteAll();
            actorRepository.InsertAll(LoadData());



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

        #region "LoadData"
        protected IList<Item> LoadData()
        {
            var items = new List<Item>();
            items.Add(new Item
            {
                ID = 0,
                Information = "Second Hand",
                Category = "Accessories",
                Date = "29.09.2019",
                Photo = "A0001.png"
            });

            items.Add(new Item
            {
                ID = 1,
                Information = "Adoption by caring people",

                Category = "Pet",
                Date = "29.09.2019",

                Photo = "A0002.png"

            });

            items.Add(new Item
            {
                ID = 2,
                Information = "Sell",
                Category = "Transportation",
                Date = "29.09.2019",
                Photo = "A0003.png"
            });

            items.Add(new Item
            {
                ID = 3,
                Information = "Second hand for sell",

                Category = "Accessories",
                Date = "29.09.2019",

                Photo = "A0004.png"
            });

            items.Add(new Item
            {
                ID = 4,
                Information = "New product sell",

                Category = "Household",
                Date = "29.09.2019",

                Photo = "A0005.png"
            });
            return items;
        }
        #endregion
    }
}
