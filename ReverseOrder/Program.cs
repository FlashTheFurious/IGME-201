using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseOrder
{

    // This program takes a word from the user, and reverses it
    // DOG becomes GOD
    // It uses the method ReverseStringMethod(string stringInput) which takes in a string input and
    // returns a new string reversed

    class Program
    {
        // Stores user input into a variable
        // Calls the method ReverseStringMethod(userInput) - while passing our stored input
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word, and I'll reverse it ");
            string userInput = Console.ReadLine();
            //Calling our method with the userInput as its parameter.
            ReverseStringMethod(userInput);


        }

        // Array.Reverse method will reverse and print a string in the console.
        // Decalares a char Array, converts the user input into chars , stores new input into the charArray
        // Uses the Array.Reverse method and prints the string to the console
        private static void ReverseStringMethod(string stringInput)
        {

            //Declare a character array and convert the string we got from the method parameter
            char[] charArray = stringInput.ToCharArray();

            // Inbuilt Method Array.Reverse Method  
            Array.Reverse(charArray);

            Console.WriteLine(new string(charArray));
        }
    }
}
