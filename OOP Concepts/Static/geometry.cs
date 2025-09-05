using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    public class geometry
    {
        private static double _pi = 3.14159;
        public static double PI  { get { return _pi; } }
        static geometry()
        {
            _pi = 22 / 7;
        }
        public static double CircleArea(double radius)
        {
            return _pi * radius * radius;
        }
    }
}
