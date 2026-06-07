int n = int.Parse(Console.ReadLine()!);
int sum = Console.ReadLine()!
              .Split(' ', StringSplitOptions.RemoveEmptyEntries)
              .Select(int.Parse)
              .Sum();

Console.WriteLine(sum > 0 ? "HARD" : "EASY");