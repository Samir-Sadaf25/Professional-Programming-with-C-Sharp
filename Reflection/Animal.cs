using System;
using System.Collections.Generic;
using System.Text;

namespace Reflection
{
    public class Animal
    {
        public string Species { get; set; }
        public int Legs { get; set; }

        public void Describe()
        {
            Console.WriteLine($"This is a {Species} with {Legs} legs.");
        }
    }
}
