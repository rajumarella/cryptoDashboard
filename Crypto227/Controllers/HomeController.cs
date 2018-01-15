using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Crypto227.Models;
using System.Net.Http;
using Newtonsoft.Json;
using Crypto227.Supporters;
using Microsoft.Extensions.Configuration;

namespace Crypto227.Controllers
{
    public class HomeController : Controller
    {
        public string CoinTypes { get; }

        public string CurrencyTypes { get; }

        public string CryptoCompareUrl { get; set; }

        public HomeController(IConfiguration configuration)
        {
            CoinTypes = configuration.GetSection("ApplicationSettings").GetSection("CoinTypes").Value;
            CurrencyTypes = configuration.GetSection("ApplicationSettings").GetSection("CurrencyTypes").Value;
            CryptoCompareUrl = configuration.GetSection("ApplicationSettings").GetSection("CryptoCompareUrl").Value;
        }

        public async Task<IActionResult> Index()
        {
            var coinMain = new CoinMain();
            coinMain.CoinHeader = await CoinService.GetCoinDetails(CoinTypes, CurrencyTypes, CryptoCompareUrl);
            coinMain.CoinDetialByVolume = await CoinService.GetCoinDetailsByVolume("BTC", CryptoCompareUrl);
            return View("Index", coinMain);
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
