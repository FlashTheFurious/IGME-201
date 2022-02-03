using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YesNoReplace
{
    // This program takes in a string from the user
    // splits the words by the space character and adds it to a new 'words' array
    // loops through all the words, Checking if any of them are 'yes' or 'no'
    // Replaces Yes and No with each other, and returns/shows the new string to the user

    class Program
    {

        // Uses 3 string variables
        // userSentence holds the user input
        // words[] stores the words into an array after splitting them by the space character
        // convertedString is the one we concatenate/build our end result string to
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a sentence and I will replace 'yes' and 'no' with each other");

            //Store user input into a string
            string userSentence = Console.ReadLine();

            //Make an array by splitting the words from the user input by the space character.
            string[] words = userSentence.Split(' ');

            string convertedString = " ";

            // For each loops through all the words in the user provided sentence
            // 2 if blocks check if the current word is 'yes' or 'no'
            // - if true, then a Label is used to skip the last line of the loop
            // After converting everything to Lower case,
            // we use replace and concatenate the returned value to the convertedString
            foreach (string s in words)
            {
                if (s.ToLower() == "no")
                {
                    convertedString += " " + s.ToLower().Replace("no", "yes");
                    goto WordReplaced;
                }

                if (s.ToLower() == "yes")
                {
                    convertedString += " " + s.ToLower().Replace("yes", "no");
                    goto WordReplaced;
                }
                convertedString += " " + s;
                WordReplaced:;

            }

            Console.WriteLine(convertedString);


        }
    }
}
