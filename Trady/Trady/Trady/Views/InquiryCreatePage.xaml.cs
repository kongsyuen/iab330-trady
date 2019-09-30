﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Media;
using Plugin.Media.Abstractions;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using Trady.Models;
using Trady.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Trady.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InquiryCreatePage : ContentPage
    {
        InquiryPageViewModel _inquiryList;
        Inquiries _newInquiry;
        public InquiryCreatePage()
        {
            InitializeComponent();
            CategoryPicker.Items.Add("Travel");
            CategoryPicker.Items.Add("Pet");
            CategoryPicker.Items.Add("Item");
            CategoryPicker.Items.Add("Event");
        }

        private MediaFile _photo;

        private void CategoryPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = CategoryPicker.Items[CategoryPicker.SelectedIndex];
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await CrossMedia.Current.Initialize();
            if (!CrossMedia.Current.IsPickPhotoSupported)
            {
                await DisplayAlert("Error", "Your device is not compatible", "Return");
                return;
            }

            _photo = await CrossMedia.Current.PickPhotoAsync();

            if (_photo == null)
            {
                await DisplayAlert("Error", "You haven't selected any photo", "Ok");
                return;
            }

            await PopupNavigation.Instance.PushAsync(new ImagePopUpPage(_photo.Path));

        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            _newInquiry.InquiryName = InquiryName.Text;
            _newInquiry.InquiryDate = InquiryDate.Text;
            _newInquiry.InquiryDetail = InquiryDetail.Text;
            _inquiryList.InquiryList.Add(_newInquiry);
            await Navigation.PushAsync(new Inquiry());
            
        }
    }
}