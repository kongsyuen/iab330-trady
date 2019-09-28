using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Test : ContentPage
    {
        ViewModel viewModel = new ViewModel();
        public Test()
        {
            InitializeComponent();
        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var property = e.Item as Property;

            await Navigation.PushAsync(new PropertyDetail(property.Category, property.Date, property.Description));
        }

        private void SearchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            var keyword = SearchBar.Text;

            var suggestion = viewModel.Properties.Where(p => p.Category.Contains(keyword));

            PropertyList.ItemsSource = suggestion;
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            var keyword = SearchBar.Text;

            var suggestion = viewModel.Properties.Where(p => p.Category.ToLower().Contains(keyword.ToLower()));

            PropertyList.ItemsSource = suggestion;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Inquiry());
        }
    }
}