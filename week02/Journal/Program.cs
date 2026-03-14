using System;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator prompt = new PromptGenerator();

        prompt.DisplayStartPrompts();

        while (prompt._Choice != "5")
        {

            if(prompt._Choice == "1")
            {
                prompt.CreatPrompt();
                prompt.DisplyRandomPrompt();
            }
            else if (prompt._Choice == "2")
            {
                prompt.DisplayJournal();
            }
            else if (prompt._Choice == "3")
            {
                prompt.loadRegister();
            }
            else if (prompt._Choice == "4")
            {
                prompt.SaveRegisters();
            }

            prompt.DisplayStartPrompts();

        }
    }
}