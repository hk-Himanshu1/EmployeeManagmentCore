using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DAL
{
    public class RegistrationApi
    {
        public static async Task<List<string>> GetCountriesData()
        {
            string apiUrl = "https://restcountries.com/v3.1/all";
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    response.EnsureSuccessStatusCode();
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    JArray jsonArray = JArray.Parse(jsonResponse);
                    List<string> commonNames = new List<string>();
                    foreach (JObject item in jsonArray)
                    {
                        commonNames.Add((string)item["name"]["common"]);
                    }
                    return commonNames;
                }
                catch (HttpRequestException ex)
                {
                    throw new($"Error: {ex.Message}");
                }
            }
        }
    }
}
