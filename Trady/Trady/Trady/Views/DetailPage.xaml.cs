using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Trady.Views;
using Trady.Models;

namespace Trady.Views
{
    
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        public DetailPage(Item items)
        {
            InitializeComponent();

            Title = items.Information;
            webview.Source =
                string.Format("https://www.google.com");



        }
    }
}
