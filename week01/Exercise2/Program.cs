using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is you grade percentage? ");
        string userInput = Console.ReadLine();
        int percentage = int.Parse(userInput);
        string letterGrade;
        string grade;

        if (percentage >= 90)
        {
            letterGrade = "A";
        }
        else if (percentage >= 80)
        {
            letterGrade = "B";
        }
         else if (percentage >= 70)
        {
            letterGrade = "C";
        } else if (percentage >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }
        
        int lastDigit = percentage % 10;

        if (lastDigit >=7)
        {
            grade = letterGrade + "+";
        }
        else if (lastDigit <3)
        {
            grade = letterGrade +"-";
        }
        else
        {
            grade = letterGrade;
        }

        Console.WriteLine($"Your Letter Grade is...   {grade}");
    }
}