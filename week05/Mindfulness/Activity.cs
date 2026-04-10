using System;


class Activity
{
    string _name;
    string _description;
    int _duration;
    List<string> _questions = new List<string>();



    public void SetActivity(string name, string description)
    {
        _description = description;
        _name = name;
    }

    public void SetTimeActivity( int duration)
    {
        _duration = duration;
    }


    public void SetQuestions(List<string> questions)
    {
        foreach (var question in questions)
        {
            _questions.Add(question);
        }
    }

    public void GetReady()
    {
        int readyTime = 2;
        string loading = @"| / – \ | / – \";

        Console.WriteLine("Get ready...");
        while(readyTime != 0)
        {
            string[] simbols = loading.Split(" ");
            foreach(string simbol in simbols)
            {
                Thread.Sleep(500);;
                Console.Write($"\r{simbol}");
            }
            Console.Write("\r ");

            readyTime -= 1;

        }
        Console.WriteLine("");

    }
    
    public string DisplayActivity()
    {
        Console.Clear();
        return $"Welcome to the {_name}\n\n{_description}\n\n";
    }

    public string FinishActivity()
    {
        return ($"\nYou have completed another {_duration} second(s) of the {_name}");
    }
}