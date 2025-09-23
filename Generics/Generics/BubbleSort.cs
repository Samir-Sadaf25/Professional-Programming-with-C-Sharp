using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class BubbleSort<T> where T : INumber<T>
    {
        public T[] items { get; set; }

        public BubbleSort(T[] arr)
        {
            items = arr;
        }

        public void Sort()
        {
            T temp;
            for (int j = 0; j <= items.Length - 2; j++)
            {
                for (int i = 0; i <= items.Length - 2; i++)
                {
                    if (items[i] > items[i + 1])
                    {
                        temp = items[i + 1];
                        items[i + 1] = items[i];
                        items[i] = temp;
                    }
                }
            }
          
        }

    }
}
