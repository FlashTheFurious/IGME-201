using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12_Q3
{
    public class MyClass
    {
        private string myString = "ExampleString";
        public string MyString
        {
            set
            {
                myString = value;
            }
        }
        public virtual string GetString()
        {
            return myString;
        }
    }

    public class MyDerivedClass : MyClass
    {
        public override string GetString()
        {
            string resultString = base.GetString();
            resultString += " (output from the derived class)";

            return resultString;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyDerivedClass newDerivedObject = new MyDerivedClass();
            Console.WriteLine(newDerivedObject.GetString());

        }
    }
}
