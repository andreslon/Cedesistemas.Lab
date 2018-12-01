using System;
using Lab1.App.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Lab1.App
{
    public partial class App : Application
    { 
        public App()
        {
            InitializeComponent();
            MainPage = new LoginPage(); 
        }
        internal static void IrAHome() {
            Current.MainPage = new HomePage();
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
    }
}
