using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notatki
{
    /*
    ************************************************
    klasa: Notatki
    opis: Klasa służaca do zapisywania danych danej notatki dodanej przez użytkownika.
    pola: liczbaNotatek, przechowuje liczbę wszystkich notatek, typ liczbowy całkowity
          id, przechowuje id konkretnej notatki, typ liczbowy całkowity
          tytul, przechowuje tytuł konkretnej notatki, typ tekstowy
          tresc, przechowujetresc konkretnej notatki, typ tekstowy
    autor: Igi2005
    ************************************************
    */
    class Notatki
    {
        private static int liczbaNotatek = 0;
        private int id = 0;
        protected string tytul;
        protected string tresc;

        public Notatki(string _tytul, string _tresc)
        {
            liczbaNotatek++;
            id = liczbaNotatek;
            tytul = _tytul;
            tresc = _tresc;
        }

        public void wyswietlDaneNotatki()
        {
            Console.WriteLine("Tytuł notatki to: " + tytul + " treść notatki to " + tresc);
        }

        public void metodaDiagnostyczna()
        {
            Console.WriteLine("{ LiczbaNotatek : " + liczbaNotatek + "; ID : " + id + "; Tytuł : " + tytul + "; Treść : " + tresc + "; }");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Notatki notatka1 = new Notatki("Funkcja kwadratowa","y = a(x-x1)(x-x2)");
            notatka1.wyswietlDaneNotatki();
            notatka1 .metodaDiagnostyczna();
            Notatki notatka2 = new Notatki("Funkcja liniowa", "y = ax + b");
            notatka2.wyswietlDaneNotatki();
            notatka2.metodaDiagnostyczna();

            Console.ReadKey();

        }
    }
}
