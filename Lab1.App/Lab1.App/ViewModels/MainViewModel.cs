using Lab1.App.Extensions;
using Lab1.App.Models;
using Lab1.App.Repositories;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Lab1.App.ViewModels
{
    public class MainViewModel : NotifyProperty
    {
        private bool _IsLoading;
        public bool IsLoading
        {
            get { return _IsLoading; }
            set
            {
                _IsLoading = value;
                OnPropertyChanged("IsLoading");
                OnPropertyChanged("ShowLoginButton");
            }
        }
        public bool ShowLoginButton { get { return !IsLoading; } }

        public int UserId { get; set; }
        public string FullName { get; set; }
        public ObservableCollection<VehicleViewModel> Vehicles { get; set; }
        public User User { get; set; } = new User();
        public IUserRepository UserRepository { get; set; }
        public IVehicleRepository VehicleRepository { get; set; }
        public MainViewModel()
        {
            UserRepository = DependencyService.Get<IUserRepository>();
            VehicleRepository = DependencyService.Get<IVehicleRepository>();
        }

        public ICommand LoginCommand
        {
            get { return new RelayCommand(Login, null); }
        }

        async public void Login()
        {
            IsLoading = true;
            var response = await UserRepository.Login(new Models.Requests.UserDto
            {
                Username = User.Usuario,
                Password = User.Password
            });
            if (response != null)
            {
                UserId = response.Id;
                FullName = $"{response.Firstname} {response.Lastname}";
                await GetVehicles();
            }
            else
            {
                IsLoading = false;
                //await DisplayAlert("Error"
                //    , "Usuario ó contraseña incorrecta"
                //    , "Aceptar");
            }
        }

        async public Task GetVehicles()
        {
            var response = await VehicleRepository.GetVehicles(UserId);
            if (response != null)
            {
                Vehicles = new ObservableCollection<VehicleViewModel>();
                foreach (var vehicle in response.OrderBy(x => x.Plate))
                {
                    Vehicles.Add(
                        new VehicleViewModel
                        {
                            Id = vehicle.Id,
                            City = vehicle.City,
                            Description = vehicle.Description,
                            Image = vehicle.Image,
                            Latitude = vehicle.Latitude,
                            Longitude = vehicle.Longitude,
                            Plate = vehicle.Plate
                        });
                }
            }
            App.IrAHome();
            IsLoading = false;
        }

    }
}
