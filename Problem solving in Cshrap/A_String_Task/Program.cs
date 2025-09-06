
string s = Console.ReadLine();
string s2 = "";
for (int i = 0; i < s.Length; i++)
{
    if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u' || s[i] == 'A' || s[i] == 'E' || s[i] == 'I' || s[i] == 'O' || s[i] == 'U')
        continue;
    else
    {
        s2 += ".";
        s2 += char.ToLower(s[i]);

    }
}

Console.WriteLine(s2);
Console.ReadKey();