using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
     public class OrderService
    {
        private readonly IMessageService _messageService;

        public OrderService(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public void placeOrder()
        {
            Console.WriteLine("Order placed");
            _messageService.Send();
        }
    }
}
