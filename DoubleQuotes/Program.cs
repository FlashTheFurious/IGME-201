using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleQuotes
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter a word and I will place double quotes around it");
            string userWord = Console.ReadLine();
            userWord = "\"" + userWord + "\"";
            Console.WriteLine(userWord);


            /*  This is the correct method for advanced arrays. 
               
                After the declaring the new array, insert the element you want to at the zero index of the new array
                Then loop through the original array to copy all its elements into the new array from index [1] onwards
                Finally, after you have copied all the elements from the original array, Insert the element you want to
                at the last index of the new array
            */

            // char[] newWord = new char[userWord.Length + 2];

            //char[] characters = userWord.ToCharArray();


            //Stack<string> myStack = new Stack<string>(characters);

            //newWord.Pop();

            // Console.WriteLine(userWord[6]);

            //  userWord = userWord.Concat(new[] { "\"" }).ToArray();
        }

    }
}
