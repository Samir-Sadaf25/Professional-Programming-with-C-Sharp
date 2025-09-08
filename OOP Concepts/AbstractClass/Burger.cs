using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Burger : product
    {
        public int sizeInInches { get; set; }

        public override double getPrice()
        {
            if (sizeInInches > 10)
            {
                price = 20;
            }
            else
            {
                price = 100;
            }
            return price;
        }
    }
}
