using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class product
    {
        public string name { get; set; }
        public int price { get; set; }  
        public int quantity { get; set; }
        public product()
        {
            name = string.Empty;
        }
        public virtual void PrintName()
        {
            Console.WriteLine(name);
        }
    }
}
