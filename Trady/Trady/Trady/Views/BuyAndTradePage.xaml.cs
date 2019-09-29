﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Trady.Models.Item;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Trady.Models;

namespace Trady.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BuyAndTradePage : ContentPage
    {
        public BuyAndTradePage()
        {
            InitializeComponent();
            listview.ItemsSource = LoadData();
        }
        void OnSearchBarButtonPressed(object sender, EventArgs e)
        {
            
        }

        async private void AddPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddPage());
        }
        #region "LoadData"
        protected IList<Item> LoadData()
        {
            var items = new List<Item>();
            items.Add(new Item
            {
                Information = "Second Hand",
                Category = "Accessories",
                Date = "29.09.2019",
                Photo = ImageSource.FromFile("A0001.png")
            });

            items.Add(new Item
            {

                Information = "Adoption by caring people",

                Category = "Pet",
                Date = "29.09.2019",

                Photo = ImageSource.FromFile("A0002.png")

            });

            items.Add(new Item
            {

                Information = "Sell",

                Category = "Transportation",
                Date = "29.09.2019",
                Photo = ImageSource.FromFile("A0003.png")
            });

            items.Add(new Item
            {

                Information = "Second hand for sell",

                Category = "Accessories",
                Date = "29.09.2019",

                Photo = ImageSource.FromFile("A0004.png")
            });

            items.Add(new Item
            {

                Information = "New product sell",

                Category = "Household",
                Date = "29.09.2019",

                Photo = ImageSource.FromFile("A0005.png")
            });
            return items;
        }
        #endregion
    }
}