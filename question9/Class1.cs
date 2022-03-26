using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question9
{
    public interface IGames
    {
        void PlayGames();
    }
    public interface IMultiplayerGaming
    {
        void InviteFriend();
    }

    public abstract class GameEssentials
    {
        public bool controller;
        public bool internetAccessible;
        public bool gameInserted;

        public abstract void LogIn();
        public virtual void ChatWithFriends()
        {
        }

        public GameEssentials()
        {

        }
    }

    public class PS4 : GameEssentials, IMultiplayerGaming, IGames
    {
        public string consoleName;
        private string accountDetails;

        public string AccountDetails
        {
            get
            {
                return this.accountDetails;
            }
        }

        public void PlayGames()
        {

        }

        public override void LogIn()
        {

        }
        public override void ChatWithFriends()
        {

        }
        public void InviteFriend()
        {

        }

        public PS4()
        {

        }
    }

    public class PC : GameEssentials, IMultiplayerGaming, IGames
    {
        public string modelName;
        private string modelSpecs;

        public string GetSpecs
        {
            get
            {
                return this.modelSpecs;
            }
        }

        public void PlayGames()
        {

        }

        public override void LogIn()
        {

        }
        public override void ChatWithFriends()
        {

        }
        public void InviteFriend()
        {

        }

        public PC()
        {

        }
    }

    public class Class1
    {
    }
}
