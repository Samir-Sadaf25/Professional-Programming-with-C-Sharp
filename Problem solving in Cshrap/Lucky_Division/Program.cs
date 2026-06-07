
int n = int.Parse(Console.ReadLine() ?? "0");
int[] lucky = new int[]
{
            4,7,44,47,74,77,444,447,474,477,744,747,774,777
};

foreach (var x in lucky)
{
    if (n % x == 0)
    {
        Console.WriteLine("YES");
        return;
    }
}

Console.WriteLine("NO");