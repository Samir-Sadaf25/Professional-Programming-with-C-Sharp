 int n = int.Parse(Console.ReadLine());
string[] words = new string[n]; 
for (int i = 0; i < n; i++)
{
    words[i] = Console.ReadLine();
}
foreach (var s in words)
{
    if (s.Length > 10)
        Console.WriteLine($"{s[0]}{s.Length - 2}{s[^1]}");
    else
        Console.WriteLine(s);
}


