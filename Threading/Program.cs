

Thread t1 = new Thread(() => PrintOdd(100));
Thread t2 = new Thread(() => PrintEven(100));
t1.Start();
t2.Start();


static void PrintOdd(object? count)
{
    for (int i = 1; i < (int)count; i+=2)
    {
        Console.WriteLine(i);
      Thread.Sleep(200); // first e even execute hobe..then 200 mili sec. por por Odd execute hobe
    }
}
//ar sleep na thakle 2 ta parallaly cholbe
static void PrintEven(object? count)
{
    for (int i = 0; i < (int)count; i+=2)
    {
        Console.WriteLine(i);
        //Thread.Sleep(200);
    }
}
