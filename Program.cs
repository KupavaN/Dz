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
            Player player1 = new Player(3, 7, 2, 3, 4, 7, 9);
            player1.ShowStats();
        }
    }

    class Player
    {
        private int _strength;
        private int _perception;
        private int _endurance;
        private int _charisma;
        private int _intelligence;
        private int _agility;
        private int _luck;

        public Player(int strength, int perception, int endurance, int charisma,
            int intelligence, int agility, int luck)
        {
            _strength = strength;
            _perception = perception;
            _endurance = endurance;
            _charisma = charisma;
            _intelligence = intelligence;
            _agility = agility;
            _luck = luck;
        }

        public Player()
        {
            _strength = 1;
            _perception = 1;
            _endurance = 1;
            _charisma = 1;
            _intelligence = 1;
            _agility = 1;
            _luck = 1;
        }              

        public void ShowStats()
        {
            Console.WriteLine($"Strength - {_strength}\nPerception - {_perception}\n" +
                $"Endurance - {_endurance}\nCharisma - {_charisma}\nIntelligence - {_intelligence}\n" +
                $"Agility - {_agility}\nLuck - {_luck} ");
        }
    }
}


