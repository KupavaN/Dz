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
            string userInput;
            int iterationCount;

            Console.Write("Enter your messege ");
            userInput = Console.ReadLine();
            Console.Write("How many times to repeat the message ");
            iterationCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0;i < iterationCount;i++)
            {
                Console.WriteLine(userInput);                
            }
        }
    }
}
