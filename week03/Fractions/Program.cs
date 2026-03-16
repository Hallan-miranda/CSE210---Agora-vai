using System;

class Program
{
    static void Main(string[] args)
    {
        Fractions test1 = new Fractions();
        Fractions test2 = new Fractions();
        Fractions test3 = new Fractions();
        Fractions test4 = new Fractions();

        test1.SetFraction();
        test2.SetFraction(5);
        test3.SetFraction(3,4);
        test4.SetFraction(1,3);

        
        test1.GetFractionString();
        test1.GetDecimalvalue();
        test2.GetFractionString();
        test2.GetDecimalvalue();
        test3.GetFractionString();
        test3.GetDecimalvalue();
        test4.GetFractionString();
        test4.GetDecimalvalue();
    }
}