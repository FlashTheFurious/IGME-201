using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessing
{
    //Author - Tarnav Aryan Bhasin
    //Class- IGME 201
    //Assignment- PE6 Parsing and Formatting

    class Program
    {
        //Restrictions on usage - User enters number between 0-100
        //Purpose of the class - To make a number guessing game
        static void Main(string[] args)
        {

            Random rand = new Random();

            // generate a random number between 0 inclusive and 101 exclusive
            int randomNumber = rand.Next(0, 101);

            //Prompt the user with Intro
            Console.WriteLine("I'm thinking of a number between 0-100... Can you guess it?");
            Console.WriteLine("You get 8 tries to guess it right and I'll let you know if you are guessing too high or too low");
            Console.WriteLine("If you guess right then I will show you a cute image ;)");
            Console.WriteLine("Let's Start the Game !!!");


            for (int i = 0; i < 8; i++)
            {
                //Label for the invalid guesses to jump to
                InvalidGuess:

                Console.WriteLine("Guess Number {0}", i + 1);

                // Declare local variable to store input
                int userGuess;

                //Take input from the user
                userGuess = Convert.ToInt32(Console.ReadLine());

                //Check if user's guess is a valid number , i.e., 0-100
                if (userGuess < 0 || userGuess > 100)
                {
                    Console.WriteLine("You guessed an invalid number, try again");
                    goto InvalidGuess;
                }

                //Check if user's guess is too high or too low
                if (userGuess < randomNumber)
                {
                    Console.WriteLine("Too low, try higher");
                }
                else if (userGuess > randomNumber)
                {
                    Console.WriteLine("Too high, try lower");
                }
                else if (userGuess == randomNumber)
                {
                    //Making a fancy end screen
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Congratulations!!! You guessed correct!");

                    //Tell user how many tries it took them to guess it, and reward them 
                    Console.WriteLine("And it only took you {0} tries!", i + 1);

                    //Exit out of loop
                    goto GameWon;



                }

                //Check if the game is over
                if (i == 7)
                {
                    //Making a fancy end screen
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine("Game Over! You ran out of tries");
                    Console.WriteLine("The number I was thinking of was {0}", randomNumber);
                }

            }

            //I use another label here to exit out of our loop as soon as we win the game
            GameWon:
            Console.WriteLine("Thank You for Playing!!!");

        }
    }
}
