using GoGreenApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GoGreenApp.Data
{
    class MicroMarketRestService : IRestService<MicroMarket>
    {
        HttpClient _client;

        public List<MicroMarket> items { get; private set; }

        public MicroMarketRestService()
        {
            _client = new HttpClient();
        }

        public async Task<List<MicroMarket>> getAll()
        {
            items = new List<MicroMarket>();

            var uri = new Uri(string.Format(Constants.TodoItemsUrl, string.Empty));
            try
            {
                var response = await _client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    items = JsonConvert.DeserializeObject<List<MicroMarket>>(content);
                    MicroMarket mm = new MicroMarket();
              

                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }

            return items;
        }
    }
}
