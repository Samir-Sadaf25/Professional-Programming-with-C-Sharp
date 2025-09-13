string s = Console.ReadLine();
int zero = 0;
int one = 0;
for (int i = 0; i < s.Length; i++)
{
    if (s[i] == '1')
    {
        one++;
        zero = 0;
    }
    else
    {
        zero++;
        one = 0;
    }
    if(zero >= 7 || one >= 7)
    {
        Console.WriteLine("YES");
        return;
    }
}
Console.WriteLine("NO");