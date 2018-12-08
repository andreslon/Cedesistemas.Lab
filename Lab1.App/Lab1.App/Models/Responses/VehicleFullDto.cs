using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1.App.Models.Responses
{
   public class VehicleFullDto
    {
        public string Id { get; set; }
        public string Plate { get; set; }
        public string City { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double Odometer { get; set; }
        public string UserId { get; set; } 
    }
}
