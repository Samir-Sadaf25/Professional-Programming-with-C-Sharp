using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class camera : Iproduct
    {
       public  string name { get; set; }
       public decimal discount { get; set; }
         public decimal price { get; set; }
        public decimal getDiscountedPrice()
        {
            return price - (price * discount / 100);
        }
    }
}
