using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeslaPower.Models
{
    public class OrderItems
    {
        public Order order { get; set; }
        public List<Item> items { get; set; }
    }
}