using Microsoft.AspNetCore.Mvc;
using LasTapasUS.Data;

namespace LasTapasUS.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            var menu = Menu.MenuList;
            return View("~/Views/Home/Index.cshtml", menu);
        }
    }
}
