using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Adding System.IO to use file I/O functions

/*
Need to remove the curly braces from the user input prompt about the adjectives etc. Also gotta remove the underscore from there
Need to properly remove all run-time errors
*/
namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numLibs = 0;//The total number of stories we parse is stored in here later
            int counter = 0;//Counter for the while loop
            int nChoice = 0;//Choice of story that user selected is stored here
            string sChoice;
            string sResult = " "; //Result string with replaced words 
            string startGame; //Stores user input on whether they want to play or not
            bool bValid;

            StreamReader input;

            //open the template file, count how many Mad libs it has
            input = new StreamReader("c:/templates/MadLibsTemplate.txt");

            //count the number of lines in the file. In our file we have a different mad libs on each line
            string line = null;

            while ((line = input.ReadLine()) != null)
            {
                ++numLibs;
            }

            //Close the file
            input.Close();

            //Making as many strings as there are Mad Lib stories
            string[] madLibs = new string[numLibs];

            //Parse the stories into the array of strings
            input = new StreamReader("C:\\templates\\MadLibsTemplate.txt");

            line = null;

            while ((line = input.ReadLine()) != null)
            {
                //set this array element to the current line of the template file
                madLibs[counter] = line;

                //replace the "\\n" with the newline escape character
                madLibs[counter] = madLibs[counter].Replace("\\n", "\n");

                ++counter;
            }

            //Now we have loaded our array of stories, We can close the input file
            input.Close();

            //prompt the user for which Mad Lib they want to play (between 1 to numLibs)
            //store the user selection in nChoice
            Console.WriteLine("WELCOME TO THE MAD LIBS GAME!!!");

            //Ask user if they wish to play
            Console.WriteLine("Do you want to play a game of Mad Libs? Type 'yes' or 'no'");

            //Label for invalid input
            InvalidStartGame:

            startGame = Console.ReadLine();
            if (startGame == "yes" || startGame == "Yes" || startGame == "YES")
            {
                goto GameStarted;
            }
            else if (startGame == "no" || startGame == "No" || startGame == "NO")
            {
                Console.WriteLine("Goodbye... Press any key to end application");
                goto GameEnded; //This skips the entire program and goes to the end
            }
            else
            {
                Console.WriteLine("Invalid input, Please type 'yes' or 'no'");
                goto InvalidStartGame;
            }

            GameStarted:


            do //'Do' the following code 'while' bValid is false
               //'Do' also makes sure the code runs atleast once
               //The loop will be broken once bValid is set to true
            {
                //Label for Invalid Story input
                InvalidStory:

                Console.WriteLine("Please select a number between 1 and " + numLibs + " in order to choose a story");

                //Take input from the user
                sChoice = Console.ReadLine();

                bValid = int.TryParse(sChoice, out nChoice); //if TryParse succeeds then bValid is set to true

                if (!bValid)
                {
                    Console.WriteLine("You didn't even type a number or you typed a decimal... try again");
                }
                else if (nChoice < 1 || nChoice > 6)
                {
                    goto InvalidStory;
                }

            } while (bValid == false);







            //split the Mad Libs into separate words. Separate each word from the 'words' array by the space character
            string[] words = madLibs[nChoice - 1].Split(' ');

            //I changed it to a for loop since I am more familiar with the syntax.
            for (int i = 0; i < words.Length; i++)
            {

                if (words[i] == "/n")
                {
                    sResult += "/n";
                }

                // Checks if the word is starting with curly brackets - which would mean its a prompt
                if (words[i].StartsWith("{"))
                {
                    words[i] = words[i].Replace('_', ' ');
                    words[i] = words[i].Replace('{', ' ');
                    words[i] = words[i].Replace('}', ' ');

                    // prompt the user for the replacement
                    Console.WriteLine("Please enter a " + words[i]);
                    words[i] = Console.ReadLine();
                    // and append the user response to the result string
                    sResult += " " + words[i];

                }
                else
                {
                    // append word to the result string
                    sResult += " " + words[i];
                }



            }


            //This prints all the words and makes sure they aren't mashed together
            Console.Write(sResult);

            //Label to quit application before game starts
            GameEnded:;

        }
    }
}
