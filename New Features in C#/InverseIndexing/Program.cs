string[] fruits = ["apple", "banana", "cherry", "jackfruits"];

Console.WriteLine(fruits[0]);
Console.WriteLine(fruits[1]);
Console.WriteLine(fruits[2]);
Console.WriteLine(fruits[3]);
Console.WriteLine(" ");
Console.WriteLine(fruits[^1]);
Console.WriteLine(fruits[^2]);
Console.WriteLine(fruits[^3]);
Console.WriteLine(fruits[^4]);

for (int i = 1; i < 5; i++)
{
    Console.WriteLine(fruits[^i]);
}