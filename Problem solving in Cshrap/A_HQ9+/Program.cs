string p = Console.ReadLine();
if (string.IsNullOrEmpty(p))
{
    Console.WriteLine("NO");
    return;
}

foreach (char ch in p)
{
    if (ch == 'H' || ch == 'Q' || ch == '9')
    {
        Console.WriteLine("YES");
        return;
    }
}

Console.WriteLine("NO");
