using Microsoft.AspNetCore.Mvc;
using LasTapasUS.Data;
using LasTapasUS.Models;
using System.Linq;

namespace LasTapasUS.Controllers
{
    public class OrdersController : Controller
    {
        [HttpPost]
        public IActionResult Create(string table, string dish)
        {
            int newId = Orders.Order.Count + 1;
            Orders.Order.Add(new Order { Id = newId, Table = table, Dish = dish });
            return RedirectToAction("Waiter");
        }
        public IActionResult Waiter()
        {
            return View("~/Views/Home/Orders/Waiter.cshtml", Orders.Order);
        }

        public IActionResult Kitchen()
        {
            var pending = Orders.Order.Where(o => o.Status == "Pending").ToList();
            return View("~/Views/Home/Orders/Kitchen.cshtml", pending);
        }

        [HttpPost]
        public IActionResult MarkPrepared(int id)
        {
            var order = Orders.Order.FirstOrDefault(o => o.Id == id);
            if (order != null) order.Status = "Prepared";
            return RedirectToAction("Kitchen");
        }

        [HttpPost]
        public IActionResult MarkServed(int id)
        {
            var order = Orders.Order.FirstOrDefault(o => o.Id == id);
            if (order != null) order.Status = "Served";
            return RedirectToAction("Waiter");
        }

        [HttpPost]
        public IActionResult SubmitBasket([FromBody] BasketDto dto)
        {
            int nextId = Orders.Order.Count + 1;

            foreach (var item in dto.Items)
            {
                Orders.Order.Add(new Order
                {
                    Id = nextId++,
                    Table = dto.Table,
                    Dish = item.Name,
                    Status = "Pending"
                });
            }

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
        }

    }
}
