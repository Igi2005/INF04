using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace notatki
{
    internal class INF04
    {
        private static int liczba_notatek = 0;
        private int id = 0;
        public string tytul;
        public string tresc;

        public INF04(string _tytul,string _tresc)
        {
            id = liczba_notatek + 1;
            tytul = _tytul;
            tresc = _tresc;
            liczba_notatek += 1;
        }

        public void getData()
        {
            Console.WriteLine("Tytuł notatki [" + tytul + "], Treść notatki [" + tresc + "]");
        }

        public void getDiagnosis()
        {
            Console.WriteLine("Liczba notatek - " + liczba_notatek + "\nID - " + id + "\nTytuł - " + tytul + "\nTreść - " + tresc);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            INF04 notatka1 = new INF04("Zadanie funkcja kwadratowa","Delta to super sprawa i trzeba ja znac");
            INF04 notatka2 = new INF04("Zadanie funkcja liniowa","--------- <- y=ax+b");

            notatka1.getData();
            Console.WriteLine("----------------------------------------------------------------------------------");
            notatka1.getDiagnosis();
            Console.WriteLine("----------------------------------------------------------------------------------");
            notatka2.getData();
            Console.WriteLine("----------------------------------------------------------------------------------");
            notatka2.getDiagnosis();

            Console.ReadKey();


        }
    }
}
