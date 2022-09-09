using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 4, 3, 2 ,1};
            int[] array2 = new int[] { 2, 3, 5};
            int[] array3 = new int[] { };
            List<int> list = new List<int>();

            if (array.Length > array2.Length)
            {
                array3 = array;
                Converter(array2, array, array3);
            }
            else
            {
                array3 = array2;
                Converter(array, array2, array3);
            }

            for (int i = 0; i < array3.Length; i++)
            {
                list.Add(array3[i]);
            }

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }

        static void Converter(int[] array, int[] array2, int[] array3)
        {
            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] > array3[j])
                {
                    array3[j] = array[j];
                }
            }
        }
    }
}


