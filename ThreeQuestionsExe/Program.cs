
using System;
// give access to the Timers namespace
using System.Timers;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeQuestionsExe
{
    // Class: Program
    // Author: Tarnav
    // Purpose: Class to contain 3 Questions Quiz app
    // Restrictions: None
    static class Program
    {
        //Global variables

        // TimeOut boolean variable
        static bool bTimeOut = false;

        // timeOutTimer Timer is the Timer variable
        static Timer timeOutTimer;

        static int nCntr = 0;

        // Method: Main
        // Purpose: A simple math quiz app with a timer
        //          if timer expires, then the anser is marked wrong
        // Restrictions: None
        static void Main()
        {



            // strings of questions and int of # of questions
            string sQuestion1 = "What is your favorite color?";
            string sQuestion2 = "What is the answer to life, the universe and everything?";
            string sQuestion3 = "What is the airspeed velocity of an unladen swallow?";
            int nQuestions = 3;

            //Answers to the Questions
            string sAnswer1 = "black";
            string sAnswer2 = "42";
            string sAnswer3 = "What do you mean? African or European swallow?";

            string sUserAnswer = ""; //Used to store the user's answer
            string sCorrectAnswer = ""; //Used to store the correct answer


            // Question picker            
            string sResponse = "";
            Int32 nResponse = 0; //This will store the users choice of question




            // boolean for checking valid input
            bool bValid = false;

            // play again?
            string sAgain = "";



            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(" Welcome to the 3 Questions Quiz!");
            Console.WriteLine();


            // label to return to if they want to play again
            start:

            // initialize timeout flag
            bTimeOut = false;



            Console.WriteLine();




            // ask each question
            for (nCntr = 0; nCntr < nQuestions; ++nCntr)
            {
                //Declare a new timer for each question
                // (Runs for 5 secods + 1 second "buffer")
                timeOutTimer = new Timer(5000 + 1000);
                bTimeOut = false;

                // Timer calls the Timer.Elapsed event handler when the time elapses
                // The Timer.Elapsed event handler uses a delegate function with the following signature:
                //        public delegate void ElapsedEventHandler(object sender, ElapsedEventArgs e);
                // This delegate method type is already defined for us by .NET

                // declare a variable of the delegate type
                ElapsedEventHandler elapsedEventHandler;

                // "point" the variable to our TimesUp method
                elapsedEventHandler = new ElapsedEventHandler(TimesUp);


                // ADD the TimesUp() delegate function to the timeOutTimer.Elapsed event handler
                // using the += operator
                timeOutTimer.Elapsed += (source, e) =>  //(abbrev lambda function)
                {

                    Console.WriteLine("Time's up!");

                    Console.WriteLine("The answer is: {0}", sCorrectAnswer);

                    Console.WriteLine("Please Press Enter");
                    // set the bTimeOut flag to quit the game
                    bTimeOut = true;

                    // stop the timeOutTimer
                    timeOutTimer.Stop();



                };


                // Prompt user for the question and parse it into an int using sResponse and nResponse to store their response
                do
                {
                    Console.Write("Choose your question (1-3): ");

                    sResponse = Console.ReadLine();

                    try
                    {
                        nResponse = int.Parse(sResponse);
                        if (nResponse == 1 || nResponse == 2 || nResponse == 3)
                        {
                            bValid = true;
                        }

                    }
                    catch
                    {
                        Console.WriteLine("Please enter an integer.");
                        bValid = false;
                    }
                } while (bValid == false);
                //} while (!bValid) ;








                // display the question and prompt for the answer using sResponse and nResponse to store their response
                do
                {
                    if (nResponse == 1)
                    {
                        Console.WriteLine("You have 5 seconds to answer the following question:");
                        Console.WriteLine(sQuestion1);
                        sCorrectAnswer = sAnswer1;

                    }
                    else if (nResponse == 2)
                    {
                        Console.WriteLine("You have 5 seconds to answer the following question:");
                        Console.WriteLine(sQuestion2);
                        sCorrectAnswer = sAnswer2;
                    }
                    else if (nResponse == 3)
                    {
                        Console.WriteLine("You have 5 seconds to answer the following question:");
                        Console.WriteLine(sQuestion3);
                        sCorrectAnswer = sAnswer3;
                    }

                    // start the timeOutTimer
                    timeOutTimer.Start();



                    sUserAnswer = Console.ReadLine();


                    // stop the timeOutTimer after the user has answered
                    timeOutTimer.Stop();

                    //Check if bTimeout if true. Use the break statement to exit the loop if bTimeout is true

                    if (bTimeOut)
                    {
                        break;
                    }

                } while (bValid == false);
                //} while (!bValid) ;


                // if sUserAnswer == sAnswer(1-3), output  reward 
                // else output stark answer
                if (sUserAnswer == sAnswer1 && bTimeOut == false && nResponse == 1)
                {

                    Console.WriteLine("Well done!");

                }
                else if (sUserAnswer == sAnswer2 && bTimeOut == false && nResponse == 2)
                {

                    Console.WriteLine("Well done!");

                }
                else if (sUserAnswer == sAnswer3 && bTimeOut == false && nResponse == 3)
                {

                    Console.WriteLine("Well done!");


                }
                else
                {
                    if (bTimeOut == true)
                    {
                        goto SkipPrompt;
                    }
                    Console.WriteLine("Wrong!. The answer is {0}", sCorrectAnswer);

                    SkipPrompt:;



                }

                // ask if they want to play again
                do
                {
                    // prompt if they want to play again
                    Console.Write("Play again? ");

                    sAgain = Console.ReadLine();

                    if (sAgain.ToLower().StartsWith("y"))
                    {
                        goto start;
                    }
                    else if (sAgain.ToLower().StartsWith("n"))
                    {
                        Environment.Exit(0);// Used to exit the App
                        break;
                    }
                } while (true);

                Console.WriteLine();


            }

            Console.WriteLine();




        }

        static void TimesUp(object source, ElapsedEventArgs e)
        {

            Console.WriteLine("NOT CALLEDDDDDDDD");

            Console.WriteLine();
            Console.WriteLine("Your time is up!");

            // set the bTimeOut flag to quit the game
            bTimeOut = true;

            // stop the timeOutTimer
            timeOutTimer.Stop();

            //nCntr++;

            Console.WriteLine("I'm sorry but you took too long");

        }
    }
}



