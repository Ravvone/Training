using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleAppDictionaryPractice
{
    class Football
    {
        public int TeamID { get; set; }
        public string Teamname { get; set; }
        public string Division { get; set; }
        public string Conference { get; set; }
        public int NetWorth { get; set; }

        public void PrintClub()
        {
            Console.WriteLine($"The {Teamname} with the {TeamID} in the {Conference} belong to the {Division} is worth ${NetWorth}.");
            Console.ReadLine();

        }

    }
}
