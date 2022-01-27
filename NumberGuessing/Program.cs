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
                //Label used to jump to if user enters a number outside of allowed range, 0-100
                InvalidGuess:

                // Declare local variable to store input
                int nUserGuess;
                string sUserGuess;
                bool bValid;

                do //'Do' the following code 'while' bValid is true
                   //'Do' also makes sure the code runs atleast once
                {
                    Console.WriteLine("Guess Number {0}", i + 1);

                    //Take input from the user
                    sUserGuess = Console.ReadLine();
                    bValid = int.TryParse(sUserGuess, out nUserGuess); //if TryParse succeeds then bValid is set to true

                    if (!bValid)
                    {
                        Console.WriteLine("You didn't even guess a number, try again");
                    }

                } while (bValid == false);

                //Check if user's guess is a valid number , i.e., 0-100
                if (nUserGuess < 0 || nUserGuess > 100)
                {
                    //If it is invalid, send user back to start of the loop without increasing 'i'
                    Console.WriteLine("You guessed an invalid number, try again");
                    goto InvalidGuess;
                }

                //Check if user's guess is too high or too low
                if (nUserGuess < randomNumber)
                {
                    Console.WriteLine("Too low, try higher");
                }
                else if (nUserGuess > randomNumber)
                {
                    Console.WriteLine("Too high, try lower");
                }
                else if (nUserGuess == randomNumber)
                {
                    //Making a fancy end screen
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Congratulations!!! You guessed correct!");

                    //Tell user how many tries it took them to guess it, and reward them 
                    Console.WriteLine("And it only took you {0} tries!", i + 1);

                    //Exit out of loop
                    break;



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
            Console.WriteLine("Thank You for Playing!!!");
        }
    }
}
