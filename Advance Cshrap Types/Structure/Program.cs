using Structure;

int x = 5;
int y= x; // value type  
x = 7;
Console.WriteLine(x);
Console.WriteLine(y);

Person p1 = new Person { age = 22,Name = "Samir" };
Person p2 = p1; // if we use struct type then it will pass it's value
// but if we use class type it will pass it's reference. it work like pointer concept
p2.age = p1.age;
p1.age = 25;
Console.WriteLine(p1.age);
Console.WriteLine(p2.age);