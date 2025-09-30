string s = Console.ReadLine();
int count1 = 0;
int count2 = 0;
for (int i = 0; i < s.Length; i++)
{
    if (s[i] >= 65 && s[i] <= 90)
    {
        count1++;
    }
    else if (s[i] >= 97 && s[i] <= 122)
    {
        count2++;
    }

}
if (count1 > count2)
{
    Console.WriteLine(s.ToString().ToUpper());
}
else
{
    Console.WriteLine(s.ToString().ToLower());
}