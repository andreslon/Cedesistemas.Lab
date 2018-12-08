using System.Net.Http;
using System.Threading.Tasks;

namespace Lab1.App.Extensions
{
    public interface IHttpClientService
    {
        Task<HttpResponseMessage> Get(string apiUri);
        Task<HttpResponseMessage> Post<T>(string apiUri, T request);
    }
}
