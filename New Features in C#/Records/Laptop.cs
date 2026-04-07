using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Records
{
    public record Laptop
    {
        public string Brand { get; set; }
        public int price { get; set; }
    }
}
