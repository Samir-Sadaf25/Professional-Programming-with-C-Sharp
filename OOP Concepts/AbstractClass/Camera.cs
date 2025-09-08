using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Camera : product
    {
      public  double megapixels { get; set; }
        public override double getPrice()
        {
            if (megapixels > 20)
            {
                price = 200;
            }
            else
            {
                price = 100;
            }
            return price;
        }
    }
}
