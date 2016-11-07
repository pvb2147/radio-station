using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Patrick Bell
//March 17 2016
//Class: BandManager
//Creates an array of Band objects to interact with
namespace RadioStation
{
    class BandManager
    {
        private Band[] myBands; //Array of Band objects
        public BandManager()
        {
            myBands = new Band[3]; //Creates all the Band objects
            myBands[0] = new RockBand("The Beatles", "rockband", "John Lennon", "George Harrison", "Paul McCartnney", "Ringo Starr"); //Populates the array with those Band objects
            myBands[1] = new SoloArtist("Adele", "sole artist", "voice");
            myBands[2] = new Band("Rochester Philharmonic Orchestra", "Orchestra");
        }
        public void PrintOneBand()
        {
            Console.WriteLine("Which band would you like to display details for?"); //Asks a user for a band name
            string oneband = Console.ReadLine();
            int a = 0;
            bool c = false;
            while(a<myBands.Length && !c)
            {
                if(oneband.ToUpper()==myBands[a].Name.ToUpper()) //If that band or artist exists within the array
                {
                    myBands[a].Print();
                    c = true;
                }
                a++;
            }
            if (c == false) //If that band does not exist
            {
                Console.WriteLine("The band {0} is not in the database.", oneband);
            }
        }
        public void PrintBandType()
        {
            Console.WriteLine("Which band would you like to find the genre of"); //Asks a user for a band name
            string bandtype = Console.ReadLine();
            int a=0;
            bool c = false;
            while(a<myBands.Length && !c)
            {
                if(bandtype.ToUpper()==myBands[a].Name.ToUpper()) //If that band exists within the array
                {
                    Console.WriteLine("{0} is a {1}", myBands[a].Name, myBands[a].Type);
                    c = true;
                }
                a++;
            }
            if (c == false) //If that band does not exist
            {
                Console.WriteLine("The band {0} is not in the database", bandtype);
            }
        }
        public void PrintAllBands()
        {
            for(int a=0; a<myBands.Length;a++)
            {
                if(myBands[a]!=null)
                {
                    myBands[a].Print(); //Displays information about every band by callin each Band object's Print() method.
                }
            }
        }
    }
}
