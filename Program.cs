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
            Database dataBase = new Database();
            bool isWork = true;
            string userInput;
            Console.WriteLine("Press any button to start.");

            while (isWork)
            {
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("1-add new player \n2-delete player \n3-ban player \n4-unban player \n5-Show all player's \n6-Exit");
                userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        dataBase.AddPlayer();
                        break;
                    case "2":
                        dataBase.DeletePlayer();
                        break;
                    case "3":
                        dataBase.BanPlayer();
                        break;
                    case "4":
                        dataBase.UnBanPlayer();
                        break;
                    case "5":
                        dataBase.ShowData();
                        break;
                    case "6":
                        isWork = false;
                        Console.WriteLine("Have a nice day.");
                        break;
                }
            }
        }
    }

    class Player
    {        
        public string NickName { get; private set; }
        public int Level { get; private set; }
        public bool IsBanned { get; private set; }

        public Player(string nickName, int level, bool isBanned)
        {            
            NickName = nickName;
            Level = level;
            IsBanned = isBanned;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Player name -{NickName} \nPlayer level - {Level} ");

            if (IsBanned == true)
            {
                Console.WriteLine("Player is banned");
            }
        }

        public void Ban()
        {
            IsBanned = true;
        }

        public void UnBan()
        {
            IsBanned = false;
        }
    }

    class Database
    {
        private Dictionary<int, Player> _players = new Dictionary<int, Player>();
        
        private int _indexInBase;        

        public void AddPlayer()
        {
            Console.WriteLine("Enter player index:");
            _indexInBase =Convert.ToInt32(Console.ReadLine());            
            Console.WriteLine("Enter player nickname");
            string nickName = Console.ReadLine();
            Console.WriteLine("Enter player level:");
            bool isNumber = int.TryParse(Console.ReadLine(), out int level);

            if (isNumber == false)
            {
                Console.WriteLine("Incorrect input. Level must contain inly numbers. \nExample: 10"); 
                return;
            }

            Console.WriteLine("Is player banned? \nY-yes. \nN-no.");
            char input = Convert.ToChar(Console.ReadLine());
            bool isBanned;

            if (input == 'Y')
            {
                isBanned = true;
            }
            else if (input == 'N')
            {
                isBanned = false;
            }
            else
            {
                Console.WriteLine("Incorrect input. Try again.");
                return;
            }

            _players.Add(_indexInBase, new Player(nickName, level, isBanned));
                       
        }

        public void DeletePlayer()
        {
            Console.WriteLine("Enter user identifier");
            bool isNumber = int.TryParse(Console.ReadLine(), out int identifier);

            if (isNumber == true && _players.ContainsKey(identifier) == true)
            {                
                _players.Remove(identifier);
                Console.WriteLine("Player successfully delete.");
            }
            else
            {
                Console.WriteLine("Incorrect input or the player with this number is not in the database");
            }            
        }

        public void ShowData()
        {
            if (_players.Count != 0)
            {
                
                for (int i = 0; i < _players.Count; i++)
                {
                    _players[i].ShowInfo();
                    Console.WriteLine($"identifier:{i}");
                    Console.WriteLine();
                }               
            }
            else
            {
                Console.WriteLine("There is no players in database");
            }
        }

        public void BanPlayer()
        {
            Console.WriteLine("Enter user identifiern");
            bool isNumber = int.TryParse(Console.ReadLine(), out int identifier);

            if (isNumber == true & _players.ContainsKey(identifier) == true)
            {

                if (_players[identifier].IsBanned == false)
                {
                    _players[identifier].Ban();
                    Console.WriteLine("Player banned");
                }
                else
                {
                    Console.WriteLine("Player is already banned");
                }
            }
            else
            {
                Console.WriteLine("Incorrect input or the player with this number is not in the database");
            }
        }

        public void UnBanPlayer()
        {
            Console.WriteLine("Enter user identifiern");
            int input = int.Parse(Console.ReadLine());

            if (_players.ContainsKey(input) == true)
            {

                if (_players[input].IsBanned == true)
                {
                    _players[input].UnBan();
                    Console.WriteLine("Player unbanned.");
                }
                else
                {
                    Console.WriteLine("Player dont banned.");
                }
            }
            else
            {
                Console.WriteLine("Incorrect input or the player with this number is not in the database");
            }
        }
    }
}


