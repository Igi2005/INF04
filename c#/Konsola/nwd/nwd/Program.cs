using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nwd
{
    internal class INF04
    {

        public static int setData(int a, int b)
        {
            if(a < 0 || b < 0)
            {
                Console.WriteLine("1 z podanych liczb jest ujemna!");
                return 0;
            }
            else
            {
                Console.WriteLine("elo");
                while(a != b)
                {
                    if (a > b)
                    {
                        a = (a - b);
                    }
                    else
                    {
                        b = (b - a);
                    }
                    
                }
                return a;
            }
            
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---");
            Console.WriteLine(INF04.setData(7,5));

            Console.ReadKey();
        }
    }
}
