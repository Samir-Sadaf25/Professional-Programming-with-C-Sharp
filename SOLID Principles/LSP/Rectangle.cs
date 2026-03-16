using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    public class Rectangle
    {
        public int width {  get; set; }
        public int height { get; set; }
        public int CalculateArea()
        {
            return width * height;
        }
    }
}
