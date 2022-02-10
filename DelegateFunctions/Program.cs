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
            roundImposter = Math.Round;//same as below
            //roundImposter = new RoundImposter(Math.Round);//same as above

            int numOne = 3;
            double doubleOne = 3.0968;

            //Math.Round(doubeOne,numOne );
            double newNumber = roundImposter(doubleOne, numOne);
            Console.WriteLine(newNumber);
        }






    }
}
