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
            Console.WriteLine("Give me 4 numbers to multiply. The first number is:");
            numOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The second number is:");
            numTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The third number is:");
            numThree = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The fourth number is:");
            numFour = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The product of {0}, {1}, {2}, and {3} is {4}.",
                          numOne, numTwo, numThree, numFour,
                          numOne * numTwo * numThree * numFour);
        }
    }
}
