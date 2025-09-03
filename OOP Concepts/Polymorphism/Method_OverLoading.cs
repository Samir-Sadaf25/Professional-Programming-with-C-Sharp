using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Method_OverLoading
    {
        public string name { get; set; }
        public double price { get; set; }

        public double calcuteDiscount(double discount)
        {
            throw new NotImplementedException();
        }
        public double calcuteDiscount(double discount, int quantity)
        {
            throw new NotImplementedException();
        }
        public double calcuteDiscount(double discount, double quantity)
        {
            throw new NotImplementedException();
        }
    }
}
