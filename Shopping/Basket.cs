using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    public class Basket
    {
        private readonly List<Item> _items;

        public Basket(List<Item> items)
        {
            _items = items;
        }

        //public double Total { get; set; }
        //public double Total => 0.0;

        public double Total
        {
            get { return _items.Select(item => item.Price * item.Quantity).Sum(); }
        }
            
    }
}
