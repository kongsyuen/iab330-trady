using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trady.Interface;
using Trady.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XLabs.Ioc;

namespace Trady.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BuyAndTradePage : ContentPage
    {
                    IItemRepository itemRepository;

        public BuyAndTradePage()
        {
            InitializeComponent();
            listview.ItemsSource = LoadData();

            itemRepository =
                Resolver.Resolve<IItemRepository>();
            ToolbarItems.Add(new ToolbarItem("Add", "", async () =>
            {
                await Navigation.PushAsync(new AddPage());
            }));
        }


        protected override void OnAppearing()
        {
            listview.ItemsSource = itemRepository.GetAll();
            base.OnAppearing();
        }



        void OnSearchBarButtonPressed(object sender, EventArgs e)
        {
            
        }

        async private void AddPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddPage());
        }
        async void Handle_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            var items = e.Item as Item;
            await Navigation.PushAsync(new DetailPage(items));
        }
        //async void Edit_Clicked(object sender, EventArgs e)
        //{
        //    var mi = ((MenuItem)sender);
        //    var actor = mi.CommandParameter as Item;

        //    await Navigation.PushAsync(new EditPage(item));
        //}

        //void Delete_Clicked(object sender, EventArgs e)
        //{
        //    var mi = ((MenuItem)sender);
        //    var actor = mi.CommandParameter as Item;

        //    itemRepository.Delete(actor);
        //    listview.ItemsSource = itemRepository.GetAll();

        //}


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