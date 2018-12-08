using System.Threading.Tasks;
using Lab1.App.Services;
using Plugin.Connectivity;
[assembly: Xamarin.Forms.Dependency(typeof(NetworkService))]
namespace Lab1.App.Services
{
    public class NetworkService: INetworkService
    {
        async public Task<bool> IsNetworkAvailable()
        {
            var connectivity = CrossConnectivity.Current;
            if (!connectivity.IsConnected)
                return false;

            var reachable = await connectivity.IsRemoteReachable("https://cedesistemasapp.azurewebsites.net/");
            return reachable;
        }
    }
}
