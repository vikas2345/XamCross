
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamCross.Model.SQLite;

namespace XamCross.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EmployeeListPage : ContentPage
    {
        public EmployeeListPage()
        {
            InitializeComponent();
            Title = "Employee List";

            var toolbarItem = new ToolbarItem
            {
                Text = "+"
            };

            toolbarItem.Clicked += ToolbarItem_Clicked;

            ToolbarItems.Add(toolbarItem);

        }

        private void ToolbarItem_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new EmployeePage() { BindingContext = new Employee()});
        }


    }
}