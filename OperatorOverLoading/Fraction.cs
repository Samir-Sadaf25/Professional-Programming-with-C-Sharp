using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverLoading
{
    public struct Fraction
    {
        public int num { get; private set; }
        public int den { get; private set; }
        public Fraction(int numerator, int denuminator)
        {
            if (denuminator == 0)
            {
                throw new ArgumentException("Denuminator cannot be zero",nameof(denuminator));
            }
            den = denuminator;
            num = numerator;
        }
        public static Fraction operator +(Fraction a, Fraction b)
        {
            return new Fraction(a.num * b.den + b.num * a.den,a.den * b.den);
        }
    }
}
