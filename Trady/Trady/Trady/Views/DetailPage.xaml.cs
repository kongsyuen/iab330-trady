using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Trady.Views;


namespace Trady.Views
{
    
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        public DetailPage(string Information, string date)
        {
            InitializeComponent();

            Title = Information;

            
            
        }
    }
}
