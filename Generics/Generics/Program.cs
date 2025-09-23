using Generics;

BubbleSort<Double> sorting = new BubbleSort<double>([1.24, 8.25, 5.4, 7.6, 3.5]);
sorting.Sort(); 
foreach (var item in sorting.items)
{
    Console.WriteLine(item);
}