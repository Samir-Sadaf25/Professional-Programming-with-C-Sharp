using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public class Robot : IWorker
    {
        public void Eat()
        {
            throw new NotImplementedException(); // ❌ robot doesn't eat
        }

        public void Work()
        {
            throw new NotImplementedException(); 
        }
    }
}
