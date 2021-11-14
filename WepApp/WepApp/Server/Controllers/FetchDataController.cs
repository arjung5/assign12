using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using WepApp.Client.Model;

namespace WepApp.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FetchDataController: ControllerBase
    {
        [HttpGet]
        public async Task<Dictionary<string, string>> Get()
        {
            //ReleaseResponse releaseResponse = new ReleaseResponse();
            Dictionary<string, string> finalResponse = new Dictionary<string, string>();
            int minValue = 2147483646;
            int maxValue =-1;
            try
            {

                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Add(
                        new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("product", "1"));
                    var response = await client.GetAsync("https://api.github.com/users/hadley/orgs");
                    if (response.IsSuccessStatusCode)
                    {
                        var strResponse = await response.Content.ReadAsStringAsync();
                        var responseValue=JsonConvert.DeserializeObject<List<RootValue>>(strResponse);
                        foreach (var value in responseValue)
                        {
                            if(value.id<minValue)
                            {
                                minValue = value.id;
                            }
                            if(value.id>maxValue)
                            {
                                maxValue = value.id;
                            }
                        }
                        finalResponse.Add("Maximum Value :", maxValue.ToString());
                        finalResponse.Add("Minimum Value :", minValue.ToString());
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }

            return finalResponse;
        }
    }
}
