using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using question9;

namespace Question10
{
    class Program
    {
        static void Main(string[] args)
        {
            PC newPC = new PC();
            PS4 newPS4 = new PS4();

            MyMethod(newPC);
            MyMethod(newPS4);
        }

        // This method demonstrates Polymorphism
        // We use the same function to call different methods of the derived classes. 
        // We check if the obj is related to the PS4 or PC class
        static void MyMethod(object obj)
        {
            IMultiplayerGaming multiplayerGaming = (IMultiplayerGaming)obj;
            IGames gameReference = (IGames)obj;

            multiplayerGaming.InviteFriend();
            gameReference.PlayGames();

            if (obj is PS4)
            {
                PS4 psReference = (PS4)obj;
                psReference.LogIn();
            }
            else if (obj is PC)
            {
                PC pcReference = (PC)obj;
                pcReference.ChatWithFriends();
            }
        }
    }
}
