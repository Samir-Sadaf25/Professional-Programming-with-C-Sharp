int n = int.Parse(Console.ReadLine());
int a, b;
int min = 0;
int passenger = 0;
for (int i = 0; i < n; i++)
{
    string[] line = Console.ReadLine().Split(' ');
    a = int.Parse(line[0]);
    b = int.Parse(line[1]);
    passenger = (passenger + b) - a;
    if (passenger > min)
    {
        min = passenger;
    }
}
Console.WriteLine(min);