using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        string num = "";
        double sumNum = 0;
        double averageNum = 0;
        int largestNum = 0;
        int smallestNum = 0;

        Console.WriteLine("Enter a list of number, type 0 when finished.");
        while (num != "0")
        {
            Console.WriteLine("Enter a number");
            num = Console.ReadLine();
            if(num != "0")
            {
                numbers.Add(int.Parse(num));
            }
        }

        foreach (double number in numbers)
        {
            sumNum = sumNum + number;
        }

        double numLength = numbers.Count();
        averageNum = sumNum / numLength;

        largestNum = numbers.Max();

        smallestNum = numbers.Where(numero => numero > 0 ).Min();

        numbers.Sort();

        Console.WriteLine($"The sum is: {sumNum}");
        Console.WriteLine($"The average is: {averageNum}");
        Console.WriteLine($"The largest number is: {largestNum}");
        Console.WriteLine($"The smallest positive number is: {smallestNum}");
        
        foreach (int number in numbers)
        {
        Console.WriteLine(number);
        }
    }
}