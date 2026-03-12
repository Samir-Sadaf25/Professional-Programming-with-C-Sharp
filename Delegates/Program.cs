using Delegates;



BubbleSort2<int> bubbleSort = new BubbleSort2<int>();
var result = bubbleSort.Sort([4, 2, 5, 3, 1, 7, 6], checkCondition);

//foreach (int i in result)
//{
//    Console.WriteLine(i);
//}

bool checkCondition(int a, int b)
{
    //return a > b; // acending order
    return a < b; // decending order
}
// simple example
static int Add(int x, int y)
{
    return x + y;
}
 static int Multiply(int x, int y)
{
    return x * y;
}

Operation op;
//op = Add;
op = Multiply;
int res = op(3, 4);
//Console.WriteLine(result);

delegate int Operation(int a, int b);