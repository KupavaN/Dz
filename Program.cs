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

        private List<int> index = new List<int>();

        public string LasyNaming = "Player";
        public int LasyNamingCount = 1;

        public void AddPlayer()
        {
            Console.WriteLine("Enter player nickname");
            string nickName = Console.ReadLine();

            if (nickName == "")
            {
                nickName = LasyNaming + LasyNamingCount;
                LasyNamingCount++;
            }

            Console.WriteLine("Enter player level:");
            int level = ReadInt();
            Random random = new Random();
            int _indexInBase = random.Next(1000, 10000);

            if (index.Contains(_indexInBase))
            {
                return;
            }
            else
            {
                index.Add(_indexInBase);
            }

            bool isBanned = false;
            _players.Add(_indexInBase, new Player(nickName, level, isBanned));
        }

        public void DeletePlayer()
        {
            Console.WriteLine("Enter user identifier");
            bool isNumber = int.TryParse(Console.ReadLine(), out int identifier);

            if (isNumber == true && _players.ContainsKey(identifier) == true && index.Contains(identifier))
            {
                index.Remove(identifier);
                _players.Remove(identifier);
            }
            else
            {
                Console.WriteLine("Incorrect input or the player with this number is not in the database");
            }
        }

        public void ShowData()
        {
            if (index.Count != 0)
            {

                for (int i = 0; i < index.Count; i++)
                {
                    int checker = index[i];
                    _players[checker].ShowInfo();
                    Console.WriteLine($"identifier:{index[i]}");
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
    }
}


