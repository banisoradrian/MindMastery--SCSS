using Microsoft.AspNetCore.Mvc;
using MindMastery1.Models;
using System.Diagnostics;

namespace MindMastery1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult DespreNoi()
        {
            return View();
        }

        public IActionResult TestPersonalitate()
        {
            return View();
        }

        public IActionResult Rezultat()
        {
            return View();
        }

        public IActionResult Rezultat2()
        {
            return View();
        }

        public IActionResult Rezultat3()
        {
            return View();
        }

        public IActionResult Rezultat4()
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
