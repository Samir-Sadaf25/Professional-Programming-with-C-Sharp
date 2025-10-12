using Enumerable_Enumerator;

var keyboard = new Keyboard();

//foreach (var key in keys)
//{
//    Console.WriteLine($"{key.Name} : {key.Code}");
//}

foreach (var key in keyboard)
{
    Console.WriteLine($"{key.Name} : {key.Code}");
    Console.WriteLine($"{key.Name} : {key.Code}");

}

