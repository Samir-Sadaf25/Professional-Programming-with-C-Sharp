using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class product // parrent class abstract hoay er instance kora jabe na
    {
        public string name { get; set; }
        public double price { get; set; }

        public abstract double getPrice();
    }
}
