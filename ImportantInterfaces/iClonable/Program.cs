using iClonable;

Product p1 = new Product{Name = "camera",Price = 30.5};
Product p2 = (Product)p1.Clone();

p1.Price = 40;
Console.WriteLine($"{p1.Price} and {p2.Price}");