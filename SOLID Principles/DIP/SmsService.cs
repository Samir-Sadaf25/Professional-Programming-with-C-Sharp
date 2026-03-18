using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    public class SmsService : IMessageService
    {
        public void Send()
        {
            Console.WriteLine("Sending SMS");
        }
    }
}
