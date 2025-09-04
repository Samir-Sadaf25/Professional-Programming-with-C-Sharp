using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Burger : Product
    {
        public double extraCheese { get; set; }
        public double extraPatty { get; set; }
        public double extraSauce { get; set; }
        public override void PrintName()
        {
             Console.WriteLine("Burger Name: " + name);
        }
    }
}
