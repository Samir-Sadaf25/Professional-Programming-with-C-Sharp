using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.AnotherExample
{
    
    public class OrderService
    {
        public void CreateOrder(Order order )
        {
           SaveToDatabase( order );
            SendEmail(order);
            Log(order);
        }
        private void SaveToDatabase( Order order )
        {
            Console.WriteLine("saving order");
        }
        private void SendEmail(Order order)
        {
            Console.WriteLine("sending email");
        }
        private void Log(Order order)
        {
            Console.WriteLine("logging order");
        }
    }
}
