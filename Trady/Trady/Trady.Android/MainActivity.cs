using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using XLabs.Platform.Services.Media;
using Trady.Interface;
using Trady.SQLiteRepository;

namespace Trady.Droid
{
    [Activity(Label = "Trady", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            SetIoc();
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;


            var databasePath =
                System.IO.Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments), "database.db3");

            var resolverContainer = new XLabs.Ioc.Unity.UnityDependencyContainer();

            resolverContainer.Register<IItemRepository>(new ItemRepository(databasePath));

            XLabs.Ioc.Resolver.SetResolver(resolverContainer.GetResolver());

            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());

            Rg.Plugins.Popup.Popup.Init(this, savedInstanceState);
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
        private void SetIoc()
        {
            var resolverContainer = new global::XLabs.Ioc.SimpleContainer();
            resolverContainer
                .Register<IMediaPicker, MediaPicker>();

            XLabs.Ioc.Resolver.SetResolver(resolverContainer.GetResolver());
        }
    }
}