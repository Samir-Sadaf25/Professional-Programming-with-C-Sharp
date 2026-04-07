using Records;

Laptop laptop1 = new Laptop { Brand = "HP", price = 50000 };
Laptop laptop2 = new Laptop { Brand = "HP", price = 50000 };

if (laptop1 == laptop2)
{
    Console.WriteLine("same"); // if we use record then we get same..cause record compare value 
}
else Console.WriteLine("not same"); // if we use class then we get not same..cause both of their memory is different