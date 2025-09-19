using ParameterModifiers;
using Params;

Calculator calculator = new Calculator();
// int r = calculator.Sum(new int[] { 2, 3, 5, 5 });
int r = calculator.sum(1, 2, 3, 4, 5);
//Console.WriteLine(r);



Person s = new Person();
s.IncreaseAge();
calculator.InsertValue2(out s);
//Console.WriteLine(s.Age);

Person p = new Person();
p.IncreaseAge();
calculator.InsertValue3(ref p);
//Console.WriteLine(p.Age);


int outsideVar = 20;
someFunction(out outsideVar);
Console.WriteLine(outsideVar);
static void someFunction(out int InsideVar)
{
    InsideVar = 0;
    InsideVar = InsideVar + 10;

}

//int outsideVar = 20;
//someFunction(ref outsideVar);
//Console.WriteLine(outsideVar);
//static void someFunction(ref int InsideVar)
//{
//    InsideVar = 20 + 10;

//}