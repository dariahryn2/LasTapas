using System.Diagnostics;
using LasTapasUS.Models;
using Microsoft.AspNetCore.Mvc;
using LasTapasUS.Data;

namespace LasTapasUS.Controllers
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
            var menu = Menu.MenuList; // get static menu list
            return View("~/Views/Home/Index.cshtml", menu);        // send it to /Views/Home/Index.cshtml
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
