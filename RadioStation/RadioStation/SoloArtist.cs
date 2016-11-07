using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Patrick Bell
//March 17 2016
//Class: SoloArtist
//Child class that describes one solo artist in the radio database
namespace RadioStation
{
    class SoloArtist : Band //Child classs that describes one solo artist in the radio database
    {
        private string instrument; //Instrument solo artist plays
        public SoloArtist(string p_name, string p_type, string p_instrument): base(p_name,p_type) //instrument solo artist plays and any parameters necessary for the parent class
        {
            instrument ="voice"; //Assigns values to the instrument field
            type = "solo artist"; //Calls the base class constructor
        }
        public override void Print() //Writes the name of the artist and the instrument this artist plays
        {
            base.Print(); //This methods overrides the parent Print method
            Console.WriteLine("{0} is a singer", name);
        }
    }
}
