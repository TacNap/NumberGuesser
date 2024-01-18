using System;

/* This is a simple number guessing game. This user inputs the range to guess between, and a random number generator
 * will create a number within that range to guess at. 'TryParse' loops are used to ensure the player input is actually a number.
 * This is very basic, obviously..
 */

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Console.WriteLine("Let's play a game. I'm going to think of a number, and you're going to guess what it is!");
            Console.WriteLine("Choose your difficulty. What should min be?: ");
            
            int min;
            while (!int.TryParse(Console.ReadLine(), out min))
            {
                Console.WriteLine("It will need to be a number...");
            }
            int max;
            Console.WriteLine("And max?: ");
            while (!int.TryParse(Console.ReadLine(), out max))
            {
                Console.WriteLine("It will need to be a number... Try again");
            }

            int targetNum = r.Next(min, max+1);
            bool correct = false;

            Console.WriteLine("I've got a number in mind...\nPick a number between {0}-{1} (inclusive): ", min, max);
            

            while(!correct)
            {
                int guess; 
                while (!int.TryParse(Console.ReadLine(), out guess))
                {
                    Console.WriteLine("Make it a number...");
                }
                if(guess < targetNum)
                {
                    Console.WriteLine("Too low... Try again: ");
                } else if( guess > targetNum)
                {
                    Console.WriteLine("Too high... Try again: ");
                } else
                {
                    correct = true;
                }
            }

            Console.WriteLine("\nNice! Very obedient!");
        }
    }
}
