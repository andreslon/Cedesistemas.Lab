using Lab1.App.Extensions;
using System.Windows.Input;

namespace Lab1.App.ViewModels
{
    public class LoginViewModel
    {

        public string Usuario { get; set; }
        public string Password { get; set; } 

        public ICommand LoginCommand
        {
            get { return new RelayCommand(Login, null); }
        }

        async public void Login()
        {
            if (Usuario == "admin"
                && Password == "admin")
            {
                App.IrAHome();
            }
            else
            {
                //await DisplayAlert("Error"
                //    , "Usuario ó contraseña incorrecta"
                //    , "Aceptar");
            }
        }
    }
}
