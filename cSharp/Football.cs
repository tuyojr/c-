using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp
{
    internal class Football
    {

        public string team;
        public string topPlayer;
        public int topPlayerNum;
        public static int numberOfPlayers = 0;

        //constructor
        public Football (string aTeam, string aTopPlayer, int aTopPlayerNum)
        {
            team = aTeam;
            topPlayer = aTopPlayer;
            topPlayerNum = aTopPlayerNum;
            //everytime a Football object gets created, the clubsPlayedFor gets incremented
            //this information is going to be specific to the class itself
            numberOfPlayers++;
        }

        //if you want the objects to access the static attribute, you create a method they can use to access it.

        public int getNumberOfPlayers ()
        {
            return numberOfPlayers;
        }

    }
}
