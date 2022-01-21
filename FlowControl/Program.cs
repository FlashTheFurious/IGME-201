using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare the variables
            int var1, var2;

            //Ask user to give 2 numbers 
            Console.WriteLine("Give me 2 numbers to Display. Both cannot be greater than 10");

            //Label for the goto statement
            Input:


            //Take the first input from user
            Console.WriteLine("The first number is:");
            var1 = Convert.ToInt32(Console.ReadLine());

            //Take the second input from user
            Console.WriteLine("The second number is:");
            var2 = Convert.ToInt32(Console.ReadLine());

            //Check if the two numbers were greater than 10, or if they were both under 10
            //If they were, reject them and ask for new numbers
            if ((var1 > 10) ^ (var2 > 10))
            {
                //If they were both under 10 or equal to 10, display them to the user
                Console.WriteLine("The numbers you entered were {0} and {1}", var1, var2);
            }
            else
            {
                Console.WriteLine("Sorry. Either both numbers were greater than 10 or both were less than 10. Please try again");
                //Use goto to jump back tp the input label of code
                goto Input;
            }



        }
    }
}
