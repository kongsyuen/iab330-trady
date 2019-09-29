﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Trady.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChoosePage : ContentPage
    {
        public ChoosePage()
        {
            InitializeComponent();
        }
        async private void Button_Clicked(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BuyAndTradePage());
        }

        async private void Inquiries_Clicked(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Inquiry());
        }
    }
}