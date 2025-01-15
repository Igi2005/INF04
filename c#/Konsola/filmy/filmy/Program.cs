using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filmy
{
    /*
    *****************************************************
    nazwa klasy: Filmy
    pola: tytul - Przechowuje tytuł danego filmu, jest to pole chronione.
          liczbaWypozyczen - Przechowuje ilość wypożyczeń danego filmu, jest to pole chronione.
    metody: _tytul, Metoda ta zwraca pole chronione tytul. , Metoda ta służy do ustawienia tytułu filmu oraz zwróceniu jego wartości.
            zwiekszLiczbeWypozyczen, Metoda ta nic nie zwraca, Metoda _liczbaWypozyczen służy do zwiększenia liczby wypożyczeń konkretnego filmu o stałą wartość 1.
            _liczbaWypozyczen, Metoda ta zwraca liczbe wypozyczen konkretnego filmu. Metoda _liczbaWypozyczen służy do zwrócenia ilości wypożyczeń konkretnego filmu.
    informacje: Klasa Filmy reprezentuje część logiki systemu wirtualnej wypożyczalni filmów.
    autor: Igi2005
    *****************************************************
    */
    class Filmy
    {
        protected string tytul = "";
        protected int liczbaWypozyczen = 0;

        public string _tytul
        {
            get { return tytul; }
            set
            {
                if (value.Length > 20)
                {
                    Console.WriteLine("tytul musi byc mniejszy niz 20");
                }
                else if (value.Length < 20) { tytul = value; }
            }
                 
        }

        public int _liczbaWypozyczen
        {
            get { return liczbaWypozyczen; }
        }

        public void zwiekszLiczbeWypozyczen()
        {
            liczbaWypozyczen = liczbaWypozyczen + 1;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Filmy film1 = new Filmy();
            film1._tytul = "Lalala";
            Console.WriteLine(film1._tytul);
            Console.WriteLine(film1._liczbaWypozyczen);
            film1.zwiekszLiczbeWypozyczen();
            Console.WriteLine(film1._liczbaWypozyczen);

            Console.ReadKey();

        }
    }
}
