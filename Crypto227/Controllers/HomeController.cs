using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Crypto227.Models;
using System.Net.Http;
using Newtonsoft.Json;
using Crypto227.Supporters;

namespace Crypto227.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var coinDetails = await CoinService.GetCoinDetails();
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
