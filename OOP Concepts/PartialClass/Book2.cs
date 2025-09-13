using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    public partial class Book
    {
        public void showInfo()
        {
            Console.WriteLine("Book-Name "+Name);
            Console.WriteLine("Author "+Author);
            Console.WriteLine("Publishing Year "+Year);
        }
    }
}
