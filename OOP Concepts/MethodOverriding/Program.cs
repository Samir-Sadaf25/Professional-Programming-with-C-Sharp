using MethodOverriding;
Console.WriteLine("using parrent method");
number n1 = new number();
n1.numberItems = [4,5,6,7,8,9];
n1.Print(6);

Console.WriteLine("using child method");

modifiedNumber n2 = new modifiedNumber();
n2.numberItems = [4, 5, 6, 7, 8, 9];
n2.Print(6);