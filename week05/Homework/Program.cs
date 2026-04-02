using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssigment assigment1 = new MathAssigment();
        assigment1.SetstudentName("Hallan Miranda");
        assigment1.SetTopic("Software");
        assigment1.SetTextbookSection("Secition 1.3");
        assigment1.SetProblems("Problem 9 - 14");
        Console.WriteLine(assigment1.GetSumary());
        Console.WriteLine(assigment1.GetHomeworkList());

        WritingAssigment assigment2 = new WritingAssigment();
        assigment2.SetstudentName("Mayara Miranda");
        assigment2.SetTopic("Word History");
        assigment2.SetTitle("Spanish flu");
        Console.WriteLine(assigment2.GetSumary());
        Console.WriteLine(assigment2.GetWritingInformation());
    }
}