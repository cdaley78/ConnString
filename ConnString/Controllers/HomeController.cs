using Class.ConfigManager;
using Class.SqlLogger;
using ConnString.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ConnString.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISqlLogManager _sqlLogManager;

        public HomeController(ILogger<HomeController> logger,ISqlLogManager sqlLogManager)
        {
            _logger = logger;
            _sqlLogManager = sqlLogManager;
        }

        public IActionResult Index()
        {
            var sqlConn = _sqlLogManager.InitDb();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
