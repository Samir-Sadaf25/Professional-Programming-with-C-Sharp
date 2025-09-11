using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    public class number
    {
        public int[] numberItems { get; set; }
        public virtual void Print(int count)
        {
            foreach(int item in numberItems)
            {
                if(item > count)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
