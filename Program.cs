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
            int[] array = new int [30];
            int arrayLength = array.Length;
            int arrayCheckLenth = arrayLength - 1;
            Random random = new Random();
            int localNumber = 0;
            int firsNumber = 0;
            int lastNumber = 0;
            int randomMin = 0;
            int randomMax = 10;
            int numberChecker = 1;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(randomMin, randomMax);                
                Console.Write($"{ array[i]} ");
            }

            Console.WriteLine();

            if (array[0] > array[1])
            {
                firsNumber = array[0];
                Console.Write($"{firsNumber} ");
            }

            for (int i = numberChecker; i < array.Length - numberChecker; i++)
            {
                if (array[i] > array[i - numberChecker] && array[i] > array[i + numberChecker])
                {
                    localNumber = array[i];
                }

                if (localNumber != 0)
                {
                    Console.Write($"{localNumber} ");
                }

                localNumber = 0;
            }            
            
            if (array[arrayCheckLenth] > array[arrayCheckLenth- numberChecker])
            {
                lastNumber = array[arrayCheckLenth];
                Console.Write($"{lastNumber} ");
            }

            Console.WriteLine();
        }
    }
}
