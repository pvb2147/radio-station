using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Patrick Bell
//March 17 2016
//Class: Band
//Parent class that describes on specific band in radio database
namespace RadioStation
{
    class Band //Parant of RockBand and SoloArtist children
    {
        protected string name; //name of the band
        protected string type; //type of band
        public string Name //Get for the name and type
        {
            get
            {
                return name;
            }
        }
        public string Type
        {
            get
            {
                return type;
            }
        }
        public Band(string p_name, string p_type) //Recieves the band name and band type
        {
            name = p_name; //Assigns fields with the parameter values
            type = p_type; //Child classes will also assign the value for the band type
        }
        public virtual void Print()
        {
            Console.WriteLine("{0} is a {1}", name, type);
        }
    }
}
