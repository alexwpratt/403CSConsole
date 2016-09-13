/*
 * Alex Pratt
 * Section 2 - Group 12
 * 
 * 
 * Olympic Soccer Tournament
 * 
 * Draw a class diagram that represents a Soccer Tournament. You will need a Team parent class, a child soccer class, and a game class. Write a program that prompts the user to enter in the number of teams competing in an olympic soccer tournament. Then for the number of teams entered, prompt the user to enter the name of the team and the number of points the team has scored. Finally, display the results of the tournament. Make sure your console output matches the sample screenshot in the requirements below exactly.
 * 
 * Requirements:

 Console output matches sample output completely (see screenshot below)
 First letter of each teams's name is capitalized
 Program uses a List object to store the list of teams
 Teams are sorted by the team's points in descending order
 Result table has column headers and separators for Position, Name, and Points
 Result table displays each team's position, name, and points
 Properly implements Team and SoccerTeam classes but you do NOT need to implement the Game class
 Use exception handling to make sure that the number of teams they enter is a valid integer (try/catch within a while loop).
 Adds comments to make code easier to understand
 Upload the project here and also upload the zipped project to the Learning Suite assignment (include the class diagram in your upload in the main root directory for your project so TAs can easily find it) and then schedule a time with the TAs for them to grade this assignment
 * 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSConsoleAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //local variables:
            int iNumGames = 0, iPoints = 0, iPosition = 1;
            string sName = "";
            bool bRepeat = true;
            List<SoccerTeam> olSoccerTeams = new List<SoccerTeam>();
            

            //get the number of games:
            Console.WriteLine("Welcome to the Olympic Soccer Tournament!");
            
            //prevent bad input:
            bRepeat = true;
            while (bRepeat)
            {
                bRepeat = false;
                try
                {
                    Console.WriteLine();
                    Console.Write("Please enter the number of teams that will be playing: ");
                    iNumGames = Convert.ToInt32(Console.ReadLine());
                }
                catch// (InvalidCastException eCast)
                {
                    Console.WriteLine();
                    Console.WriteLine("Please enter a valid integer, with no spaces or decimal points.");
                    bRepeat = true;
                }
            }
            Console.WriteLine();
            Console.WriteLine();


            //fill the olSoccerTeams array with data from user:
            for (int i = 0; i < iNumGames; i++)
            {
                //prevent bad input - valid team name
                bRepeat = true;
                while (bRepeat)
                {
                    Console.Write("Please enter Team " + (i + 1) + "'s name: ");
                    sName = Console.ReadLine();
                    Console.WriteLine();
                    if (string.IsNullOrWhiteSpace(sName)) // empty or blank string
                    {
                        Console.WriteLine("Please enter a valid team name.");
                        Console.WriteLine();
                        bRepeat = true;
                    }
                    else
                    {
                        bRepeat = false;
                    }
                }
                

                sName = UppercaseFirst(sName);

                //prevent bad input - valid integer
                bRepeat = true;
                while (bRepeat)
                {
                    bRepeat = false;
                    try
                    {
                        Console.WriteLine();
                        Console.Write("Please enter " + sName + "'s points: ");
                        iPoints = Convert.ToInt32(Console.ReadLine());
                    }
                    catch// (InvalidCastException eCast)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Please enter a valid integer, with no spaces or decimal points.");
                        bRepeat = true;
                    }
                }

                
                Console.WriteLine();
                Console.WriteLine();

                SoccerTeam oSoccerTeam = new SoccerTeam(sName, iPoints);
                olSoccerTeams.Add(oSoccerTeam);
            }



            //display the results, sorted ???
            Console.WriteLine("Here is the sorted list:");
            List<SoccerTeam> sortedTeams = olSoccerTeams.OrderByDescending(SoccerTeam => SoccerTeam.points).ToList(); // sort the list by points

            Console.WriteLine(Convert.ToString("Position").PadRight(20, ' ') + Convert.ToString("Name").PadRight(25, ' ') + Convert.ToString("Points").PadRight(25, ' '));
            Console.WriteLine(Convert.ToString("--------").PadRight(20, ' ') + Convert.ToString("----").PadRight(25, ' ') + Convert.ToString("------").PadRight(25, ' '));
            
            foreach(SoccerTeam sc in sortedTeams)
            {
                Console.Write(Convert.ToString(iPosition).PadRight(20, ' '));
                Console.Write(Convert.ToString(sc.name).PadRight(25, ' '));
                Console.Write(Convert.ToString(sc.points).PadRight(25, ' '));
                Console.WriteLine();

                iPosition++;
            }

            Console.Read();

        }


        //method to set the first character of the string as an uppercase character:
        static string UppercaseFirst(string s)
        {
            // Check for empty string.
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            // Return char and concat substring.
            return char.ToUpper(s[0]) + s.Substring(1);
        }
    }
}
