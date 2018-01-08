using System;
using System.Net.Http;
using System.Threading.Tasks;
using Crypto227.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Crypto227.Controllers
{
    public class CoinListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [ResponseCache(VaryByHeader = "User-Agent", Duration = 2)]
        public async Task<IActionResult> GetData()
        {
            CoinObject coinDetails;

            using (var client = new HttpClient())
            {
                try
                {
                    var coinType = "BTC,ETH,LTC,ZEC,DASH";
                    var currencyType = "USD";
                    client.BaseAddress = new Uri("https://min-api.cryptocompare.com");
                    var response = await client.GetAsync($"/data/pricemultifull?fsyms={coinType}&tsyms={currencyType}");
                    response.EnsureSuccessStatusCode();

                    var stringResult = await response.Content.ReadAsStringAsync();
                    coinDetails = JsonConvert.DeserializeObject<CoinObject>(stringResult);
                }
                catch (HttpRequestException httpRequestException)
                {
                    return BadRequest($"Error getting weather from CyptoCompare: {httpRequestException.Message}");
                }
            }

            return  PartialView("_CoinWidgetPartial", coinDetails);
        }
    }
}