using System;
using System.Diagnostics;


class ListingActivity : Activity
{
    
    List <string> _ThinkQuestions = new List<string>();
    int _answer = 0;


    public void SetList()
    {
        _ThinkQuestions.Add("Who are people that you appreciate?");
        _ThinkQuestions.Add("What are personal strengths of yours?");
        _ThinkQuestions.Add("Who are people that you have helped this week?");
        _ThinkQuestions.Add("When have you felt the Holy Ghost this month?");
        _ThinkQuestions.Add("Who are some of your personal heroes?");
    }

    public void DisplayListingActivity(int duration)
    {
        Stopwatch stopwatch = new Stopwatch();

        int indexQuestion = Random.Shared.Next(1, _ThinkQuestions.Count());


        while(stopwatch.Elapsed.TotalSeconds < duration)
        {
            stopwatch.Start();
            Console.WriteLine($"--- {_ThinkQuestions[indexQuestion]} ---");


            for (int i = 5; i > 0; i--)
            {
                Console.Write($"\rYou may begin in:{i}");
                Thread.Sleep(1000);
            }     
            Console.Write($"\rYou may begin in:   ");

            while(stopwatch.Elapsed.TotalSeconds < duration)
            {
                Console.ReadLine();
                _answer += 1;
            }

        }

        
        Console.WriteLine($"You listed {_answer} items!");
        Console.WriteLine("\nWell Done!");

        
    
    }
}