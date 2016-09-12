using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSConsoleAssignment
{
    class SoccerTeam : Team
    {
        //class attributes:
        public int draw;
        public int goalsFor;
        public int goalsAgainst;
        public int differential;
        public int points;

        public List<Game> games;


        //Constructors:
        
        //empty contructor
        public SoccerTeam() { }

        //receives name and points
        public SoccerTeam(string name, int points)
        {
            this.name = name;
            this.points = points;
        }

    }
}
