﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Storage;
using Plugin.Media;
using Plugin.Media.Abstractions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamCross.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FirebaseStoragePage : ContentPage
    {
        MediaFile file;
        public FirebaseStoragePage()
        {
            InitializeComponent();
        }

        private async void btnPick_Clicked(object sender, EventArgs e)
        {
            await CrossMedia.Current.Initialize();
            try
            {
                file = await Plugin.Media.CrossMedia.Current.PickPhotoAsync(new Plugin.Media.Abstractions.PickMediaOptions
                {
                    PhotoSize = Plugin.Media.Abstractions.PhotoSize.Medium
                });
                if (file == null)
                    return;
                imgChoosed.Source = ImageSource.FromStream(() =>
                {
                    var imageStram = file.GetStream();
                    return imageStram;
                });
                await StoreImages(file.GetStream());
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private async void btnStore_Clicked(object sender, EventArgs e)
        {
            await StoreImages(file.GetStream());
        }
        public async Task<string> StoreImages(Stream imageStream)
        {
            var stroageImage = await new FirebaseStorage("ringmap-1533296555276.appspot.com")
                .Child("XamarinMonkeys")
                .Child("image.jpg")
                .PutAsync(imageStream);
            string imgurl = stroageImage;
            return imgurl;
        }
    }
}