using Lab1.App.Models.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lab1.App.Repositories
{
    public interface IVehicleRepository
    {
        Task<List<VehicleFullDto>> GetVehicles(int userId);
    }
}
