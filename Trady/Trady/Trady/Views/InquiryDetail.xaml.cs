using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Trady.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InquiryDetail : ContentPage
    {
        public InquiryDetail(string InquiryName, string InquiryDate, string InquiryDetail, string InquiryImage)
        {
            InitializeComponent();
            CategoryName.Text = InquiryName;
            DateName.Text = InquiryDate;
            DescriptionName.Text = InquiryDetail;
            ImageSource.Source = InquiryImage;
            Title = InquiryName;
        }
    }
}