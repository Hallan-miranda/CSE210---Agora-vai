using System;
using System.Data.Common;
using System.IO;


public class PromptGenerator
{
    public string _Choice;
    Random random = new Random();
    string _answer;
    List<string> _prompts = new List<string>();
    public List<Journal> _registers = new List<Journal>();


    public void DisplayStartPrompts()
    {
        Console.WriteLine("Welcome to the jornal Program");
        Console.WriteLine("PLease select ones of the following choices:");
        Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
        Console.WriteLine("What Would you like to do? ");

        _Choice = Console.ReadLine();
    }
    public void CreatPrompt()
    {
        _prompts.Add("What was the best part of your day?");
        _prompts.Add("Did anything surprise you today?");
        _prompts.Add("How did you feel most of the day?");
        _prompts.Add("What did you learn or realize today?");
        _prompts.Add("What are you grateful for today?");

    }

    public void DisplyRandomPrompt()
    {
        int index = random.Next(0,_prompts.Count);

        Console.WriteLine(_prompts[index]);

        _answer = Console.ReadLine();

        _registers.Add(new Journal
        {
            _date = DateTime.Now,
            _jAnswer = _answer,
            _prompt = _prompts[index]
        });


    }

    public void DisplayJournal()
    {
        foreach ( Journal entry in _registers)
        {
            Console.WriteLine($"Date: {entry._date} - Prompt: {entry._prompt}");
            Console.WriteLine($"{entry._jAnswer}");
            
        }
    }

    public void SaveRegisters()
    {
        Console.WriteLine("What is the filename? ");
        string fileName = Console.ReadLine();

        foreach(Journal entry in _registers)
        {
            File.AppendAllText(fileName, $"Date: {entry._date} - Prompt: {entry._prompt} \n {entry._jAnswer} \n");
        }
    }

    public void loadRegister()
    {
        Console.WriteLine("What is the filename? ");
        string fileName = Console.ReadLine();

        string[] lines = File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }

    }
}
