using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        string answer = "";

        do
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);
            int userGuess = 0;
            int guesses = 0;

            do
            {
                Console.Write("What is you guess? ");
                string theUserGuess = Console.ReadLine();

                userGuess = int.Parse(theUserGuess);
                guesses++;

                if (magicNumber > userGuess)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < userGuess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You guessed it in {guesses} guesses!");
                }

            } while (magicNumber != userGuess);

            Console.WriteLine("Do you want to play again? (yes/no)");
            answer = Console.ReadLine();

        } while (answer.ToLower() == "yes");

        

    }

    
}