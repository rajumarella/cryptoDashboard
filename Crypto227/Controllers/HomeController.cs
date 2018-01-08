using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Crypto227.Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace Crypto227.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
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

            return View("Index", coinDetails);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
