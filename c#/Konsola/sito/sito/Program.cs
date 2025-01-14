using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sito
{
    internal class INF04
    {
        static List<bool> listaA= new List<bool>();

        public static void setData()
        {
            for (int i = 0; i < 101; i++)
            {
                listaA.Add(true);
            }
        }

        public static string getRes()
        {
            string res = "";

            for (int i = 2; i < 10; i++)
            {
                if (listaA[i] == true)
                {
                    //Console.WriteLine("listaA [" + i + "] to " + listaA[i]);
                    for (int j = i * 2; j < 100;j+=i)
                    {
                        //Console.WriteLine("j to " + j);
                        listaA[j] = false;
                       
                    }
                }
            }

            for(int i = 2;i < 100;i++)
            {
                if (listaA[i] == true)
                {
                    res = res + "|" + i + " " + listaA[i] + "|\n";
                }

            }

            return res;
        } 


    }
    internal class Program
    {
        static void Main(string[] args)
        {

            INF04.setData();
            Console.WriteLine(INF04.getRes());

            Console.ReadKey();
        }
    }
}
