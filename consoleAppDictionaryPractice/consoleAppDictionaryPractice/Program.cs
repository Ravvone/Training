using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleAppDictionaryPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Football fb1 = new Football();
            fb1.TeamID = 012345;
            fb1.Teamname = "browns";
            fb1.Division = "North";
            fb1.Conference = "AFC";
            fb1.NetWorth = 1000000;

            Football fb2 = new Football();
            fb2.TeamID = 052145;
            fb2.Teamname = "Colts";
            fb2.Division = "South";
            fb2.Conference = "AFC";
            fb2.NetWorth = 2000000;

            Dictionary<int, Football> ballClub = new Dictionary<int, Football>();
            ballClub.Add(fb1.TeamID, fb1);
            ballClub.Add(fb2.TeamID, fb2);

            foreach (KeyValuePair<int, Football> item in ballClub)
            {
                Football fb = item.Value;
                fb.PrintClub();

            }




        }
    }
}
