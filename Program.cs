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
            {                
                Console.WriteLine("Enter your text:");
                string line = Console.ReadLine();
                string[] lineArray = line.Split(' ');

                foreach (string word in lineArray)
                {
                    Console.WriteLine(word);
                }

                Console.ReadLine();
            }
        }
    }
}
