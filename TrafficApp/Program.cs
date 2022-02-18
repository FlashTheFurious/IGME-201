using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleLibrary;

namespace TrafficApp
{

    // Class: Program
    // Author: Tarnav Bhasin
    // Purpose: To construct a new method that accepts a new object that inherits from
    //          the IPassengerCarrier interface
    // Restrictions: None
    class Program
    {

        // Method: Main
        // Purpose: Declare a new instances of Compact() and _424DoubleBogey()
        //          Call AddPassenger while passing in the Compact() object
        // Restrictions: None
        static void Main(string[] args)
        {
            Compact newCar = new Compact();
            _424DoubleBogey newBogey = new _424DoubleBogey();

            AddPassenger(newCar);
            //AddPassenger(newBogey);
            //The code shoots an error because it recognizes that newBogey does not
            //inherit from the IPassenger interface
        }

        // Method: AddPassenger
        // Parameters: Accepts any object that inherits from the IPassengerCarrier interface
        // Purpose: Calls the LoadPassenger method on the Object.
        //          Prints the Object name to the console
        // Restrictions: None
        public static void AddPassenger(IPassengerCarrier objectName)
        {
            objectName.LoadPassenger();
            Console.WriteLine(objectName.ToString());
        }
    }
}
