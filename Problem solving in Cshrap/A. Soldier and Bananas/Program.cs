
string[] line = Console.ReadLine().Split(' ');
int k = int.Parse(line[0]);
int n = int.Parse(line[1]);
int w = int.Parse(line[2]);

int sum  = 0;
for (int i = 1; i <= w; i++)
{
    sum += i;
}
int borrow = (sum * k) - n;
if (borrow > 0)
    Console.WriteLine(borrow);
else Console.WriteLine(0);