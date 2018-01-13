using System;
using System.Net.Http;
using System.Threading.Tasks;
using Crypto227.Models;
using Crypto227.Supporters;
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
            var coinDetails = await CoinService.GetCoinDetails();
            return  PartialView("_CoinWidgetPartial", coinDetails);
        }

        
    }
}