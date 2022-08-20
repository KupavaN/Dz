using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            bool isPlaying = true;
            bool isGameMenuActive = true;
            int pacmanX;
            int pacmanY;
            int pacmanDX = 0;
            int pacmanDY = 1;
            string mapName = "map1";

            while (isGameMenuActive)
            {
                Console.WriteLine("Choose mode: \n 1 - play on the created map. \n 2 - create your own map. \n 3 - close game. \n\n Attention!!! If you want to log out during the game press Esc!!!");
                string userInput = Console.ReadLine();
                Console.Clear();

                if (userInput == "1")
                {
                    mapName = "map1";
                    isGameMenuActive = false;
                }
                else if (userInput == "2")
                {
                    mapName = MapCreation(mapName);
                    isGameMenuActive = false;
                    Console.CursorVisible = false;

                }                               
                else if (userInput == "3")
                {
                    isGameMenuActive = false;
                    isPlaying = false;
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }
            }
            char[,] map = ReadMap(mapName, out pacmanX, out pacmanY);
            DrawMap(map);

            while (isPlaying)
            {
                Console.SetCursorPosition(pacmanY, pacmanX);
                Console.Write('@');

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    ChangeDirection(key, ref pacmanDX, ref pacmanDY, ref isPlaying);

                }

                if (map[pacmanX + pacmanDX, pacmanY + pacmanDY] != '#')
                {
                    Move(ref pacmanX, ref pacmanY, pacmanDX, pacmanDY);

                }
                System.Threading.Thread.Sleep(160);

            }
        }

        static void ChangeDirection(ConsoleKeyInfo key, ref int DX, ref int DY, ref bool isPlaying)
        {
            isPlaying = true;
            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    DX = -1; DY = 0;
                    break;
                case ConsoleKey.DownArrow:
                    DX = 1; DY = 0;
                    break;
                case ConsoleKey.LeftArrow:
                    DX = 0; DY = -1;
                    break;
                case ConsoleKey.RightArrow:
                    DX = 0; DY = 1;
                    break;
                case ConsoleKey.Escape:
                    isPlaying = false;
                    Console.Clear();
                    break;
            }

        }

        static void Move(ref int X, ref int Y, int DX, int DY)
        {
            Console.SetCursorPosition(Y, X);
            Console.WriteLine(" ");

            X += DX;
            Y += DY;

            Console.SetCursorPosition(Y, X);
            Console.Write('@');

        }

        static void DrawMap(char[,] map)
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write(map[i, j]);
                }
                Console.WriteLine();
            }
        }

        static char[,] ReadMap(string mapName, out int pacmanX, out int pacmanY)
        {
            pacmanX = 0;
            pacmanY = 0;
            string[] newFile = File.ReadAllLines($"maps/{mapName}.txt");
            char[,] map = new char[newFile.Length, newFile[0].Length];

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    map[i, j] = newFile[i][j];

                    if (map[i, j] == '@')
                    {
                        pacmanX = i;
                        pacmanY = j;
                    }
                }
            }
            return map;
        }

        static string MapCreation(string mapName)
        {
            Console.WriteLine("Enter name for your map:");
            mapName =Console.ReadLine();
            bool isCreating = true;
            Console.CursorVisible = true;
            Console.WriteLine("Now you are available to create your own map. \n Attention!!! The borders of the map must be equal");
            Console.WriteLine("Example:\n Correct:\n\n ##### \n #   # \n # # # \n #   # \n #  ## \n #####");
            Console.WriteLine("Incorrect:\n\n ##### \n #   ## \n # # ### \n #  ## \n #####");
            Console.WriteLine("Now you can create your map. \n Dont forget to create player sign like this @");
            StreamWriter sw = new StreamWriter($"maps/{mapName}.txt");
            Console.WriteLine("Enter 1 to create a new line on the map. \nEnter 2 to complete creation map.");

            while (isCreating)
            {            
                string input = Console.ReadLine();

                if (input == "1")
                {
                    string userInput = Console.ReadLine();
                    sw.WriteLine(userInput);                    
                }
                else if (input == "2")
                {
                    sw.Close();
                    isCreating = false;
                    Console.Clear();
                }                
            }            
            return mapName;            
        }
    }
}
