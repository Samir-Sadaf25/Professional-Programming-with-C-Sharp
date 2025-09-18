using ParameterModifiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params
{
    public class Calculator
    {
        public int sum(params int[] items)
        {
            var sum = 0;
            foreach (var item in items)
            {
                sum += item;
            }
            return sum;
        }

        public void InsertValue(in int x) // akhane baire theke jeta dibo oitai nibe
        {
            //x = 3;
        }

        public void InsertValue2(out Person x) // akhane method theke jeta pathabo oita program.cs file receive korbe
        {
            x = new Person();
            x.IncreaseAge();
        }

        public void InsertValue3(ref Person x) // eta c++ pointer er moto kaj kore
        {
            x.IncreaseAge();
        }

    }
}
