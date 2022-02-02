﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaComputation
{
    class Program
    {
        static void Main(string[] args)
        {

            // Doubles to store all values of x,y, and z
            double x = 0;
            double y = 0;
            double z = 0;

            // Ints to access the array dimensions for x and y
            int nX = 0;
            int nY = 0;

            // Declaring our 3 dimensional rectangular array
            //      21 values of x
            //      31 values of y
            //      651 values of z
            //      3 values for each data point: the x, y and z
            double[,,] zFunc = new double[21, 31, 3];

            // loop through each value of x, increment the int nX after each loop
            for (x = -1; x <= 1; x += 0.1, ++nX)
            {
                // round x to 1 decimal point because of rounding issues with double
                x = Math.Round(x, 1);

                // start with the 0'th "y" bucket for this value of x
                nY = 0;

                // loop through each value of y, increment nY after each loop
                for (y = 1; y <= 4; y += 0.1, ++nY)
                {
                    // round y to 1 decimal point because of rounding issues with double
                    y = Math.Round(y, 1);

                    // calculate z
                    z = 3 * Math.Pow(y, 2) + 2 * x - 1;

                    // round z to 3 decimal places
                    z = Math.Round(z, 3);

                    // store x, y and z for this (x,y) data point
                    zFunc[nX, nY, 0] = x;
                    zFunc[nX, nY, 1] = y;
                    zFunc[nX, nY, 2] = z;

                    Console.WriteLine(x);
                    Console.WriteLine(y);
                    Console.WriteLine(z);

                }
            }



        }

    }
}

