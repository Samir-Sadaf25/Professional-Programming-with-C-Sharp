string[] line = Console.ReadLine().Split(' ');
int age1 = int.Parse(line[0]);
int age2 = int.Parse(line[1]);
int count = 0;
while (age1 <= age2)
{
    age1 *= 3;
    age2 *= 2;
    count++;
}
Console.WriteLine(count);