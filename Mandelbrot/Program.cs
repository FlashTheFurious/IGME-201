using System;

namespace Mandelbrot
{
    /// <summary>
    /// This class generates Mandelbrot sets in the console window!
    /// </summary>


    class Class1
    {
        //Author - Prof. David Schuh
        //Purpose - Demonstrating the Mandelbrot set

        /// <summary>
        /// This is the Main() method for Class1 -
        /// this is where we call the Mandelbrot generator!
        /// </summary>
        /// <param name="args">
        /// The args parameter is used to read in
        /// arguments passed from the console window
        /// </param>

        [STAThread]
        static void Main(string[] args)
        {
            double realCoord, imagCoord;
            double realTemp, imagTemp, realTemp2, arg;
            int iterations;

            //Declare new variables to store the user provided  values
            double realCoordStart;
            double imagCoordStart;
            double realCoordEnd;
            double imagCoordEnd;

            //Variables for iteration
            double rCoordNum;
            double iCoordNum;


            //Label for the goto statement to return to, in case user enters invalid values
            ImageCoordInput:

            //Prompt user for start value of imagCoord
            Console.WriteLine("Please enter new start and end values for imagCoord");
            Console.WriteLine("The starting value must be HIGHER than the ending value");
            Console.WriteLine("The default value is 1.2, Your Starting value of imagCoord is");

            //Store value in imagCoordStart
            imagCoordStart = Convert.ToDouble(Console.ReadLine());

            //Prompt user for end value of imagCoord
            Console.WriteLine("Please enter an end value for imagCoord");
            Console.WriteLine("This value must be LOWER than the previous entered value");
            Console.WriteLine("The default value is -1.2, Your Ending value of imagCoord is");

            //Store value in imagCoordEnd
            imagCoordEnd = Convert.ToDouble(Console.ReadLine());

            //Check if the values are invalid, if they are return to the input code
            if (imagCoordStart < imagCoordEnd)
            {
                goto ImageCoordInput;
            }

            //Calculate the increment for the imagCoord loop such that it runs 48 times/gives 48 values
            iCoordNum = -(imagCoordEnd - imagCoordStart) / 48;
            //Console.WriteLine(iCoordNum);

            //---------------------------End of imagCoord -------------------------------------------------------


            //---------------------------Start of realCoord -------------------------------------------------------
            //Label for the goto statement to return to, in case user enters invalid values
            RealCoordInput:

            //Prompt user for start value of realCoord
            Console.WriteLine("Please enter new start and end values for realCoord");
            Console.WriteLine("The starting value must be LOWER than the ending value");
            Console.WriteLine("The default value is -0.6, Your Starting value of realCoord is");

            //Store value in realCoordStart
            realCoordStart = Convert.ToDouble(Console.ReadLine());

            //Prompt user for end value of realCoord
            Console.WriteLine("Please enter an end value for realCoord");
            Console.WriteLine("This value must be HIGHER than the previous entered value");
            Console.WriteLine("The default value is 1.77, Your Ending value of realCoord is");

            //Store value in realCoordEnd
            realCoordEnd = Convert.ToDouble(Console.ReadLine());

            //Check if the values are valid, i.e, if starting value is lower than the end value
            if (realCoordStart > realCoordEnd)
            {
                goto RealCoordInput;
            }

            //Calculate the increment for the realCoord loop such that it runs 80 times/gives 80 values
            rCoordNum = (-realCoordStart + realCoordEnd) / 79; //I have changed 80 to 79 because it seemed like the correct way to implement this
            //Console.WriteLine(rCoordNum);

            for (imagCoord = imagCoordStart; imagCoord >= imagCoordEnd; imagCoord -= iCoordNum)// old values- 1.2, -1.2, 0.05
            {
                for (realCoord = realCoordStart; realCoord <= realCoordEnd; realCoord += rCoordNum)//old values- -0.6, 1.77, 0.03
                {
                    iterations = 0;
                    realTemp = realCoord;
                    imagTemp = imagCoord;
                    arg = (realCoord * realCoord) + (imagCoord * imagCoord);
                    while ((arg < 4) && (iterations < 40))
                    {
                        realTemp2 = (realTemp * realTemp) - (imagTemp * imagTemp)
                           - realCoord;
                        imagTemp = (2 * realTemp * imagTemp) - imagCoord;
                        realTemp = realTemp2;
                        arg = (realTemp * realTemp) + (imagTemp * imagTemp);
                        iterations += 1;
                    }
                    switch (iterations % 4)
                    {
                        case 0:
                            Console.Write(".");
                            break;
                        case 1:
                            Console.Write("o");
                            break;
                        case 2:
                            Console.Write("O");
                            break;
                        case 3:
                            Console.Write("@");
                            break;
                    }
                }
                Console.Write("\n");
            }

        }
    }
}
