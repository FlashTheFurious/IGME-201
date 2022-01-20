using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne, numTwo, numThree, numFour;
            Console.WriteLine("Give me a number:");
            numOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give me another number:");
            numTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give me another number:");
            numThree = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give me another number:");
            numFour = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The product of {0}, {1}, {2}, and {3} is {4}.",
                          numOne, numTwo, numThree, numFour,
                          numOne * numTwo * numThree * numFour);
        }
    }
}
