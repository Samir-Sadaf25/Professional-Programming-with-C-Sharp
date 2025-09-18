using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterModifiers
{
    public struct Person
    {
        public int Age { get; private set; }
        public void IncreaseAge()
        {
            this.Age += 1;
        }
    }
}