using System;
using System.Diagnostics;


class BreathingActivity : Activity
{
    int _breathingtime = 3;

    public void displayBreathigActivity(int duration)
    {

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();


        while(stopwatch.Elapsed.TotalSeconds < duration)
        {
            for (int i = _breathingtime; i > 0; i--)
            {
                Console.Write($"\rBreathing in...{i}");
                Thread.Sleep(1000);
            }     
            Console.Write($"\rBreathing in... ");

            Console.WriteLine("");

            for (int i = _breathingtime; i > 0; i--)
            {
                Console.Write($"\rBreathing out...{i}");
                Thread.Sleep(1000);
            }   
            Console.Write($"\rBreathing out ... ");
            Console.WriteLine("\n");


        }

        Console.WriteLine("\nWell Done!");

        
    }

}