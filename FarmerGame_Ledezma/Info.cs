using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmerGame_Ledezma
{
    class Info
    {
        public void DisplayInfo(string assignment)
        {
            const string barrior = "************************************************************************";

            Console.WriteLine(barrior);
            Console.WriteLine();
            Console.WriteLine("Name:\t\tDaniel Ledezma");
            Console.WriteLine("Course:\t\tITDEV-115-200");
            Console.WriteLine("Instructor:\tJanese Christie");
            Console.WriteLine("Assignment:\t" + assignment);
            Console.WriteLine("Date:\t\t" + DateTime.Today.ToShortDateString());
            Console.WriteLine();
            Console.WriteLine(barrior);
        }
    }
}
