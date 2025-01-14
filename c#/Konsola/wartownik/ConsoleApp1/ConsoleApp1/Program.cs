using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Sorting
    {
        public static int[] arrayOfnumber = new int[10];


        public static void setData()
        {
            for (int i = 0; i < 10; i++)
            {
                int t = i + 1;
                Console.WriteLine("Set [" + i + "] value: ");
                int inputValue = int.Parse(Console.ReadLine());
                arrayOfnumber[i] = inputValue;
            }

            Console.WriteLine("Array before sorting:");
            Console.Write("{");
            foreach(int number in arrayOfnumber)
            {
                Console.Write(" " + number);
            }
            Console.WriteLine(" }");
        }

        public static void showData()
        {
            Console.WriteLine("Array after sorting");
            Console.Write("{ ");
            foreach (int number in arrayOfnumber)
            {
                Console.Write(number + " ");
            }
            Console.Write(" }");
        }

        private static int findMax(int start)
        {
            int max = arrayOfnumber[start];
            int index = start;
            for(int i = start; i < arrayOfnumber.Length; i++)
            {
                if (arrayOfnumber[i] > max)
                {
                    max = arrayOfnumber[i];
                    index = i;
                }
            }

            return index;
        }

        public static void sortArray()
        {
            for(int i = 0; i < arrayOfnumber.Length; i++)
            {
                int maxIndex = findMax(i);
                int maxValue = arrayOfnumber[maxIndex];
                int temp = arrayOfnumber[i];

                arrayOfnumber[i] = maxValue;
                arrayOfnumber[maxIndex] = temp;
                
            }
        }



    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Sorting.setData();
            Sorting.sortArray();
            Sorting.showData();


            Console.ReadKey();
        }
    }
}
