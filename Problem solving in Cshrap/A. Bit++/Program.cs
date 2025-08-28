int value = 0;
int t = int.Parse(Console.ReadLine());

while (t-- > 0)
{
   
    string str = Console.ReadLine();
        if (str.Contains("++"))
        {
            value++;
            break;
        }
        else if (str.Contains("--"))
        {
            value--;
            break;
        }

    Console.ReadKey();
}

Console.WriteLine(value);


