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
            string exitProtocol = ("Exit");
            bool isMainMenuActive = true;

            while (isMainMenuActive == true)
            {
                Console.WriteLine("You are in the main menu");
                Console.WriteLine("Enter Exit to close programm");
                userInput = Console.ReadLine();
                if (userInput == exitProtocol)
                {
                    Console.WriteLine("Exit protocol activate :) ");
                    isMainMenuActive = false;
                }
            }
            Console.WriteLine($"You activate {exitProtocol} protocol. The game is over.");

        }
    }
}
