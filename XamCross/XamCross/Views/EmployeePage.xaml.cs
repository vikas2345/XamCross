using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamCross.Model.SQLite;

namespace XamCross.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EmployeePage : ContentPage
    {
        public EmployeePage()
        {
            InitializeComponent();
        }

        async void SaveClicked(object sender, EventArgs e)
        {
            var personItem = (Employee)BindingContext;
            await App.EmployeeDatabase.SaveEmployeeAsync(personItem);

            await Navigation.PopAsync();


        }

        async void CancelClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}