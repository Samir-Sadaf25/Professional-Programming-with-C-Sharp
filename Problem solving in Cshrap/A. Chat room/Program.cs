string s = Console.ReadLine();
string a = "hello";
int x = 0;
for (int i = 0; i < s.Length; i++)
{
    if (s[i] == a[x])
    {
        x++;
        if (x == a.Length)
            break;
    }
}
if (x == a.Length)
    Console.WriteLine("YES");
else Console.WriteLine("NO");