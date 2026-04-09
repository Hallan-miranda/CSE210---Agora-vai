using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Square shape1 = new Square("blue", 5);
        Console.WriteLine(shape1.GetArea());
        Console.WriteLine(shape1.GetColor());

        Circule shape2 = new Circule("blue", 5);
        Console.WriteLine(shape2.GetArea());
        Console.WriteLine(shape2.GetColor());

        Rectangule shape3 = new Rectangule("blue", 5, 10);
        Console.WriteLine(shape3.GetArea());
        Console.WriteLine(shape3.GetColor());
    }
}