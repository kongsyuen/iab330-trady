using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Trady.Models;
using Trady.Views;
using Xamarin.Forms;

namespace Trady.ViewModels
{
    class InquiryPageViewModel
    {
        public ObservableCollection<Inquiries> InquiryList { get; set; }

        public InquiryPageViewModel()
        {
            InquiryList = new ObservableCollection<Inquiries>
            {
                new Inquiries{
                    InquiryName = "Travel",
                    InquiryDate = "12/1/2018",
                    InquiryDetail = "We would want to find someone who can accompany us on the journey to Brisbane.Brisbane, capital of Queensland, is a large city on the Brisbane River. Clustered in its South Bank cultural precinct are the Queensland Museum and Sciencentre, with noted interactive exhibitions. Another South Bank cultural institution is Queensland Gallery of Modern Art, among Australia's major contemporary art museums. Looming over the city is Mt. Coot-tha, site of Brisbane Botanic Gardens.",
                    InquiryImage = "travelphoto.jpeg"
                },

                new Inquiries{
                    InquiryName = "Pet",
                    InquiryDate = "12/1/2018",
                    InquiryDetail = "As we're too busy with our daily work, we would want to hand our puppy to someone that can take care of when we're on work. Our dog is Welsh Corgi Pembroke Dog Breed Information and Personality Traits. Known for their quick intelligence and forceful will, Pembroke Welsh corgis are active, hardy and want to be part of the family.",
                    InquiryImage = "petphoto.jpg"
                },

                new Inquiries{
                    InquiryName = "Transportation",
                    InquiryDate = "12/1/2018",
                    InquiryDetail="I would like to rent a car for our family trip. Our expectation for the car is it requires Regular 87 octane fuel as that essentially makes the motor more fuel efficient",
                    InquiryImage = "transportationphoto.jpg"
                },

                new Inquiries{
                    InquiryName = "Accessories",
                    InquiryDate = "12/1/2018",
                    InquiryDetail ="My friends need an accessories to refresh her garage looks.She's looking for a new morden garage automatic door with a morden look that can fits with her house..",
                    InquiryImage = "accessoriesphoto.jpg"
                },

                new Inquiries{
                    InquiryName = "Household",
                    InquiryDate = "12/1/2018",
                    InquiryDetail ="In search with some one who have experienced in house keeping. We need a person who can keep our house cleen and take care of our plants while we go to work.",
                    InquiryImage = "householdphoto.jpg"
                },
            };
        }

    }
}

