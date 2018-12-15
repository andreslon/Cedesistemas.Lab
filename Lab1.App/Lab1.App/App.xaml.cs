using Lab1.App.Pages;
using Lab1.App.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Lab1.App
{
    public partial class App : Application
    {
        private static MainViewModel _MainVM; 
        public static MainViewModel MainVM
        {
            get
            {
                if (_MainVM == null)
                {
                    _MainVM = new MainViewModel();
                }
                return _MainVM;
            }
        }


        public App()
        {
            InitializeComponent();
            MainPage = new LoginPage();
        }
        internal static void IrAHome()
        {
            Current.MainPage = new NavigationPage(new HomePage()
            {
                Title = "Cedesistemas"
            }) ;
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
