using Lab1.App.Extensions;
using Lab1.App.Models;
using Lab1.App.Repositories;
using System.Windows.Input;
using Xamarin.Forms;

namespace Lab1.App.ViewModels
{
    public class LoginViewModel
    {
        public User User { get; set; } = new User();
        public IUserRepository UserRepository { get; set; }
        //public IDeviceService DeviceService { get; set; }
        public LoginViewModel()
        {
            UserRepository = DependencyService.Get<IUserRepository>();

            //DeviceService = DependencyService.Get<IDeviceService>();
            //string platform = DeviceService.GetDevice(1);
        }

        public ICommand LoginCommand
        {
            get { return new RelayCommand(Login, null); }
        }

        async public void Login()
        {
            var response = await UserRepository.Login(new Models.Requests.UserDto
            {
                Username = User.Usuario,
                Password = User.Password
            });
            if (response != null)
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
