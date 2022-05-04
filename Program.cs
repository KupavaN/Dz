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
            // ДЗ-3
            string name;
            int age;
            string zodiacSign;
            string workPlace;
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Console.Write("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your zodiac sign: ");
            zodiacSign = Console.ReadLine();
            Console.Write("Where do you work? ");
            workPlace = Console.ReadLine();
            Console.WriteLine($"Your name is {name} and you are {age} age old. Your zodiac sign is {zodiacSign}" +
                $" and you work on {workPlace} ");
        }
    }
}
