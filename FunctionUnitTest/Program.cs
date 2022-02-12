using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionUnitTest
{
    // Class: FunctionUnitTest
    // Author: Tarnav Bhasin
    // Purpose: To increase dSalary by calling GiveRaise if the sName is equal to 'Tarnav'
    // Restrictions: None
    class Program
    {
        // Method: Main
        // Purpose: Declare sName and dSalary. Prompt user for the value of sName.
        // Call GiveRaise function, passing in sName and dSalary
        // If Salary increased, Congratulate user
        // Restrictions: None

        static void Main(string[] args)
        {
            string sName;
            double dSalary = 30000;

            Console.WriteLine("Please enter your name");
            //  Prompt for the user's name, then call the GiveRaise function:
            sName = Console.ReadLine();

            //Calling the function
            GiveRaise(sName, ref dSalary);

            //Check if salary increased
            if (dSalary > 40000)
            {
                // Congratulate user
                Console.WriteLine("Congratulations!!! You just Got a RAISE");
                Console.WriteLine("Your new salary is {0}", dSalary);
            }
            else
            {
                Console.WriteLine("Sorry, You recieved no raise. You still earn " + dSalary);
            }
            //Console.WriteLine(dSalary);



        }

        // Method: GiveRaise
        // Purpose: Calculate new salary by passing in a reference for dSalary and sName. If
        // user enters 'Tarnav' then increase dSalary by 19999.99
        // Returns True if dSalary was increased
        // Restrictions: None
        static bool GiveRaise(string name, double salary)
        {

            if (name.ToLower() == "tarnav")
            {
                salary += 19999.99;
            }
            return true;
        }
    }
}
