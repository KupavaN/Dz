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

            int minNumber = 1;
            int maxNumber = 100;
            int degreeNumber = 2;
            int numberThatWillDegree = 2;
            int degreeCount = 1;
            int degree = 1;
            Random random = new Random();
            int randomNumber = random.Next(minNumber, maxNumber);

            for (int i = degree; i >= degreeCount; i += degreeCount)
            {
                if (randomNumber >= degreeNumber)
                {
                    degreeNumber *= numberThatWillDegree;
                    degree += degreeCount;
                }
            }
            Console.WriteLine($"Degree = {degree}. Degree number = {degreeNumber}. Random number = {randomNumber}");
            Console.ReadLine();
        }
    }
}
