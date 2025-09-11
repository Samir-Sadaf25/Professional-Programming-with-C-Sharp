using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    public class modifiedNumber : number
    {
        public new void Print(int count) {

            Console.WriteLine("child class");
            foreach (int item in numberItems)
            {
               
                if (item > count)
                {
                   
                    Console.WriteLine(item);
                }
            }
        }
    }
}
