using Microsoft.AspNetCore.Mvc;
using LasTapasUS.Data;
using LasTapasUS.Models;
using System.Linq;

namespace LasTapasUS.Controllers
{
    public class OrdersController : Controller
    {

        private readonly RestaurantContext _context;

        public OrdersController(RestaurantContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Create(string table, string dish)
        {
            var order = new Order
            {
                Table = table,
                Dish = dish,
                Status = "Pending"
            };
            _context.Orders.Add(order);
            _context.SaveChanges();

            return RedirectToAction("Waiter");
        }
        public IActionResult Waiter()
        {
            var activeOrders = _context.Orders
                .Where(o => o.Status != "Served")
                .OrderByDescending(o => o.Id)
                .ToList();

            var servedOrders = _context.Orders
                .Where(o => o.Status == "Served")
                .OrderByDescending(o => o.Id)
                .ToList();

            var viewModel = new WaiterViewModel
            {
                ActiveOrders = activeOrders,
                ServedOrders = servedOrders
            };

            return View("~/Views/Home/Orders/Waiter.cshtml", viewModel);
        }


        public IActionResult Kitchen()
        {
            var pending = _context.Orders.Where(o => o.Status == "Pending").OrderBy(o => o.Id).ToList();
            return View("~/Views/Home/Orders/Kitchen.cshtml", pending);
        }

        [HttpPost]
        public IActionResult MarkPrepared(int id)
        {
            var order = _context.Orders.Find(id);
            if (order != null)
            {
                order.Status = "Prepared"; // or "Served"
                _context.SaveChanges();
            }

            return RedirectToAction("Kitchen");
        }

        [HttpPost]
        public IActionResult MarkServed(int id)
        {
            var order = _context.Orders.Find(id);
            if (order != null)
            {
                order.Status = "Served";
                _context.SaveChanges();
            }
            return RedirectToAction("Waiter");

        }

        [HttpPost]
        public IActionResult SubmitBasket([FromBody] BasketDto dto)
        {
            if (dto?.Items == null || dto.Items.Count == 0)
                return BadRequest("No items.");

            foreach (var item in dto.Items)
            {
                var order = new Order
                {
                    Table = dto.Table,
                    Dish = item.Name,
                    Price = item.Price,
                    Status = "Pending",
                    OrderDate = DateTime.Now
                };
                _context.Orders.Add(order);
            }

            _context.SaveChanges();
            return Ok();
        }


        // DTO to receive basket
        public class BasketDto
        {
            public string Table { get; set; }
            public List<BasketItemDto> Items { get; set; }
        }

        public class BasketItemDto
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            // remove Quantity
        }

        public IActionResult MyOrders(string table)
        {
            if (string.IsNullOrEmpty(table))
            {
                ViewData["TableRequired"] = true;
                var emptyOrders = new List<Order>();
                return View("~/Views/Home/Orders/MyOrders.cshtml", emptyOrders);
            }

            var orders = _context.Orders
                .Where(o => o.Table == table)
                .OrderByDescending(o => o.Id)
                .ToList();

            ViewData["Table"] = table;
            return View("~/Views/Home/Orders/MyOrders.cshtml", orders);
        }



    }
}
