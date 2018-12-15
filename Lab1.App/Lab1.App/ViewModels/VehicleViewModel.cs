using Lab1.App.Extensions;

namespace Lab1.App.ViewModels
{
    public class VehicleViewModel : NotifyProperty
    {
        public int Id { get; set; }
        public string Plate { get; set; } 
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string City { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int UserId { get; set; }
    }
}
