using System;

public interface Ihero
{
    void Attack();
    void Defend();
}

public class IronMan : Ihero
{
    public void Attack()
    {
        Console.WriteLine("IronMan attacks with repulsor beams!");
    }
    public void Defend()
    {
        Console.WriteLine("IronMan activates his energy shield!");
    }
}

public class CaptainAmerica : Ihero
{
    public void Attack()
    {
        Console.WriteLine("Captain America throws his shield!");
    }
    public void Defend()
    {
        Console.WriteLine("Captain America uses his shield to block attacks!");
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        Ihero h1 = new IronMan();
        Ihero h2 = new CaptainAmerica();
        h1.Attack();
        h1.Defend();
        h2.Attack();
        h2.Defend();
    }
}
