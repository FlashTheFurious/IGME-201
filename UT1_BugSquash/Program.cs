using System;

namespace UT1_BugSquash
{
    class Program
    {
        // Calculate x^y for y > 0 using a recursive function
        static void Main(string[] args)
        {
            string sNumber;
            int nX;
            int nY; //Bug 1 - Compile Time Error, missing semicolon ;
            int nAnswer;

            Console.WriteLine("This program calculates x ^ y."); //Bug 2 - Compile Time Error, missing apostrophes

            do
            {
                Console.Write("Enter a whole number for x: ");
                sNumber = Console.ReadLine(); // Bug 3 - Compile Time Error, sNumber was not used to store the input
            } while (!int.TryParse(sNumber, out nX));

            do
            {
                Console.Write("Enter a positive whole number for y: ");
                sNumber = Console.ReadLine();
            } while (!int.TryParse(sNumber, out nY));
            //Bug 4 - Logical and Runtime Error, the while loop condition was missing an exclamation mark '!' to check for false 
            // Bug 5 - Logical Error, nY was never used as the output variable. 

            // compute the exponent of the number using a recursive function
            nAnswer = Power(nX, nY);

            Console.WriteLine("{0}^{1} = {2}", nX, nY, nAnswer); //Bug 6 - Logical Error,  Console was not printing actual values of variables

        }


        static int Power(int nBase, int nExponent) // Bug 7 - Compile Time Error,  Keyword static was not being used
        {

            int returnVal = 0;
            int nextVal = 0;

            // the base case for exponents is 0 (x^0 = 1)
            if (nExponent == 0)
            {
                // return the base case and do not recurse
                returnVal = 1; // Bug 8 - Logical Error, 0 changed to 1
            }
            else
            {


                // compute the subsequent values using nExponent-1 to eventually reach the base case

                nextVal = Power(nBase, nExponent - 1); // Bug 9, Logical error 

                // multiply the base with all subsequent values

                returnVal = nBase * nextVal;


            }

            return returnVal; //Bug 10 - Compile Time Error, no return statement was used
        }
    }
}

