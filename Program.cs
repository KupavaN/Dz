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
            int[] array = new int[30];
            Random random = new Random();
            int randomMin = 0;
            int randomMax = 10;            
            int numberRepittingChecker = 1;
            int numberRepittingCheckerBase = 1;
            int maxRepeatNumber = 0;
            int maxRepittingOfNumber = 0;
            int firstCheckNumber = 1;


            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(randomMin, randomMax);
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine();

            for (int i = firstCheckNumber; i < array.Length; i++)
            {
                if (array[i] == array[i - 1])
                {
                    numberRepittingChecker++;
                }
                else if (maxRepittingOfNumber < numberRepittingChecker)
                {
                    maxRepittingOfNumber = numberRepittingChecker;
                    maxRepeatNumber = array[i - 1];
                    numberRepittingChecker = numberRepittingCheckerBase;
                }
                
            }

            Console.WriteLine();
            Console.WriteLine($"Max repeat Number = {maxRepeatNumber}. Max repeat Number count = {maxRepittingOfNumber} . ");

        }
    }
}
