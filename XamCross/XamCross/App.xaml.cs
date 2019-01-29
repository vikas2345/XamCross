using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamCross.Data;
using XamCross.Helpers;
using XamCross.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XamCross
{
    public partial class App : Application
    {
        static UserDatabaseController userDatabase;
        static TokenDatabaseController tokenDatabase;
        static EmployeeDatabaseController employeeDatabase;


        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage( new EmployeeListPage());
            MainPage = new ValidationBehavior();
            // add navigation
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        public static UserDatabaseController UserDatabase
        {
            get
            {
                if (userDatabase == null)
                {
                    userDatabase = new UserDatabaseController();
                }
                return userDatabase;
            }
        }

        public static TokenDatabaseController TokenDatabase
        {
            get
            {
                if (tokenDatabase == null)
                {
                    tokenDatabase = new TokenDatabaseController();
                }
                return tokenDatabase;
            }
        }


        public static EmployeeDatabaseController EmployeeDatabase
        {
            get
            {
                if (employeeDatabase == null)
                {
                    employeeDatabase = new EmployeeDatabaseController(DependencyService.Get<ILocalFileHelper>().GetLocalFilePath("Employee.db3"));
                }
                return employeeDatabase;
            }
        } 

    }
}
