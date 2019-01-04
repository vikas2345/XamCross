using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using XamCross.Droid.Data;
using XamCross.Helpers;

[assembly: Dependency(typeof(DroidLocalFileHelper))]

namespace XamCross.Droid.Data
{
    public class DroidLocalFileHelper : ILocalFileHelper
    {
        public string GetLocalFilePath(string fileName)
        {
            
            string documentPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

            var path = Path.Combine(documentPath, fileName);

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            return path;
        }
    }
}