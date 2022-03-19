using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestStructures
{
    //Note: Some of the comment specifics, like the formula below are not updated. The new code logic for this exam has new comments though
    //This program calculates the equation for z ---- 4 * Math.Pow(y, 3) + 2 * Math.Pow(x, 2) - 8*x +7
    //For all values of x and y in the ranges of 
    //•	-1 <= x <= 1 in 0.1 increments
    //•	1 <= y <= 4 in 0.1 increments
    // it stores all these values in the 3d array zFunc[,,]

    // Class: Program
    // Author: Tarnav Bhasin
    // Purpose: To use calculate an equation with a range of values, using for loops and structs
    // Restrictions: None
    class Program
    {
        // We use doubles  to store values of x,y,w and z because we are expecting decimal values
        // We also frequently use Math.Round because of the known rounding issue with doubles
        // We use ints nX, nW and nY to access the array dimensions for x,y and w
        // We loop through the 4d array  using nested for loops, and calculate the values for z


        // Method: Main
        // Purpose: Declare a delegate method to impersonate Math.Round. Make a 3D array
        // Populate the array with the correct range of values Display values to the user
        // 
        // Restrictions: None
        static void Main(string[] args)
        {
            // Delegate function to impersonate Math.Round
            Func<double, int, double> roundImposter = delegate (double targetNum, int decimalPlaces)
            {
                double roundedVal = Math.Round(targetNum, decimalPlaces);
                return roundedVal;
            };

            // Doubles to store all values of w,x,y, and z
            double w = 0;
            double x = 0;
            double y = 0;
            double z = 0;

            // Ints to access the array dimensions for x, w and y
            int nW = 0;
            int nX = 0;
            int nY = 0;


            // Make sorted list with the Tuple representing the index
            SortedList<Tuple<double, double, double>, double> tupleValueList = new SortedList<Tuple<double, double, double>, double>();


            // loop through each value of x, increment the int nX after each loop
            for (x = 0; x <= 4; x += 0.1, ++nX)
            {
                // round x to 1 decimal point because of rounding issues with double
                x = roundImposter(x, 1);

                // start with the 0'th "y" and "w" bucket for this value of x
                nY = 0;
                nW = 0;

                // loop through each value of y, increment nY after each loop
                for (y = -1; y <= 1; y += 0.1, ++nY)
                {
                    // round y to 1 decimal point because of rounding issues with double
                    y = roundImposter(y, 1);

                    nW = 0;

                    for (w = -2; w <= 0; w += 0.2, ++nW)
                    {
                        w = roundImposter(w, 1);
                        // calculate z
                        z = 4 * Math.Pow(y, 3) + 2 * Math.Pow(x, 2) - 8 * w + 7;

                        // round z to 3 decimal places
                        z = roundImposter(z, 3);


                        // Making the index Tuple
                        Tuple<double, double, double> indexHolder = new Tuple<double, double, double>(nX, nY, nW);

                        //Adding the Tuple index and corresponding z value to the SortedList
                        tupleValueList.Add(indexHolder, z);

                        // Console.WriteLine(tupleValueList);
                    }
                }
            }

            /*
            foreach (KeyValuePair<Tuple<double, double, double>, double> kvp in tupleValueList)
            {
                Console.WriteLine(kvp.Key.Item1);
                Console.WriteLine(kvp.Key.Item2);
                Console.WriteLine(kvp.Key.Item3);
                Console.WriteLine(kvp.Value);
            }
            */
        }

    }
}

