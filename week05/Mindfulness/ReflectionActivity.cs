using System;
using System.Diagnostics;


class ReflectionActivity : Activity
{

    List <string> _thinks = new List<string>();
    List <string> _ThinkQuestions = new List<string>();
    Random rnd = new Random();

    public void SetList()
    {
        _thinks.Add("Think of a time when you stood up for someone else.");
        _thinks.Add("Think of a time when you did something really difficult.");
        _thinks.Add("Think of a time when you helped someone in need.");
        _thinks.Add("Think of a time when you did something truly selfless.");

        _ThinkQuestions.Add("Why was this experience meaningful to you?");
        _ThinkQuestions.Add("Have you ever done anything like this before?");
        _ThinkQuestions.Add("How did you get started?");
        _ThinkQuestions.Add("How did you feel when it was complete?");
        _ThinkQuestions.Add("What made this time different than other times when you were not as successful?");
        _ThinkQuestions.Add("What is your favorite thing about this experience?");
        _ThinkQuestions.Add("What could you learn from this experience that applies to other situations?");
        _ThinkQuestions.Add("What did you learn about yourself through this experience?");
        _ThinkQuestions.Add("How can you keep this experience in mind in the future?");
    }

    public void DisplayReflectionActivity(int duration)
    {
        int indexThink = Random.Shared.Next(1,_thinks.Count);
        int[] indexQuestion = Enumerable.Range(0,_ThinkQuestions.Count).ToArray();
        Random.Shared.Shuffle(indexQuestion);
        int i = 1;


        Console.WriteLine($"---{_thinks[indexThink]}---");
        Console.WriteLine("\nWhen you have something mind, press enter to continue.");
        Console.ReadLine();

        Stopwatch stopwatch = new Stopwatch();

        while(stopwatch.Elapsed.TotalSeconds < duration)
        {
            stopwatch.Start();

            string loading = @"| / – \ | / – \ | / – \ | / – \";


                Console.WriteLine($"\r{_ThinkQuestions[i]}\n");

                string[] simbols = loading.Split(" ");
                foreach(string simbol in simbols)
                {
                    Thread.Sleep(500);;
                    Console.Write($"\r{simbol}");
                }
                Console.Write("\r ");
                
                i += 1;



        }



        Console.WriteLine("\nWell Done!");

        
    
    }
}