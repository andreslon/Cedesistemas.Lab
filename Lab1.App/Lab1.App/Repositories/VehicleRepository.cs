using Lab1.App.Extensions;
using Lab1.App.Models.Responses;
using Lab1.App.Repositories;
using Lab1.App.Services;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(VehicleRepository))]
namespace Lab1.App.Repositories
{
    public class VehicleRepository : IVehicleRepository
    {
        public string ApiUri { get; set; } = AppResources.ApiUri;
        public INetworkService NetworkService { get; set; }
        public IHttpClientService HttpClientService { get; set; }
        public VehicleRepository()
        {
            NetworkService = DependencyService.Get<INetworkService>();
            HttpClientService = DependencyService.Get<IHttpClientService>();
        }

        async public Task<List<VehicleFullDto>> GetVehicles(int userId)
        {
            if (await NetworkService.IsNetworkAvailable())
            {
                var response = await HttpClientService
                    .Get($"{ApiUri}/users/{userId}/vehicles");
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<VehicleFullDto>>(content);
                } 
            }
            else
            {
                //Ir a almacenamiento local
            }
            return null;
        }
    }
}
