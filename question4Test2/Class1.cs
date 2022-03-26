using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question4Test2
{
    public abstract class Phone
    {
        private string phoneNumber;
        public string address;

        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }
            set
            {
                this.phoneNumber = value;
            }
        }

        public abstract void Connect();
        public abstract void Disconnect();

    }

    public class RotaryPhone : Phone, IPhoneInterface
    {
        public void Answer()
        {

        }
        public void MakeCall()
        {
            Console.WriteLine("CALL WAS MADE through interface by Tardis");
        }
        public void HangUp()
        {
            Console.WriteLine("SOMEONE HUNG UP through interface by Tardis");
        }
        public override void Connect()
        {

        }
        public override void Disconnect()
        {

        }
    }

    public class Tardis : RotaryPhone
    {
        private bool sonicScrewdriver;
        private byte whichDrWho;
        private string femaleSideKick;
        public double exteriorSurfaceArea;
        public double interiorVolume;


        public byte WhichDrWho
        {
            get
            {
                return this.whichDrWho;
            }
        }

        public static bool operator >(Tardis t1, Tardis t2)
        {
            if (t1.whichDrWho == 10)
            {
                return true;
            }
            else if (t2.whichDrWho == 10)
            {
                return false;
            }

            else if (t1.whichDrWho > t2.whichDrWho)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <(Tardis t1, Tardis t2)
        {
            if (t1.whichDrWho == 10)
            {
                return false;
            }
            else if (t2.whichDrWho == 10)
            {
                return true;
            }
            else if (t1.whichDrWho < t2.whichDrWho)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator >=(Tardis t1, Tardis t2)
        {
            if (t1.whichDrWho == 10 && t2.whichDrWho == 10)
            {
                return true;
            }

            else if (t1.whichDrWho == 10)
            {
                return true;
            }
            else if (t2.whichDrWho == 10)
            {
                return false;
            }

            else if (t1.whichDrWho >= t2.whichDrWho)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <=(Tardis t1, Tardis t2)
        {
            if (t1.whichDrWho == 10 && t2.whichDrWho == 10)
            {
                return true;
            }

            else if (t1.whichDrWho == 10)
            {
                return false;
            }
            else if (t2.whichDrWho == 10)
            {
                return true;
            }
            else if (t1.whichDrWho <= t2.whichDrWho)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Tardis t1, Tardis t2)
        {
            if (t1.whichDrWho == t2.whichDrWho)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Tardis t1, Tardis t2)
        {
            if (t1.whichDrWho != t2.whichDrWho)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string FemaleSideKick
        {
            get
            {
                return this.femaleSideKick;
            }
        }

        public void TimeTravel()
        {
            Console.WriteLine("TIME WAS TRAVELED through method by Tardis");
        }
    }

    public interface IPhoneInterface
    {

        void Answer();
        void MakeCall();

        void HangUp();

    }

    public class PushButtonPhone : Phone, IPhoneInterface
    {
        public void Answer()
        {

        }
        public void MakeCall()
        {
            Console.WriteLine("CALL WAS MADE through interface by PhoneBooth");
        }
        public void HangUp()
        {
            Console.WriteLine("SOMEONE HUNG UP through interface by PhoneBooth");

        }
        public override void Connect() { }
        public override void Disconnect()
        {

        }
    }

    public class PhoneBooth : PushButtonPhone
    {

        private bool superMan;
        public double costPercall;
        public bool phoneBook;
        public void OpenDoor()
        {
            Console.WriteLine("DOOR WAS OPENED through method by  PhoneBooth");
        }
        public void CloseDoor()
        {

        }
    }

    /*
     * 
        static void Main(string[] args)
        {
            Tardis timeMachine = new Tardis();

            PhoneBooth normalBooth = new PhoneBooth();


            UsePhone(timeMachine);
            UsePhone(normalBooth);

        }
        static void UsePhone(object obj)
        {
            IPhoneInterface iReference = (IPhoneInterface)obj;

            iReference.MakeCall();
            iReference.HangUp();

        }*/

}
