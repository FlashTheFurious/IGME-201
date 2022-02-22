using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// NameSpace: VehicleLibrary
// Author: Tarnav Bhasin
// Purpose: To construct empty classes as described in the UML diagram
//          This demonstrates inheritance and how to inherit from interfaces
//          This Program produces a dll file, that can be used as a reference to access it from other projects
// Restrictions: None
namespace VehicleLibrary
{

    abstract public class Vehicle
    {
        public virtual void LoadPassenger()
        {

        }
    }

    abstract public class Train : Vehicle
    {

    }
    abstract public class Car : Vehicle
    {

    }
    public class SUV : Car, IPassengerCarrier
    {

    }
    public class Pickup : Car, IPassengerCarrier, IHeavyLoadCarrier
    {

    }
    public class Compact : Car, IPassengerCarrier
    {

    }
    public class FreightTrain : Train, IHeavyLoadCarrier
    {

    }
    public class _424DoubleBogey : Train, IHeavyLoadCarrier
    {

    }
    public class PassengerTrain : Train, IPassengerCarrier
    {

    }
    public interface IPassengerCarrier
    {
        void LoadPassenger();

    }
    public interface IHeavyLoadCarrier
    {


    }

}
