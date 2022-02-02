using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseOrder
{
    class Program
    {
        //   public enum Colors: short { Red, Orange, Yellow, Green, Blue, Indigo, Violet, Black, White }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word, and I'll reverse it ");
            string userInput = Console.ReadLine();
            //Calling our method with the userInput as its parameter.
            ReverseStringWithInbuiltMethod(userInput);


        }

        // Array.Reverse method will reverse and print a string in the console.
        private static void ReverseStringWithInbuiltMethod(string stringInput)
        {

            //Declare a character array and convert the string we got from the method parameter
            char[] charArray = stringInput.ToCharArray();

            // Inbuilt Method Array.Reverse Method  
            Array.Reverse(charArray);

            Console.WriteLine(new string(charArray));
        }
    }
}
