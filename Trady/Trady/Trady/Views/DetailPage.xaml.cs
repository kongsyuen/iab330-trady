using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Trady.Views
{
    public partial class DetailPage : ContentPage
    {
        private string date;

        public DetailPage(string information)
        {
            InitializeComponent();
        }

        public DetailPage(string information, string date) : this(information)
        {
            this.date = date;
        }
    }
}
