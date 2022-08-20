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
            int[] array = { 2,4,8,9 };
                                            
            MixArray(array);
        }

        static void MixArray(int[] array)
        {
            Random random = new Random();

            for (int j = 0; j < array.Length; j++)
            {
                Console.Write(array[j]);
            }

            for (int i = array.Length - 1; i >= 1; i--)
            {
                int randomIndex = random.Next(i + 1);
                int shuffleIndex = array[randomIndex];
                array[randomIndex] = array[i];
                array[i] = shuffleIndex;
            }

            Console.WriteLine();

            for (int j = 0; j < array.Length; j++)
            {
                Console.Write(array[j]);
            }

            Console.WriteLine();

        }
    }
}

