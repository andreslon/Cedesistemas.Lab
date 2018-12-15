using Lab1.App.Extensions;

namespace Lab1.App.Models
{
    public class User : NotifyProperty
    {
        public User()
        {
            Usuario = "andreslon";
            Password = "@andreslon";
        }
        public string Usuario { get; set; }

        private string _Password;
        public string Password
        {
            get { return _Password; }
            set
            {
                _Password = value;
                OnPropertyChanged("Password");
            }
        }


    }
}
