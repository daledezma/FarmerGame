using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmerGame_Ledezma
{
    class FarmerUI
    {
        Farmer farmer = new Farmer();

        public FarmerUI()
        {

        }

        public void DisplayGameState()
        {
            DisplayNorthBank();
            DisplayRiver();
            DisplaySouthBank();
        }

        public void DisplayNorthBank()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("VVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVV");
            Console.WriteLine("VVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVV");
            Console.WriteLine("VVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVV");
            Console.WriteLine("***********************North Bank***********************");
            Console.BackgroundColor = ConsoleColor.Black;
            for (int i = 0; i < farmer.NorthBank.Count; i++)
            {
                Console.Write(farmer.NorthBank[i]);
                Console.Write(" ");
            }

        }

        public void DisplayRiver()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.BackgroundColor = ConsoleColor.Black;
        }

        public void DisplaySouthBank()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("VVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVV");
            Console.WriteLine("VVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVV");
            Console.WriteLine("VVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVV");
            Console.WriteLine("***********************South Bank***********************");
            Console.BackgroundColor = ConsoleColor.Black;
            for (int i = 0; i < farmer.SouthBank.Count; i++)
            {
                Console.Write(farmer.SouthBank[i]);
                Console.Write(" ");
            }
        }
    }
}
