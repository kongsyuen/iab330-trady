using System;
using System.Collections.Generic;
using System.Diagnostics;
using Trady.Interface;
using Trady.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XLabs.Ioc;
using XLabs.Platform.Services.Media;

namespace Trady.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddPage : ContentPage
    {
        private IMediaPicker mediaPicker;
        IItemRepository itemRepository;
        public AddPage()
        {
            InitializeComponent();

            itemRepository =
                Resolver.Resolve<IItemRepository>();
            BindingContext = new Item();

            mediaPicker = Resolver.Resolve<IMediaPicker>();
        }

        //async void btnTakePicture_Clicked(object sender, EventArgs e)
        //{
        //    var mediaFile = await mediaPicker.TakePhotoAsync(new CameraMediaStorageOptions
        //    {
        //        DefaultCamera = CameraDevice.Rear,
        //        MaxPixelDimension = 400
        //    });

        //    Debug.WriteLine($"picture path : {mediaFile.Path}");

        //    imgPhoto.Source = mediaFile.Path;
        //}

        async void btnSelectPicture_Clicked(object sender, EventArgs e)
        {
            var mediaFile = await mediaPicker.SelectPhotoAsync(new CameraMediaStorageOptions());

            Debug.WriteLine($"picture path : {mediaFile.Path}");

            imgPhoto.Source = mediaFile.Path;


        }


        async void Save_Clicked(object sender, EventArgs e)
        {
            var item = BindingContext as Item;
            itemRepository.Insert(item);
            await Navigation.PopAsync();
        }

        void Upload_Clicked(object sender, EventArgs e)
        {

        }

    }
}