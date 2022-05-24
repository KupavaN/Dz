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
           
           Random random = new Random();            
            int minimumPossibleNumber = 0;
            int maximumPossibleNumber = 101;
            int number = random.Next(minimumPossibleNumber, maximumPossibleNumber);
            int firstNumberMultiple = 3;
            int secondNumberMultiple = 5;            
            int zeroNumber = 0;
            int count = zeroNumber;
            int totalCount = count;

            for (count = zeroNumber; count <= number; count++)
            {
                if ((count % firstNumberMultiple == zeroNumber) ||(count % secondNumberMultiple == zeroNumber))
                {                   
                    totalCount += count;                   
                }               
            }
            Console.WriteLine($"The number is {number} and sum of multiples { totalCount}");
        }  
    }
}
