string a = Console.ReadLine().ToLower();
string b = Console.ReadLine().ToLower();
int result = string.Compare(a, b);
if (result > 0)
{
    Console.WriteLine("1");
}
else if (result < 0)
{
    Console.WriteLine("-1");
}
else
{
    Console.WriteLine("0");
}
Console.ReadKey();

