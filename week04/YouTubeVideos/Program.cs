using System;

class Program
{
    static void Main(string[] args)
    {
        Video _video = new Video("Learn C# Programming Basics for Unity Game Development - Part 1", "Sunny Valley Studio", 721);

        _video.SetComments("Grosser25", "i was stuck for a day because of an uppercase T that was suppose to be lowercase lol");
        _video.SetComments("PurpleManRBX", "First time a Unity/C# Tutuorial has actually had me code a functional script. Thanks!");
        _video.SetComments("krishnateja8192", "Just Wow…❤ never never never seen this kind of video");
        
        int _quantity = _video.GetCommentCount();


        _video.DisplayVideoInformation();
        Console.WriteLine($"Comments Quantity: {_quantity}");
        _video.DisplayComments();



    }
}