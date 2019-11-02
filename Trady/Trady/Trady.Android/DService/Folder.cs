using System;
using Trady.Droid.DService;
using Trady.Interface;

[assembly: Xamarin.Forms.Dependency(typeof(Folder))]
namespace Trady.Droid.DService
{
    public class Folder : IFolder
    {
        public string GetMyDocumentPath()
        {
            return Environment.GetFolderPath(
                Environment.SpecialFolder.MyDocuments);
        }
    }
}
