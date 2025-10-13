using Enumerable_Enumerator;
using System.Linq;

var keyboard = new Keyboard();
keyboard.Add(new Key { Name = "A", Code = 65 });
keyboard.Add(new Key { Name = "B", Code = 66 });
//foreach (var key in keys)
//{
//    Console.WriteLine($"{key.Name} : {key.Code}");
//}

foreach (var key in keyboard)
{
    //Console.WriteLine($"{key.Name} : {key.Code}");
    

}

var a = new Key { Name = "A", Code = 65 };
//Console.WriteLine(keyboard.Contains( new Key { Name = "A",Code = 65} ));
Console.WriteLine(keyboard.Count);