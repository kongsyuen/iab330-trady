using System;
using System.Collections.Generic;
using Trady.Interface;
using Trady.Models;
using Xamarin.Forms;
using XLabs.Ioc;

namespace Trady.Views
{
    public partial class EditPage : ContentPage
    {
        IItemRepository itemRepository;
        public EditPage(Item item)
        {
            InitializeComponent();
            itemRepository = Resolver.Resolve<IItemRepository>();
            BindingContext = item;
        }
        
        async void Save_Clicked(object sender, EventArgs e)
        {
            var item = BindingContext as Item;
            itemRepository.Update(item);
            await Navigation.PopAsync();
        }
    }
}
