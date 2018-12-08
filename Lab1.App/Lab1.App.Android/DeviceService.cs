using Lab1.App.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(DeviceService))]
namespace Lab1.App.Droid
{
    public class DeviceService : IDeviceService
    {
        public string GetDevice(int num)
        {
            return "ANDROID" + (num + 1);
        }
    }
}