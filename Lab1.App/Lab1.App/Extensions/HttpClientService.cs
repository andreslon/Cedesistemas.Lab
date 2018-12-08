using Lab1.App.Extensions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
[assembly: Xamarin.Forms.Dependency(typeof(HttpClientService))]
namespace Lab1.App.Extensions
{
    public class HttpClientService : IHttpClientService
    {
        async public Task<HttpResponseMessage> Get(string apiUri)
        {
            using (var client= new HttpClient())
            {
                return await client.GetAsync(new Uri(apiUri));
            }
        }

       async public Task<HttpResponseMessage> Post<T>(string apiUri, T request)
        {
            using (var client= new HttpClient())
            {
                string body = JsonConvert.SerializeObject(request);
                return await client.PostAsync(apiUri, 
                    new StringContent(body, Encoding.UTF8, "application/json"));
            }
        }
    }
}
