using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trady.Models;
using Trady.Interface;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XLabs.Ioc;

namespace Trady.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inquiry : ContentPage
    {
        InquiryRepository inquiryRepository;
        public Inquiry()
        {
            InitializeComponent();
            listview.ItemsSource = LoadData();

            inquiryRepository =
                Resolver.Resolve<InquiryRepository>();
            ToolbarItems.Add(new ToolbarItem("Add", "", async () =>
            {
                await Navigation.PushAsync(new InquiryCreatePage());
            }));

        }
        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var inquiryItem = e.Item as InquiryEntity;

            await Navigation.PushAsync(new InquiryDetail(inquiryItem.InquiryName, inquiryItem.InquiryDate, inquiryItem.InquiryDetail, inquiryItem.InquiryImage));
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InquiryCreatePage());
        }

        protected IList<InquiryEntity> LoadData()
        {
            var items = new List<InquiryEntity>();
            items.Add(new InquiryEntity
            {
                InquiryName = "Travel",
                InquiryDate = "12/1/2018",
                InquiryDetail = "We would want to find someone who can accompany us on the journey to Brisbane.Brisbane, capital of Queensland, is a large city on the Brisbane River. Clustered in its South Bank cultural precinct are the Queensland Museum and Sciencentre, with noted interactive exhibitions. Another South Bank cultural institution is Queensland Gallery of Modern Art, among Australia's major contemporary art museums. Looming over the city is Mt. Coot-tha, site of Brisbane Botanic Gardens.",
                InquiryImage = "travelphoto.jpeg"
            });

            items.Add(new InquiryEntity
            {
                InquiryName = "Pet",
                InquiryDate = "12/1/2018",
                InquiryDetail = "As we're too busy with our daily work, we would want to hand our puppy to someone that can take care of when we're on work. Our dog is Welsh Corgi Pembroke Dog Breed Information and Personality Traits. Known for their quick intelligence and forceful will, Pembroke Welsh corgis are active, hardy and want to be part of the family.",
                InquiryImage = "petphoto.jpg"
            });

            items.Add(new InquiryEntity
            {
                InquiryName = "Transportation",
                InquiryDate = "12/1/2018",
                InquiryDetail = "I would like to rent a car for our family trip. Our expectation for the car is it requires Regular 87 octane fuel as that essentially makes the motor more fuel efficient",
                InquiryImage = "transportationphoto.jpg"
            });

            items.Add(new InquiryEntity
            {
                InquiryName = "Accessories",
                InquiryDate = "12/1/2018",
                InquiryDetail = "My friends need an accessories to refresh her garage looks.She's looking for a new morden garage automatic door with a morden look that can fits with her house..",
                InquiryImage = "accessoriesphoto.jpg"
            });

            items.Add(new InquiryEntity
            {
                InquiryName = "Household",
                InquiryDate = "12/1/2018",
                InquiryDetail = "In search with some one who have experienced in house keeping. We need a person who can keep our house cleen and take care of our plants while we go to work.",
                InquiryImage = "householdphoto.jpg"
            });

            return items;
        }
    }
}