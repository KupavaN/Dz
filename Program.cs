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
            int[] array = new int[30] { 1, 2, 3, 1, 0, 1, 7, 8, 5, 4, 4, 4, 5, 5, 5, 5, 5, 5, 9, 2, 1, 3, 5, 7, 8, 9, 1, 0, 0, 6 };
            int numberRepittingChecker = 1;
            int repeatNumber = 0;
            int maxRepittingOfNumber = 1;
            int numberRepittingCheckerBase = 1;



            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine();

            for (int i = 0; i < array.Length - 1; i++)
            {

                if (array[i] == array[i + 1])
                {
                    numberRepittingChecker++;

                    if (numberRepittingChecker > maxRepittingOfNumber)
                    {
                        maxRepittingOfNumber = numberRepittingChecker;
                        repeatNumber = array[i];
                    }

                }
                else
                {
                    numberRepittingChecker = numberRepittingCheckerBase;
                }

            }

            Console.WriteLine();
            Console.WriteLine($"Max repeat Number = {repeatNumber}. Max repeat Number count = {maxRepittingOfNumber} . ");

        }
    }
}
