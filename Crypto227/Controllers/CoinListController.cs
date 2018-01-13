using System;
using System.Net.Http;
using System.Threading.Tasks;
using Crypto227.Models;
using Crypto227.Supporters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace Crypto227.Controllers
{
    public class CoinListController : Controller
    {
        public string CoinTypes { get; }

        public string CurrencyTypes { get; }

        public string CryptoCompareUrl { get; set; }

        public CoinListController(IConfiguration configuration)
        {
            CoinTypes = configuration.GetSection("ApplicationSettings").GetSection("CoinTypes").Value;
            CurrencyTypes = configuration.GetSection("ApplicationSettings").GetSection("CurrencyTypes").Value;
            CryptoCompareUrl = configuration.GetSection("ApplicationSettings").GetSection("CryptoCompareUrl").Value;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [ResponseCache(VaryByHeader = "User-Agent", Duration = 2)]
        public async Task<IActionResult> GetData()
        {
            var coinDetails = await CoinService.GetCoinDetails(CoinTypes, CurrencyTypes, CryptoCompareUrl);
            return  PartialView("_CoinWidgetPartial", coinDetails);
        }

        
    }
}