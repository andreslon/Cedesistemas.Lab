using Lab1.App.iOS;

[assembly: Xamarin.Forms.Dependency(typeof(DeviceService))]
namespace Lab1.App.iOS
{
    public class DeviceService : IDeviceService
    {
        public string GetDevice(int num)
        {
            return "IOS " + (num + 5);
        }
    }
}