using System;
using Xamarin.Forms;

namespace Trady.Models
{
    public class Items
    {
        public Items()
        {
        }

        public string Information { get; set; }
        public ImageSource Photo { get; set; }
        public string Category { get; set; }
        public string Date { get; set; }
    }
}
