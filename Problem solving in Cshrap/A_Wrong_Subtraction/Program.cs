string[] line = Console.ReadLine().Split(' ');
int n = int.Parse(line[0]);
int k = int.Parse(line[1]);
for (int i = 0; i < k; i++)
{
    if (n % 10 == 0)
    {
        n = n / 10;
    }
    else n = n - 1;
}
Console.WriteLine(n);