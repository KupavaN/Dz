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
            int minNaturalNumber = 100;
            int maxNaturalNumber = 999;
            int minNumber = 1;
            int maxNumber = 27;
            int counterMultipleNumbers = 0;

            Random random = new Random();
            int randomNumber = random.Next(minNumber, maxNumber);

            for (int currentNumber = 0; currentNumber < maxNaturalNumber; currentNumber += randomNumber)
            {

                if (currentNumber >= minNaturalNumber)
                {
                    counterMultipleNumbers++;
                }
            }

            Console.WriteLine($"Количество трехзначных натуральных чисел, кратных {randomNumber},=:{counterMultipleNumbers}");
            Console.ReadLine();
        }       
    }
}
