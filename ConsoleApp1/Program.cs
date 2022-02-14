using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Class: Program
    // Author: Tarnav Bhasin
    // Purpose: To increase dSalary by calling GiveRaise if the sName is equal to 'Tarnav'
    // Restrictions: None
    class Program
    {
        // Method: Main
        // Purpose: Declare new Employee, set sName and dSalary. Prompt user for the value of sName.
        // Call GiveRaise function, passing in the struct Employee as the parameter
        // If Salary increased, Congratulate user
        // Restrictions: None

        static void Main(string[] args)
        {
            Employee newWorker;
            Console.WriteLine("Please enter your name");
            //  Prompt for the user's name, then call the GiveRaise function:
            newWorker.sName = Console.ReadLine();
            newWorker.dSalary = 30000;

            //Calling the function
            //Used the ref keyword here to actually get a reference to the dSalary
            GiveRaise(ref newWorker);

            //Check if salary increased
            if (newWorker.dSalary > 40000)
            {
                // Congratulate user
                Console.WriteLine("Congratulations!!! You just Got a RAISE");
                Console.WriteLine("Your new salary is {0}", newWorker.dSalary);
            }
            else
            {
                Console.WriteLine("Sorry, You recieved no raise. You still earn " + newWorker.dSalary);
            }
            //Console.WriteLine(dSalary);



        }
        struct Employee
        {
            public string sName;
            public double dSalary;

        }

        // Method: GiveRaise
        // Purpose: Calculate new salary by passing in a reference for dSalary and sName. If
        // user enters 'Tarnav' then increase dSalary by 19999.99
        // Returns True if dSalary was increased
        // Restrictions: None
        static bool GiveRaise(ref Employee structName)
        {

            if (structName.sName.ToLower() == "tarnav")
            {
                structName.dSalary += 19999.99;
            }
            return true;
        }
    }
}