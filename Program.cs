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
            const string AddPlayer = "1";
            const string DeletePlayer = "2";
            const string Ban = "3";
            const string UnBan = "4";
            const string ShowPlayers = "5";
            const string Exit = "6";
            Database database = new Database();
            bool isWork = true;
            string userInput;
            Console.WriteLine("Press any button to start.");

            while (isWork)
            {
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine($"{AddPlayer}-Add new player.\n{DeletePlayer}-Delete player \n{Ban}-Ban player \n{UnBan}-Unban player \n{ShowPlayers}-Show all player's \n{Exit}-Exit");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case AddPlayer:
                        database.AddPlayer();
                        break;
                    case DeletePlayer:
                        database.DeletePlayer();
                        break;
                    case Ban:
                        database.BanPlayer();
                        break;
                    case UnBan:
                        database.UnBanPlayer();
                        break;
                    case ShowPlayers:
                        database.ShowData();
                        break;
                    case Exit:
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
        private string _lasyNaming = "Player";
        private int _lasyNamingCount = 1;

        public void AddPlayer()
        {
            Console.WriteLine("Enter player nickname");
            string nickName = Console.ReadLine();

            if (nickName == "")
            {
                nickName = _lasyNaming + _lasyNamingCount;
                _lasyNamingCount++;
            }

            Console.WriteLine("Enter player level:");
            int level = ReadInt();            
            int indexInBase =CreatePlayerIndex();                       
            bool isBanned = false;
            _players.Add(indexInBase, new Player(nickName, level, isBanned));
        }

        public void DeletePlayer()
        {
            Console.WriteLine("Enter user identifier");
            bool isNumber = int.TryParse(Console.ReadLine(), out int identifier);

            if (isNumber == true && _players.ContainsKey(identifier))
            {                
                _players.Remove(identifier);
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
                
                foreach (var person in _players)
                {
                    int index = person.Key;
                    _players[index].ShowInfo();
                    Console.WriteLine($"identifier:{index}");
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
            BanUser();                          
        }

        public void UnBanPlayer()
        {
            UnbanUser();                                           
        }

        public int ReadInt()
        {
            bool inCorrectInput = true;
            int input = 0;

            while (inCorrectInput)
            {
                bool isNumber = int.TryParse(Console.ReadLine(), out input);

                if (isNumber == false)
                {
                    string explanation = "Incorrect input. Level must contain only numbers. \nExample: 10";
                    Console.WriteLine(explanation);
                    inCorrectInput = true;
                }
                else
                {
                    inCorrectInput = false;
                }                
            }
            return input;
        }

        public int CreatePlayerIndex()
        {
            bool inCorrectIndex = true;
            Random playerIndex = new Random();
            int minimalPlayerIndex = 1000;
            int maximalPlayerIndex = 10000;
            int indexInBase = playerIndex.Next(minimalPlayerIndex, maximalPlayerIndex);

            while (inCorrectIndex)
            {

                if (_players.ContainsKey(indexInBase))
                {
                    indexInBase = playerIndex.Next(minimalPlayerIndex, maximalPlayerIndex);
                }
                else
                {                    
                    inCorrectIndex = false;
                }
            }
            return indexInBase;
        }

        public void BanUser()
        {
            Console.WriteLine("Enter user identifier");
            bool isNumber = int.TryParse(Console.ReadLine(), out int identifier);

            if (isNumber == true & _players.ContainsKey(identifier) == true)
            {
                
                if (_players[identifier].IsBanned == false)
                {
                    _players[identifier].Ban();
                    Console.WriteLine("Player banned.");
                }
                else
                {
                    Console.WriteLine("Player is already banned.");
                }
            }
            else
            {
                Console.WriteLine("Incorrect input or the player with this number is not in the database.");
            }
        }

        public void UnbanUser()
        {
            Console.WriteLine("Enter user identifier");
            bool isNumber = int.TryParse(Console.ReadLine(), out int identifier);

            if (isNumber == true & _players.ContainsKey(identifier) == true)
            {

                if (_players[identifier].IsBanned == true)
                {
                    _players[identifier].UnBan();
                    Console.WriteLine("Player unbanned.");
                }
                else
                {
                    Console.WriteLine("Player is already unbanned.");
                }
            }
            else
            {
                Console.WriteLine("Incorrect input or the player with this number is not in the database.");
            }
        }
    }
}


