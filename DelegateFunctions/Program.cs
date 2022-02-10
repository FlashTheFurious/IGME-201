using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateFunctions
{
    // Class: Program
    // Author: Tarnav Bhasin
    // Purpose: To demonstrate delegate methods by Impersonating the Math.Round() function
    // Restrictions: None
    class Program
    {
        delegate double RoundImposter(double targetNum, int decimalPlaces);

        // Method: Main
        // Purpose: We Declare a new instance of the delegate data type we created, Point it towards Math.Round, and call
        //          the Math.Round function through our delegate variable.
        // Restrictions: None
        static void Main(string[] args)
        {
            RoundImposter roundImposter;
            //roundImposter = Math.Round; //same as below - Option #1
            //roundImposter = new RoundImposter(Math.Round); //same as above Option #2
            roundImposter = (double targetNum, int decimalPlaces) =>          // option #3 (lambda function)
            {
                double roundedVal = Math.Round(targetNum, decimalPlaces);
                return roundedVal;

            };

            int numOne = 3;
            double doubleOne = 3.0968;

            //Math.Round(doubeOne,numOne );
            double newNumber = roundImposter(doubleOne, numOne);
            Console.WriteLine(newNumber);
        }






    }
}
