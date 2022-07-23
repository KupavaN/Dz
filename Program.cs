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
            int[] array = { 3, 5, 7, 4, 1, 0,9,2,4,8 };
            int arrayLength = array.Length;
            int numberCheck = 0;

            for(int i = 0; i < arrayLength; i++)
            {
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine();

            for(int i = arrayLength-1; i > 0; i--)
            {

                for (int j =0; j<i; j++)
                {

                    if (array[j] > array[j + 1])
                    {
                        numberCheck=array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = numberCheck;
                    }
                }
            }

            Console.WriteLine();

            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine();
        }
    }
}
