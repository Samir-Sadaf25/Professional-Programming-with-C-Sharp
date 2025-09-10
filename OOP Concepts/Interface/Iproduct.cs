using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface Iproduct
    {
        string name { get; set; }
        decimal discount { get; set; }
        decimal price { get; set; }
        decimal getDiscountedPrice();
    }
}
