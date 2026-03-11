using OperatorOverLoading;

Fraction f1 = new Fraction(2,3);
Fraction f2 = new Fraction(4,5);
Fraction result = f1 +  f2;

Console.WriteLine($"{result.num} / {result.den}");