using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @string
{
    class INF04
    {
        public static int licz_samogloski(string text)
        {
            int liczba_samoglosek = 0;
            string pula_znakow = "aąeęiouóyAĄEĘIOUÓY";
            if(text == null)
            {
                return 0;
            }
            else if(text.Length == 0)
            {
                return 0;
            }
            else
            {
                for(int i = 0; i < text.Length; i++)
                {
                    if (pula_znakow.Contains(text[i]))
                    {
                        liczba_samoglosek += 1;
                    }
                }


                return liczba_samoglosek;
            }
           
        }

        public static string usun_powtorzenia(string text)
        {
            if(text == null)
            {
                return "";
            }
            else if (text.Length == 0)
            {
                return "";
            }
            else
            {
                /*string nowy_tekst = "";
                char last = text[0];
                int range = text.Length;
                for(int i = 0; i < text.Length; i++)
                {
                    if(i == 0)
                    {
                        nowy_tekst += text[0];
                        last = text[0];
                        continue;
                    }
                    if(i> 0 && i+1 < range)
                    {
                        if(text[i] != last)
                        {
                            nowy_tekst += text[i];
                            last  = text[i];
                        }
                    }
                    if(i+1 == range)
                    {
                        if (text[i] != last)
                        {
                            nowy_tekst += text[i];
                        }
                    }
                    
                }*/
                string nowy_tekst = "" + text[0];
                char last = text[0];

                foreach(char znak in text)
                {
                    if(znak != last)
                    {
                        nowy_tekst += znak;
                        last = znak;
                    }
                }

                return nowy_tekst;
            }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            string emptyText = "";
            Console.WriteLine("liczba samoglosek to " + INF04.licz_samogloski("BORYS"));
            Console.WriteLine(INF04.usun_powtorzenia("AADDDaaaammm!!"));

            Console.WriteLine("\nBez powtorzen " + INF04.usun_powtorzenia("AA;;damC'''''''z"));
            Console.ReadKey();

        }
    }
}
