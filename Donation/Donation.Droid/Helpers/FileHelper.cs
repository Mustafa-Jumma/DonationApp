using System;
using Android.OS;
using Xamarin.Forms;
using Donation.Model;
using Donation.Droid.Helpers;
using System.IO;

[assembly: Dependency(typeof(FileHelper))]

namespace Donation.Droid.Helpers
{
    public class FileHelper : IFileHelper
    {
        public string GetLocalFilePath(string filename)
        {
            string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            return Path.Combine(path, filename);
        }
    }
}