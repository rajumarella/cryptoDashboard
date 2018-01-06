using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
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

       
    }
}