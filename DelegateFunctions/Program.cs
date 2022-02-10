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
        /// 1. Define the delegate method data type based on the method signature
        delegate double RoundImposter(double targetNum, int decimalPlaces);

        // Method: Main
        // Purpose: We Declare a new instance of the delegate data type we created, Point it towards Math.Round, and call
        //          the Math.Round function through our delegate variable.
        // Restrictions: None
        static void Main(string[] args)
        {
            // 2. Declare the delegate method variable
            //RoundImposter roundImposter;

            // 3. Point the variable to the method that it should call

            // Option #1
            //roundImposter = Math.Round; 

            // Option #2 
            //roundImposter = new RoundImposter(Math.Round); 


            // Option #3 (lambda function)
            //roundImposter = (double targetNum, int decimalPlaces) => 
            // {
            //     double roundedVal = Math.Round(targetNum, decimalPlaces);
            //     return roundedVal;
            //
            //};


            // Option #4 Anonymous Code block
            /*
            roundImposter = delegate (double targetNum, int decimalPlaces) 
            {
                double roundedVal = Math.Round(targetNum, decimalPlaces);
                return roundedVal;

            };
            */

            // Option #5 Using Generic Templates
            Func<double, int, double> roundImposter = delegate (double targetNum, int decimalPlaces)
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
