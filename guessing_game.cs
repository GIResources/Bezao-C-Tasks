using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playGame = true;
            int minNo = 1;
            int maxNo = 10;
            int guess;
            int randNumber;
            int noOfGuesses;
            string response;
            //int count;

            while (playGame)
            {
                guess = 0;
                noOfGuesses = 0;
                response = "";
                randNumber = random.Next(minNo, maxNo + 1);

                while (guess != randNumber)
                {
                    Console.WriteLine("Guess a number between " + minNo + " - " + maxNo + " : ");

                    Console.WriteLine(" "); 
                    
                    guess = Convert.ToInt32(Console.ReadLine());

                   
                   /* if (guess <> guess)
                    {
                      count = noOfGuesses++;
                    }
                    else
                    {
                       count = noOfGuesses - 1;
                    }
                    */

                    Console.WriteLine("Guess: " + guess);
                    Console.WriteLine("   ");
                    
                    if (guess > randNumber)
                    {
                        Console.WriteLine(guess + " is too Large.");
                    }
                    else if (guess < randNumber)
                    {
                        Console.WriteLine(guess + " is too Small");
                    }

                   

                }
                Console.WriteLine("Number: " + randNumber);
                Console.WriteLine("You Win!");
                Console.WriteLine("Guesses " + noOfGuesses);
                Console.WriteLine(" ");

                Console.WriteLine("Would you like to Replay the Game? (Y/N): ");
                response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "Y")
                {
                    playGame = true;
                }
                else
                {
                    playGame = false;
                }
            }

            Console.WriteLine("Thanks for playing the game!");
            Console.ReadKey();
        }
    }
}
