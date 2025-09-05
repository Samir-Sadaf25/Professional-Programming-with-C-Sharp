using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class product
    {
        public string name { get; set; }
        public int size { get; set; }

        public abstract double getPrice();
    }
}
