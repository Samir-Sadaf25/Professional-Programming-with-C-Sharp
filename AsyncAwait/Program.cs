//example1
//class Program
//{
//    static async Task Main(string[] args)
//    {
//        await callMethod();
//        Console.ReadKey();
//    }
//    public static async Task callMethod()
//    {
//        Method2();
//        var count = await Method1();
//        Method3(count);
//    }
//    public static async Task<int> Method1()
//    {
//        int count = 0;
//        await Task.Run(() =>
//        {
//            for (int i = 0; i < 100; i++)
//            {
//                Console.WriteLine(" Method 1");
//                count += 1;
//            }
//        });
//        return count;
//    }
//    public static void Method2()
//    {
//        for (int i = 0; i < 25; i++)
//        {
//            Console.WriteLine(" Method 2");
//        }
//    }

//    public static void Method3(int count)
//    {
//        Console.WriteLine("Total count is " + count);
//    }
//}



using System;
using System.Threading.Tasks;

public class Program
{
    public static async Task Main()
    {
        var p = new Program();
        await p.MakeTeaAsync();
    }

    public async Task<string> MakeTeaAsync()
    {
        var boilingTask = BoilWaterAsync();
        Console.WriteLine("take the cups out");
        int a = 0;
        for(int i =  0; i < 10; i++)
        {
            a += i;
        }
        Console.WriteLine("put the tea in cups");
        var water = await boilingTask;
        var tea = $"pour {water} in cups";
        Console.WriteLine(tea);
        return tea;
    }

    public async Task<string> BoilWaterAsync()
    {
        Console.WriteLine("start the kettle");
        Console.WriteLine("waiting for the kettle");
        await Task.Delay(1500);
        Console.WriteLine("kettle finished boiling");
        return "water";
    }
  
}