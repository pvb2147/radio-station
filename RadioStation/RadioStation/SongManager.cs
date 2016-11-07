using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//Patrick Bell
//March 17 2016
//Class: SongManager
//Creates an array of Song objects to interact with
namespace RadioStation
{
    class SongManager
    {
        List<Song> songList = new List<Song>();
        Dictionary<string, Song> songDictionary = new Dictionary<string, Song>();
        public SongManager()
        {
            StreamReader reader = null;
            try
            {
                reader = new StreamReader("song.txt");
                string a = null;
                while ((a = reader.ReadLine()) != null)
                {
                    string[] splitA = a.Split('|');
                    for (int i = 0; i < splitA.Length; i += 3)
                    {
                        Song mySong = new Song(splitA[i], splitA[i + 1], splitA[i + 2]);
                        songList.Add(mySong);
                        songDictionary.Add(splitA[i], mySong);
                    }
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine("An error happend!", exc.Message);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
        }
        public void PrintAllSongs() //Displays information about every song by calling each Song object's Print() method
        {
            foreach (KeyValuePair<string, Song> a in songDictionary)
            {
                a.Value.Print();
            }
        }
        public void PrintOneSong()
        {
            Console.WriteLine("Please enter a Song name");
            string b = Console.ReadLine();
            int c = 0;
            bool d = false;
            while (c < songList.Count && !d)
            {
                if (b == songList[c].Name)
                {
                    songList[c].Print();
                    d = true;
                }
                c++;
            }
            if(d==false)
            {
                Console.WriteLine("{0} is not in the database", b);
            }
        }
        public void PrintSongwriter()
        {
            Console.WriteLine("For which song would you like to find the writer?");
            string songWriter = Console.ReadLine();
            if (songDictionary.ContainsKey(songWriter))
            {
                songDictionary[songWriter].Print();
            }
            else
            {
                Console.WriteLine("{0} is not in the databoase");
            }
        }
        public void PrintCoverBand()
        {
            Console.WriteLine("For which song would you like to find the cover band or artist?");
            string coverBand = Console.ReadLine();
            int a = 0;
            bool d = false;
            while (a < songList.Count && !d)
            {
                if (coverBand == songList[a].Band)
                {
                    songList[a].Print();
                }
                a++;
            }
            if (d == false)
            {
                Console.WriteLine("This band is not in the database");
            }
        }
    }
}
