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
            int nY; //Bug 1, missing semicolon ;
            int nAnswer;

            Console.WriteLine("This program calculates x ^ y."); //Bug 2, missing apostrophes

            do
            {
                Console.Write("Enter a whole number for x: ");
                sNumber = Console.ReadLine(); // Bug 3, sNumber was not used to store the input
            } while (!int.TryParse(sNumber, out nX));

            do
            {
                Console.Write("Enter a positive whole number for y: ");
                sNumber = Console.ReadLine();
            } while (!int.TryParse(sNumber, out nY));
            //Bug 4, the while loop condition was missing an exclamation mark '!' to check for false 
            // Bug 5, nY was never used as the output variable. 

            // compute the exponent of the number using a recursive function
            nAnswer = Power(nX, nY);

            Console.WriteLine("{0}^{1} = {2}", nX, nY, nAnswer); //Bug 6, Console was not printing actual values of variables

        }


        static int Power(int nBase, int nExponent) // Bug 7, Keyword static was not being used
        {

            int returnVal = 0;
            // int nextVal = 0; // Not needed

            // the base case for exponents is 0 (x^0 = 1)
            if (nExponent == 0)
            {
                // return the base case and do not recurse
                returnVal = 1; // Bug 8, 0 changed to 1
            }
            else
            {


                // compute the subsequent values using nExponent-1 to eventually reach the base case

                // nextVal = Power(nBase, nExponent - 1); // Bug 9, Logical error 

                // multiply the base with all subsequent values
                //Bug 10, Fixed the calculation
                returnVal = (int)Math.Pow(Convert.ToDouble(nBase), Convert.ToDouble(nExponent));

            }

            return returnVal; //Bug 11, no return statement was used
        }
    }
}

