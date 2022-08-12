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
            int healf = 5;
            int maxHealf = 10;
            int mana = 2;
            int maxMana = 10;
            int stamina = 7;
            int maxStamina = 10;

            DrawBar(healf, maxHealf, ConsoleColor.Red, 0, '#', '_');
            DrawBar(mana, maxMana, ConsoleColor.Blue, 1, '#', '_');
            DrawBar(stamina, maxStamina, ConsoleColor.Green, 2, '#', '_');

        }

        static void DrawBar(int value, int maxValue, ConsoleColor color, int position, char symbol, char symbolFull)
        {
            ConsoleColor defaultColor = Console.BackgroundColor;
            string bar = "";

            for (int i = 0; i < value; i++)
            {
                bar += symbol;
            }

            Console.SetCursorPosition(0, position);
            Console.Write("[");
            Console.BackgroundColor = color;
            Console.Write(bar);
            Console.BackgroundColor = defaultColor;
            bar = "";

            for (int i = value; i < maxValue; i++)
            {
                bar += symbolFull;
            }

            Console.Write(bar + "]");


        }
    }
}
