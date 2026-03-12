using Func_Action;

BubbleSort2<int> sort = new BubbleSort2<int>();
var result = sort.Sort([5,2, 4, 1, 3, 7, 6],checkCondition);

bool checkCondition(int x, int y)
{
    //return x > y;
    return x < y;
}
//foreach(var item in result)
//{
//    Console.WriteLine(item);
//}

Func<int, int, int> add = (a, b) => a + b;
Func<int, int, int> multiply = (a, b) => a * b;

Console.WriteLine(add(3,4));
Console.WriteLine(multiply(3,4));

Action<string> print = message => Console.WriteLine(message);

print("hello i am samir..learning func and action");