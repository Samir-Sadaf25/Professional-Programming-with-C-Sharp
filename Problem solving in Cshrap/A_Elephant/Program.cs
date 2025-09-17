string line = Console.ReadLine();
int n = int.Parse(line);
int min_step;
if (n % 5 == 0)
    min_step = n / 5;
else min_step = n / 5 + 1;
Console.WriteLine(min_step);