using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSConsoleAssignment
{
    class Game
    {
        //EXTRA
        //members:
        public int homeScore;
        public int visitScore;


        //Constructors:
        public Game(){}


        //methods:
        //getting random scores, returns 1 if home team wins, 2 if home team wins, or 3 if its a tie:
        public int playGame()
        {
            Random rnd = new Random();
            int homeScore = rnd.Next(10);
            int visitScore = rnd.Next(10);

            if (homeScore == visitScore) //tie
            {
                return 3;
            }
            else if (homeScore > visitScore) //home wins
            {
                return 1;
            }
            else //visit wins
            {
                return 2;
            }
        }
    }
}
