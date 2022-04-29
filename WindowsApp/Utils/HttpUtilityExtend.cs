using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.Utils
{
    public class HttpUtilityExtend
    {
        static HttpClient client = new HttpClient();
        public static async Task<HttpClient> Initializate(string urlBase){
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            // Update port # in the following line.
            client = new HttpClient
            {
                BaseAddress = new Uri(urlBase)
            };
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            return client;
        }
        public static async Task<T> FetchResult<T>(HttpResponseMessage result)
        {
            if (result.IsSuccessStatusCode)
            {
                // Convert the HttpResponseMessage to string
                var resultArray = await result.Content.ReadAsStringAsync();

                // Json.Net Deserialization
                var data = JsonConvert.DeserializeObject<T>(resultArray);

                return data;
            }
            else
            {
                return default(T);
            }
        }
    }
}
