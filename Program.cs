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
            int coins;
            int crystalsCount;           
            int crystalPrice = 10;
            Console.Write("How many coins you have? ");
            coins = Convert.ToInt32(Console.ReadLine());
            Console.Write("Price for 1 crystal = 10 coins. How many crystals do you want to buy? ");
            crystalsCount = Convert.ToInt32(Console.ReadLine());
            coins -= crystalPrice * crystalsCount;
            Console.WriteLine($"You have {crystalsCount} crystals and {coins} coins");
        }
    }
}
