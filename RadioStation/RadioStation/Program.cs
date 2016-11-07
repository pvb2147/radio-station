using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Patrick Bell
//March 17 2016
//Radio Station Part 1 Homework
//Run the logic of the program
namespace RadioStation
{
    class Program
    {
        static void Main(string[] args)
        {
            SongManager mysongmanager = new SongManager(); //SongManager object that provides access to the array of Song objects
            BandManager mybandmanager = new BandManager(); //BandManager object that provides access to the array of Band objects
            int a = 0;
            while(a!=8) //Create a while loop that asks the user to choose between 8 options
            {
                Console.WriteLine("Enter 1 to find a song's composer.");
                Console.WriteLine("Enter 2 to find a song's recording band/artist.");
                Console.WriteLine("Enter 3 to print all details about a song.");
                Console.WriteLine("Enter 4 to print all of the songs in the database.");
                Console.WriteLine("Enter 5 to find a band's genre.");
                Console.WriteLine("Enter 6 to print all details about one band/recording artist.");
                Console.WriteLine("Enter 7 to print all of the bands/recording artists in the database.");
                Console.WriteLine("Enter 8 to quit.");
                string b = Console.ReadLine();
                a = int.Parse(b); //Performs a requested command by calling the appropriate method of SongManager or BandManager object
                if (a == 1)
                {
                    mysongmanager.PrintSongwriter();
                }
                if (a == 2)
                {
                    mysongmanager.PrintCoverBand();
                }
                if (a == 3)
                {
                    mysongmanager.PrintOneSong();
                }
                if (a == 4)
                {
                    mysongmanager.PrintAllSongs();
                }
                if (a == 5)
                {
                    mybandmanager.PrintBandType();
                }
                if (a == 6)
                {
                    mybandmanager.PrintOneBand();
                }
                if (a == 7)
                {
                    mybandmanager.PrintAllBands();
                }
            }
            if(a==8)
            {
                Console.WriteLine("Thank you for playing.");
            }
        }
    }
}
