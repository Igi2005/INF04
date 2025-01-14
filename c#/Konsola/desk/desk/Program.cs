using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desk
{
    class INF04
    {
        public string[] szyfr = { "GA", "DE","RY","PO","LU","KI"};
        
        public string szyfrowanie_tekstu(string tekst_wejsciowy)
        {
            string _tekst_wejsciowy = tekst_wejsciowy.ToUpper();
            string zaszyfrowany_tekst = "";
            for (int i = 0; i < _tekst_wejsciowy.Length; i++)
            {
                char litera = tekst_wejsciowy[i];
                bool help = false;
                Console.WriteLine("litera -----------" + litera);
                foreach (string s in szyfr) 
                { 
                    foreach(char c in s)
                    {
                        if (litera == c)
                        {
                            help = true;
                            Console.WriteLine("\t [IF litera=c] " + "litera to " + litera + " c to " + c);
                            if(litera == s[0])
                            {
                                Console.WriteLine("\tlietra s[0]");
                                zaszyfrowany_tekst += s[1];
                                Console.WriteLine("zaszyfrowany tekst to " + zaszyfrowany_tekst);
                            }
                            else if(litera == s[1])
                            {
                                Console.WriteLine("\tlietra s[1]");
                                zaszyfrowany_tekst += s[0];
                                Console.WriteLine("zaszyfrowany tekst to " + zaszyfrowany_tekst);
                            }
                        }
                    }
                }
                if (help == false)
                {
                    Console.WriteLine("Help");
                    zaszyfrowany_tekst += litera;
                }
            }


            return zaszyfrowany_tekst;
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {

            INF04 obj1 = new INF04();
            Console.WriteLine("Zaszyfrowany tekst to ");
            Console.WriteLine(obj1.szyfrowanie_tekstu("PROGRAM"));

            Console.ReadKey();
        }
    }
}
