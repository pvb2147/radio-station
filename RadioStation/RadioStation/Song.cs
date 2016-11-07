using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Patrick Bell
//March 17 2016
//Class: Song
//Describes one specific song in the radio database
namespace RadioStation
{
    class Song
    {
        private string name; //Name of the song
        private string composer; //Composer
        private string band; //Name of band who covers this song
        public string Name //Get for each field
        {
            get
            {
                return name;
            }
        }
        public string Composer
        {
            get
            {
                return composer;
            }
        }
        public string Band
        {
            get
            {
                return band;
            }
        }
        public Song(string p_name, string p_composer, string p_band) //Receives the parameters
        {
            name = p_name; //Assigns the values
            composer = p_composer;
            band = p_band;
        }
        public void Print() // Writes the songs name, composer, and band name to the console
        {
            Console.WriteLine("{0} is covered by {1} and written by {2}", name, band, composer);
        }
    }
}
