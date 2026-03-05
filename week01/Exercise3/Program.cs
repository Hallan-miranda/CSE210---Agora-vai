using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 50);
        int guessNumber ;
        int atempts = 0;
        string again = "yes";

        while (again == "yes" || again == "Yes" || again == "YES")
        {
            
            Console.WriteLine("What is the magic number?");
            do 
            {
                Console.Write("What is your guess? ");
                string guess = Console.ReadLine();
                guessNumber = int.Parse(guess);
                if (guessNumber > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (guessNumber < magicNumber)
                {
                    Console.WriteLine("Highers");
                }

                atempts = atempts + 1;
            } while(guessNumber != magicNumber);

            Console.WriteLine("You guessed it!!!");
            Console.WriteLine($"Atempts: {atempts}");
            Console.WriteLine("Did you like continue? ");
            again = Console.ReadLine();
            
        }
    }
}