using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trady.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Trady.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SavelistPage : ContentPage
    {
        public SavelistPage()
        {
            InitializeComponent();
            listview.ItemsSource = LoadData();
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
                Photo = "A0001.png"
            });

            items.Add(new Item
            {

                Information = "Adoption by caring people",

                Category = "Pet",
                Date = "29.09.2019",

                Photo = "A0002.png"

            });

            items.Add(new Item
            {

                Information = "Sell",

                Category = "Transportation",
                Date = "29.09.2019",
                Photo = "A0003.png"
            });

            items.Add(new Item
            {

                Information = "Second hand for sell",

                Category = "Accessories",
                Date = "29.09.2019",

                Photo = "A0004.png"
            });

            items.Add(new Item
            {

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
