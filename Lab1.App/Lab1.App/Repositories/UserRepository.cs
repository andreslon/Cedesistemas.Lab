using Lab1.App.Extensions;
using Lab1.App.Models.Requests;
using Lab1.App.Models.Responses;
using Lab1.App.Repositories;
using Lab1.App.Services;
using Newtonsoft.Json;
using System.Threading.Tasks;
using Xamarin.Forms;
[assembly: Xamarin.Forms.Dependency(typeof(UserRepository))]
namespace Lab1.App.Repositories
{
    public class UserRepository: IUserRepository
    {
        public string ApiUri { get; set; } = AppResources.ApiUri;
        public INetworkService NetworkService { get; set; }
        public IHttpClientService HttpClientService { get; set; }
        public UserRepository()
        {
            NetworkService = DependencyService.Get<INetworkService>();
            HttpClientService = DependencyService.Get<IHttpClientService>();
        }
        async public Task<UserFullDto> Login(UserDto user)
        {
            //Verificar si el usuario tiene internet
            if (await NetworkService.IsNetworkAvailable())
            {
                var result = await HttpClientService.Post($"{ApiUri}/login", user);
                if (result.IsSuccessStatusCode)
                {
                    string content = await result.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<UserFullDto>(content);
                }
            }
            else
            {
                //Si no tiene internet se consulta en storage
            }
            return null;
        }
    }
}
