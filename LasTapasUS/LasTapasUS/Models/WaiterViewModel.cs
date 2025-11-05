using System.Collections.Generic;

namespace LasTapasUS.Models
{
    public class WaiterViewModel
    {
        public List<Order> ActiveOrders { get; set; } = new();
        public List<Order> ServedOrders { get; set; } = new();
    }
}

