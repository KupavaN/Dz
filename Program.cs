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
            Renderer renderer = new Renderer();
            Player player = new Player(10, 3);

            renderer.DrawPlayer(player.X, player.Y);
        }
    }

    class Renderer
    {

        public void DrawPlayer(int x, int y, char ch = '&')
        {
            Console.SetCursorPosition (x, y);
            Console.Write(ch);
        }
    }

    class Player
    {

        public int X { get; private set; }

        public int Y { get; private set; }

        public Player(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}


