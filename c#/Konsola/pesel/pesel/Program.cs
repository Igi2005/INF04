using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pesel
{
    class Pesel
    {
        public char gender;
        public char checkGender(string pesel)
        {
            string gender_str = pesel[9].ToString();
            int gender_int = int.Parse(gender_str);

            if (gender_int % 2 == 0)
            {
                gender = 'K';
            }
            else
            {
                gender = 'M';
            }

            return gender;
        }
        
        public bool isCorrect(string pesel)
        {
            int[] values = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
            int S = 0;

            for (int i = 0; i < 10; i++)
            {
                string cyfra = pesel[i].ToString();
                int cyfra_int = int.Parse(cyfra);
                S  = S + (values[i] * cyfra_int);
            }
            int M = S % 10;
            int R = 0;
            if (M == 0)
            {
                R = 0;
            }
            else
            {
                R = 10 - M;
            }
            Console.WriteLine("r to " + R);
            if (R == int.Parse(pesel[10].ToString()))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Pesel osoba = new Pesel();
            Console.WriteLine(osoba.checkGender("PESEL"));
            Console.WriteLine(osoba.isCorrect("PESEL"));
            


            Console.ReadKey();
        }
    }
}
