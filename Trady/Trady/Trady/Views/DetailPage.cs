using Xamarin.Forms;

namespace Trady.Views
{
    internal class DetailPage : Page
    {
        private object iD;
        private object name;

        public DetailPage(object iD, object name)
        {
            this.iD = iD;
            this.name = name;
        }
    }
}