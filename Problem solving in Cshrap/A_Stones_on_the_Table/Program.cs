string line = Console.ReadLine();
int n = int.Parse(line);
string stones = Console.ReadLine();
int count = 0;
for (int i = 0; i < n-1; i++)
{
    if (stones[i] == stones[i+1])
    {
        count += 1;
    }
}
Console.WriteLine(count);
