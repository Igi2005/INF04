using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kostki
{
    class Game
    {
        public static int[] tablica;
        public static Random random = new Random();

        public static void generateNumbers(int ilosc)
        {
            tablica = new int[ilosc];
            for (int j = 0; j < ilosc; j++)
            {
                
                int liczba = random.Next(1, 7);
                tablica[j] = liczba;
                Console.WriteLine("Kostka " + (j+1) + " " + tablica[j]);
            }
        }

        public static int liczPunkty()
        {
            int suma = 0;
            for(int i = 0;i < tablica.Length;i++)
            {
                int wystapienia = 0;
                for(int j = 0; j < tablica.Length;j++)
                {
                    if (tablica[i] == tablica[j])
                    {
                        wystapienia++;
                    }
                }
                if(wystapienia > 1) suma = suma + tablica[i];
            }

            return suma;
        }

        public static void menu()
        {
            int ilosc = 0;
            
            while(ilosc > 10 || ilosc < 3)
            {
                Console.WriteLine("ile kostek chcesz rzucić?(3 - 10)");
                ilosc = int.Parse(Console.ReadLine());
            }
            generateNumbers(ilosc);
            Console.WriteLine("Liczba uzyskanych punktow to " + liczPunkty());
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Game.menu();

            Console.WriteLine("Jeszcze raz ? (t/n)");
            char choice = char.Parse(Console.ReadLine());

            if(choice == 't')
            {

                while (choice == 't')
                {
                    Game.menu();
                    Console.WriteLine("Jeszcze raz? (t/n)");
                    choice = char.Parse(Console.ReadLine());

                }
            }
            if (choice == 'n')
            {
                Console.WriteLine("koniec gry!");
            }



            Console.ReadKey();
        }
    }
}
