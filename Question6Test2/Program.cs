using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using question4Test2;

namespace Question6Test2
{
    class Program
    {

        static void Main(string[] args)
        {
            //Make an object of Tardis and PhoneBooth
            Tardis timeMachine = new Tardis();

            PhoneBooth normalBooth = new PhoneBooth();

            //Pass the objects to UsePhone
            UsePhone(timeMachine);
            UsePhone(normalBooth);

        }
        static void UsePhone(object obj)
        {
            //Casting the object as an interface to access interface methods
            IPhoneInterface iReference = (IPhoneInterface)obj;

            iReference.MakeCall();
            iReference.HangUp();

            //Check what an object is related to, then call correct method

            if (obj is Tardis)
            {
                Tardis tardisR = (Tardis)obj;
                tardisR.TimeTravel();
            }
            else if (obj is PhoneBooth)
            {
                PhoneBooth phoneBoothR = (PhoneBooth)obj;
                phoneBoothR.OpenDoor();
            }
        }

    }
}
