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
            int crystalCount;           
            int crystalPrice = 10;
            Console.Write("How many coins you have? ");
            coins = Convert.ToInt32(Console.ReadLine());
            Console.Write("Price for 1 crystal = 10 coins. How many crystals do you want to buy? ");
            crystalCount = Convert.ToInt32(Console.ReadLine());
            coins -= crystalPrice * crystalCount;
            Console.WriteLine($"You have {crystalCount} crystals and {coins} coins");
        }
    }
}
