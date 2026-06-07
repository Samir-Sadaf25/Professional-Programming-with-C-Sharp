string[] first = Console.ReadLine()!.Split(' ');
int n = int.Parse(first[0]);
int h = int.Parse(first[1]);

string[] parts = Console.ReadLine()!.Split(' ');

int width = 0;
for (int i = 0; i < n && i < parts.Length; i++)
{
    int height = int.Parse(parts[i]);
    if (height <= h) width += 1;
    else width += 2;
}

Console.WriteLine(width);