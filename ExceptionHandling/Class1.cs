using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class Class1
    {
        public void method1()
        {
            try
            {
                var item = new Class2();
                item.method2();
            }
            catch (Exception fe)
            {
                {
                    Console.WriteLine(fe.StackTrace);
                }
            }
        }
    }
}
