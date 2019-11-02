﻿using System;
using Trady.Interface;
using Trady.iOS.DService;

[assembly: Xamarin.Forms.Dependency(typeof(Folder))]
namespace Trady.iOS.DService
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
