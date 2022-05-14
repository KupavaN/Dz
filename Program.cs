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
            int mainMenuActive = 1; // 1 = true
            string userInput;

            while (mainMenuActive > 0)
            {
                Console.WriteLine("You are in the main menu");
                Console.WriteLine("Enter Exit to close programm");
                userInput = Console.ReadLine();
                if (userInput == "Exit")
                {
                    Console.WriteLine("Exit protocol activate :) ");
                    break;
                }
            }


        }
    }
}
