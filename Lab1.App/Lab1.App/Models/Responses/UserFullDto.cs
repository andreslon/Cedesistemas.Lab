using System.Collections.Generic;

namespace Lab1.App.Models.Responses
{
    public class UserFullDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public List<VehicleFullDto> Vehicles { get; set; }
    }
}
