using Lab1.App.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab1.App.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = new LoginViewModel();
        }
    }
}