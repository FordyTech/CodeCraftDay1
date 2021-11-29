using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    public class Item
    {
        public double Price { get; }
        public int Quantity { get; set; }

        public Item(double price, int quantity) {
            Price = price;
            Quantity = quantity;
        }
    }
}
