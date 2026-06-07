int n = int.Parse(Console.ReadLine());
string str = Console.ReadLine().ToLower();

bool[] seen = new bool[26];

foreach (char c in str)
{
    if (c >= 'a' && c <= 'z')
    {
        seen[c - 'a'] = true;
    }
}

bool isPangram = true;
for (int i = 0; i < 26; i++)
{
    if (!seen[i])
    {
        isPangram = false;
        break;
    }
}

if (isPangram)
    Console.WriteLine("YES");
else Console.WriteLine("NO");