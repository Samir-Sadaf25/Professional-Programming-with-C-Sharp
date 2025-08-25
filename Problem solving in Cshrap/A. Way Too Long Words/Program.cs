int n = int.Parse(Console.ReadLine());
string[] words = new string[n]; 
for (int i = 0; i < n; i++)
{
    words[i] = Console.ReadLine();
}
foreach (var s in words)
{
    if (s.Length > 10)
        Console.WriteLine($"{s[0]}{s.Length - 2}{s[^1]}");
    else
        Console.WriteLine(s);
}
Console.ReadKey();

//int n = int.Parse(Console.ReadLine());    // Phase 1: read count

//// Phase 1: read and store all words
//string[] words = new string[n];
//for (int i = 0; i < n; i++)
//{
//    words[i] = Console.ReadLine();
//}

//// Phase 2: process and collect outputs
//var results = new List<string>(n);
//foreach (var s in words)
//{
//    if (s.Length > 10)
//        results.Add($"{s[0]}{s.Length - 2}{s[^1]}");
//    else
//        results.Add(s);
//}

//// Phase 2: print all at once
//Console.WriteLine(string.Join(Environment.NewLine, results));

//// Prevent console window from closing immediately
//Console.ReadKey();
