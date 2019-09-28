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
    public partial class PropertyDetail : ContentPage
    {
        public PropertyDetail(string Category, string Date, string Description)
        {
            InitializeComponent();
            CategoryName.Text = Category;
            DateName.Text = Date;
            DescriptionName.Text = Description;
        }
    }
}