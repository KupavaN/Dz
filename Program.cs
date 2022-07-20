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
            int[,] array = new int[10, 10];
            Random random = new Random();
            int maxElement = int.MinValue;
            int matrixZero = 0;
            int minRandomNumber = 1;
            int maxRandomNumber = 10;

            for (int i = 0; i < array.GetLength(0); i++)
            {

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(minRandomNumber, maxRandomNumber);
                    Console.Write($"{array[i, j]} | ");
                   
                    if (maxElement < array[i, j])
                    {
                        maxElement = array[i, j];
                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine("\n***************************\n***************************\n***************************\n");

            for (int i = 0; i < array.GetLength(0); i++)
            {

                for (int j = 0; j < array.GetLength(1); j++)
                {

                    if (array[i, j] == maxElement)
                    {
                        array[i, j] = matrixZero;
                    }

                    Console.Write($"{array[i, j]} | ");
                }

                Console.WriteLine();
            }

            Console.WriteLine(maxElement);
        }
    }
}
