string s = Console.ReadLine();
HashSet<char> userSet = new HashSet<char>();
for (int i = 0; i < s.Length; i++)
{
    userSet.Add(s[i]);
}
if (userSet.Count % 2 == 0)
    Console.WriteLine("CHAT WITH HER!");
else Console.WriteLine("IGNORE HIM!");
