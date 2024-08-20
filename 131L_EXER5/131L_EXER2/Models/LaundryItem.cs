using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _131L_EXER2.Models
{
    public class LaundryItem
    {
        public int Quantity { get; set; }
        public string ItemName { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
