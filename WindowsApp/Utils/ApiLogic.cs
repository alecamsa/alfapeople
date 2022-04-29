using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WindowsApp.Models;

namespace WindowsApp.Utils
{
    public class ApiLogic
    {
        static HttpClient client = new HttpClient();

        public static async Task<JArray> CountriesGetAll()
        {
            try
            {
                client = await HttpUtilityExtend.Initializate(ConfigurationManager.AppSettings["CountriesUrl"].ToString());
                HttpResponseMessage httpResponseMessage = await client.GetAsync("all");
                var jsonResult = await HttpUtilityExtend.FetchResult<JArray>(httpResponseMessage);

                if (jsonResult == null)
                {
                    return null;
                }
                else
                {
                    return jsonResult;
                }
            }
            catch (Exception ex)
            {                
                return null;
            }
        }
        public static async Task<List<UniversityModel>> UniversityInfoGetAll(string countryName)
        {
            try
            {
                client = await HttpUtilityExtend.Initializate(ConfigurationManager.AppSettings["UniversitiesUrl"].ToString());
                HttpResponseMessage httpResponseMessage = await client.GetAsync(string.Format("{0}{1}","search?country=",countryName));
                var jsonResult = await HttpUtilityExtend.FetchResult<JArray>(httpResponseMessage);
                var universityList = jsonResult.ToObject<List<UniversityModel>>();

                if (!universityList.Any())
                {
                    return null;
                }
                else
                {
                    universityList.ForEach(x =>
                    {
                        x.webpage = x.web_pages != null ?  x.web_pages.FirstOrDefault() : string.Empty;
                    });
                    return universityList;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
