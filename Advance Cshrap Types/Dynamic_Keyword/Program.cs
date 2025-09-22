
using System.Net.Http.Headers;

dynamic x = "hello";

string y = x.Replace("ll", "mm");

Console.WriteLine(y);

dynamic r = new DateTime(2002, 5, 5);
DateTime r2 = r.AddDays(3);
Console.WriteLine(r2.Day);

r = "hello";
string r3 = r.Replace("ll", "mm");
Console.WriteLine(r3);


dynamic m = GetSomeData();
Console.WriteLine(m.Price);


object GetSomeData()
{
    return new { Price = 2000, Weight = 300 };
}