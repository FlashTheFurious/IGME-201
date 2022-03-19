using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structConversion
{
    // -------------------------- QUESTION 14 UNIT TEST 2 ------------------------------
    /*struct Friend
    {
        public string name;
        public string greeting;
        public DateTime birthdate;
        public string address;
    }*/

    public class Friend
    {
        public string name;
        public string greeting;
        public DateTime birthdate;
        public string address;

        public object Shallowcopy()
        {
            return this.MemberwiseClone();
        }

    }

    class Program
    {

        static void Main(string[] args)
        {
            Friend friend = new Friend();


            // create my friend Charlie Sheen
            friend.name = "Charlie Sheen";
            friend.greeting = "Dear Charlie";
            friend.birthdate = DateTime.Parse("1967-12-25");
            friend.address = "123 Any Street, NY NY 12202";

            // now he has become my enemy
            Friend enemy = (Friend)friend.Shallowcopy();
            //enemy = friend;

            // set the enemy greeting and address without changing the friend variable
            enemy.greeting = "Sorry Charlie";
            enemy.address = "Return to sender.  Address unknown.";

            Console.WriteLine($"friend.greeting => enemy.greeting: {friend.greeting} => {enemy.greeting}");
            Console.WriteLine($"friend.address => enemy.address: {friend.address} => {enemy.address}");
        }
    }

}
