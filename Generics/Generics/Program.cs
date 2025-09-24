using Generics;

BubbleSort<Double> sorting = new BubbleSort<double>([1.24, 8.25, 5.4, 7.6, 3.5]);
BubbleSort2 sort2 = new BubbleSort2();
var result2 = sort2.Sort<double>([1.24, 8.25, 5.4, 7.6, 3.5]);
sorting.Sort(); 
foreach (var item in result2)
{
    Console.WriteLine(item);
}