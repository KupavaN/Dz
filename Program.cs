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

            renderer.DrawPlayer(player.XPosition, player.YPosition);
        }
    }

    class Renderer
    {

        public void DrawPlayer(int xPosition, int yPosition, char positionSymbol = ' ')
        {
            Console.WriteLine("Enter symbol that will mark your place");
            char userSymbol = Convert.ToChar(Console.Read());
            Console.SetCursorPosition (xPosition, yPosition);            
            positionSymbol = userSymbol;
            Console.Write(positionSymbol);
        }
    }

    class Player
    {

        public int XPosition { get; private set; }

        public int YPosition { get; private set; }

        public Player(int xPosition, int yPosition)
        {
            XPosition = xPosition;
            YPosition = yPosition;
        }
    }
}


