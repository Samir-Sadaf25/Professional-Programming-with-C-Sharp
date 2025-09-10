using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class shoppingCart
    {
        public Iproduct[] products { get; set; }
        public int itemCount { get; set; }
        public void showCartItems()
        {
             var total = 0.0m;
            foreach (var item in products)
            {
                Console.WriteLine($"{item.name} {item.price}")
                    total += item.getDiscountedPrice();
            }
        }

    }
}
