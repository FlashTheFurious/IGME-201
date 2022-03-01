using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14Classy
{
    // Interface: INewInterface
    // Author: Tarnav Bhasin
    // Purpose: To define the method WriteString()
    // Restrictions: None
    public interface INewInterface
    {
        void WriteString();
    }

    // Class: Class1
    // Author: Tarnav Bhasin
    // Purpose: To implement the Interface method with a unique string output
    // Restrictions: None
    public class Class1 : INewInterface
    {
        public void WriteString()
        {
            Console.WriteLine("Class 1 is getting called");
        }
    }
    // Class: Class2
    // Author: Tarnav Bhasin
    // Purpose: To implement the Interface method with a unique string output
    // Restrictions: None
    public class Class2 : INewInterface
    {
        public void WriteString()
        {
            Console.WriteLine("Class 2 is getting called");

        }
    }

    // Class: Program
    // Author: Tarnav Bhasin
    // Purpose: To use an interface's common method through objects of two different classes
    // Restrictions: None
    class Program
    {
        // Method: Main
        // Purpose: Declare 2 variables, one for each Class. 
        //          Call MyMethod twice while passing in the variables for each class
        // 
        // Restrictions: None
        static void Main(string[] args)
        {
            Class1 newClass1 = new Class1();

            Class2 newClass2 = new Class2();

            MyMethod(newClass1);
            MyMethod(newClass2);

        }
        // Method: MyMethod 
        // Parameters : Accepts an object that inherits from INewInterface
        // Purpose: Declare a reference to INewInterface
        //          Assign the passed object (myObject) to the reference of the interface
        //          Call the interface method WriteString() 
        // Restrictions: None
        public static void MyMethod(object myObject)
        {
            INewInterface iNewI;
            iNewI = (INewInterface)myObject;
            iNewI.WriteString();
        }
    }
}
