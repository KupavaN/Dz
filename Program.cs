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
            int[] array1 = { 1, 2, 1, };
            int[] array2 = { 3, 2 };
            List<int> list = new List<int>();

            MergeArray(list, array1.Length, array1);
            MergeArray(list, array2.Length, array2);

            foreach (int number in list)
            {
                Console.WriteLine(number);
            }
        }

        static void MergeArray(List<int> list, int arrayLength, int[] array)
        {
            for (int i = 0; i < arrayLength; i++)
            {
                if (list.Contains(array[i]) == false)
                {
                    list.Add(array[i]);
                }
            }
        }
    }
}


