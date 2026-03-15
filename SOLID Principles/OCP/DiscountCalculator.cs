using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class DiscountCalculator
    {
        public double CalculateDiscount(string customerType,double amount)
        {
            if (customerType == "Regular")
                return amount * 0.05;

            if (customerType == "Premium")
                return amount * 0.10;

            return 0;
        }
    }
}
/*
 Every time a new customer type appears:
VIP
Gold
Platinum
i must need to modify this class and that violates OCP
*/