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
        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var inquiryItem = e.Item as Inquiries;

            Navigation.PushAsync(new InquiryDetail(inquiryItem.InquiryName, inquiryItem.InquiryDate, inquiryItem.InquiryDetail));
        }
    }
}