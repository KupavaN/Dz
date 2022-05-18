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
            int firstNumber = 5;
            int loopScore = 7;
            int finalScore = 96;


            for (int score = firstNumber; score <= finalScore; score += loopScore)
            {
                Console.WriteLine(score); 
            }                        
        } 
    }
}
