using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pliczki
{
    class Pliki
    {
        public string artist;
        public string album;
        public int songsNumber;
        public string yearOfEdition;
        public int downloadNumber;

        public static List<Pliki> listOfObj = new List<Pliki>();
        public static List<string> properties = new List<string>();

        public static void getData()
        {
            StreamReader file = new StreamReader("Data.txt");
            string line = file.ReadLine();

            while(line != null)
            {
                if(line != "")
                {
                    properties.Add(line);
                }
                line = file.ReadLine();
                 
            }

            Console.WriteLine("Properties.Count to " + properties.Count);
        }

        public static void setData()
        {
            for(int i = 0; i < properties.Count; i+=5)
            {
                Pliki obj = new Pliki();
                obj.artist = properties[i];
                obj.album = properties[i+1];
                obj.songsNumber = int.Parse(properties[i+2]);
                obj.yearOfEdition = properties[i+3];
                obj.downloadNumber = int.Parse(properties[i+4]);
                listOfObj.Add(obj);
            }
        }

        public static void showData()
        {
            bool help = true;
            foreach(Pliki obj in listOfObj)
            {
                if(help)
                {
                    Console.WriteLine("\t");
                    Console.WriteLine("-------------------");
                    Console.WriteLine("\t" + obj.artist);
                    Console.WriteLine("\t" + obj.album);
                    Console.WriteLine("\t" + obj.songsNumber);
                    Console.WriteLine("\t" + obj.yearOfEdition);
                    Console.WriteLine("\t" + obj.downloadNumber);
                    help = false;
                    continue;
                }
                if(!help)
                {
                    Console.WriteLine("-------------------");
                    Console.WriteLine(obj.artist);
                    Console.WriteLine(obj.album);
                    Console.WriteLine(obj.songsNumber);
                    Console.WriteLine(obj.yearOfEdition);
                    Console.WriteLine(obj.downloadNumber);
                    help = true;
                    continue;
                }

            }
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Pliki.getData();
            Pliki.setData();
            Pliki.showData();
            Console.ReadKey();
        }
    }
}
