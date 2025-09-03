using Polymorphism;
using System.Runtime.Intrinsics.X86;

product p = new Burger(); // parrent class e child class er instance 
Burger b = new Burger(); 
p.name = "Beef Burger";
b.name = "Chicken Burger";
p.PrintName();
b.PrintName();