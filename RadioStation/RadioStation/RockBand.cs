using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Patrick Bell
//March 17 2016
//Class: RockBand
//Child class that describes one rock band in the radio database
namespace RadioStation
{
    class RockBand : Band //Child class that describes one rock band in the radio database
    {
        private string lead; //Name of the lead vocalist
        private string bass; //Name of the musician on bass
        private string guitar; //Name of the musician on guitar
        private string drums; //Name of the musician on drums
        public RockBand(string p_name, string p_type, string p_lead, string p_bass, string p_guitar, string p_drums) : base(p_name, p_type) //names of all 4 musicians and any parameters necessary for the parent class
        {
            lead = "John Lennon"; //Assigns values to the 4 band members
            bass = "George Harrison";
            guitar = "Paul McCartnney";
            drums = "Ringo Starr";
            type = "rockband"; //Calls the base class constructor
        }
        public override void Print() //This method overrides the parent
        {
            base.Print();
            Console.WriteLine("{0} is the lead vocalist", lead); //writes each musician's name and their role to the console
            Console.WriteLine("{0} plays guitar", guitar);
            Console.WriteLine("{0} plays bass", bass);
            Console.WriteLine("{0} plays drums", drums);
        }
    }
}
