using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Menu Optinions:");
        Console.WriteLine("1 - Breathing Activity\n2 - Reflection Activity\n3 - Listing Activityz\n4 - Quit");
        Console.Write("Select a choice from the menu: ");
        string activty = Console.ReadLine();

        if(activty == "1")
        {
            BreathingActivity activity = new BreathingActivity();

            activity.SetActivity("Breathing Activity","This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
            Console.WriteLine(activity.DisplayActivity());
            Console.Write("How long, in seconds would like foryour session? ");
            string time = Console.ReadLine();
            int timeInt = int.Parse(time);
            activity.SetTimeActivity(timeInt);
            activity.GetReady();
            activity.displayBreathigActivity(timeInt);
            Console.WriteLine(activity.FinishActivity());

        }
        else if(activty == "2")
        {
            ReflectionActivity activity2 = new ReflectionActivity();

            activity2.SetActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
            activity2.DisplayActivity();
            Console.WriteLine("How long, in seconds would like foryour session? ");
            string time = Console.ReadLine();
            int timeInt = int.Parse(time);
            activity2.SetList();
            activity2.GetReady();
            activity2.SetTimeActivity(timeInt);
            activity2.DisplayReflectionActivity(timeInt);
            Console.WriteLine(activity2.FinishActivity());
        
        }
        else if(activty == "3")
        {
            ListingActivity activity3 = new ListingActivity();
            
            activity3.SetActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
            Console.WriteLine(activity3.DisplayActivity());
            Console.WriteLine("How long, in seconds would like foryour session? ");
            string time = Console.ReadLine();
            int timeInt = int.Parse(time);
            activity3.SetList();
            activity3.GetReady();
            activity3.SetTimeActivity(timeInt);
            activity3.DisplayListingActivity(timeInt);
            Console.WriteLine(activity3.FinishActivity());
        }
        else
        {
            
        };

    }
}