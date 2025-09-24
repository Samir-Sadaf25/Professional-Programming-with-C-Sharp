using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class BubbleSort2 {
        public T[] Sort<T>(T[] arr) where T : INumber<T>
        {
            T temp;
            for (int j = 0; j <= arr.Length - 2; j++)
            { 
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1]; arr[i + 1] = arr[i]; arr[i] = temp; 
                    } 
                }
            }
            return arr;
        }
    
    }
}
