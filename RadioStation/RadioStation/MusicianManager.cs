using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RadioStation
{
    class MusicianManager
    {
        List<Musician> musicianList = new List<Musician>();
        Dictionary<string, Musician> musicianDictionary = new Dictionary<string, Musician>();
        public MusicianManager()
        {
            StreamReader reader = null;
            try
            {
                reader = new StreamReader("musician.txt");
                string a = null;
                while ((a = reader.ReadLine()) != null)
                {
                    string[] splitA = a.Split('|');
                    for (int i = 0; i < splitA.Length; i += 2)
                    {
                        Musician myMusician = new Musician(splitA[i], splitA[i + 1]);
                        musicianList.Add(myMusician);
                        musicianDictionary.Add(splitA[i], myMusician);
                    }
                }
            }
            catch(Exception exc)
            {
                Console.WriteLine("An error happend!", exc.Message);
            }
            finally
            {
                if(reader!=null)
                {
                    reader.Close();
                }
            }
        }
        public void PrintOneMusician()
        {
            Console.WriteLine("Please enter a musician's name");
            string b = Console.ReadLine();
            int c = 0;
            while(c<musicianList.Count)
            {
                if(b==musicianList[c].Name)
                {
                    musicianList[c].Print();
                }
                c++;
            }
            if(musicianDictionary.ContainsKey(b))
            {
                musicianDictionary[b].Print();
            }
            else
            {
                Console.WriteLine("{0} is not in the database", b);
            }
        }
        public void PrintAllMusicians()
        {
            for(int d=0; d<musicianList.Count; d++)
            {
                Musician myMusic = new Musician(musicianList[d].Name, musicianList[d].Instrument);
                myMusic.Print();
            }
            foreach(KeyValuePair<string, Musician> a in musicianDictionary)
            {
                a.Value.Print();
            }
        }
    }
}
