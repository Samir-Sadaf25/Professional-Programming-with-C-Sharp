using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class Class2
    {
        public void method2()
        {
            try
            {
                File.ReadAllText("hello.txt");
            }
            catch (FileNotFoundException fe)
            {
                Console.WriteLine("error");
                throw;
            }
        }
    }
}
