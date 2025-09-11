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

            base.Print(count);
            Console.WriteLine("child class");
           
        }
    }
}
