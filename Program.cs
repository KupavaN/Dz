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
            int[,] array = { { 1, 2, 3 }, { 7, 5, 4 }, { 6, 5, 8 } };
            int line = 2;
            int column = 1;
            int sum = 0;
            int multiply = array[0, 0];

            for (int i = 0; i < array.GetLength(0); i++)
            {

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} | ");
                }

                Console.WriteLine();
            }

            for (int j = 0; j < array.GetLength(1); j++)
            {
                sum = sum + array[line, j];
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                multiply = multiply * array[i, column];
            }

            Console.WriteLine($"sum = {sum}");
            Console.WriteLine($"mult = {multiply}");
        }
    }
}
