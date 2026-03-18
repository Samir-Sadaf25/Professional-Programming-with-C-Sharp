using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
     public class OrderService
    {
        private EmailService _emailService = new EmailService();
        public void placeOrder()
        {
            Console.WriteLine("Order placed");
            _emailService.Send();
        }
    }
}
