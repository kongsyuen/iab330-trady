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
    public partial class Inquiry : ContentPage
    {
        public Inquiry()
        {
            InitializeComponent();
        }
        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var inquiryItem = e.Item as Inquiries;

            await Navigation.PushAsync(new InquiryDetail(inquiryItem.InquiryName, inquiryItem.InquiryDate, inquiryItem.InquiryDetail, inquiryItem.InquiryImage));
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InquiryCreatePage());
        }
    }
}