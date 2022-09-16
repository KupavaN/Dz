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
            player1.showStats();
        }
    }

    class Player
    {
        public int Strength;
        public int Perception;
        public int Endurance;
        public int Charisma;
        public int Intelligence;
        public int Agility;
        public int Luck;

        public Player(int strength, int perception, int endurance, int charisma,
            int intelligence, int agility, int luck)
        {
            Strength = strength;
            Perception = perception;
            Endurance = endurance;
            Charisma = charisma;
            Intelligence = intelligence;
            Agility = agility;
            Luck = luck;
        }

        public Player()
        {
            Strength = 1;
            Perception = 1;
            Endurance = 1;
            Charisma = 1;
            Intelligence = 1;
            Agility = 1;
            Luck = 1;
        }

        public void showStats()
        {
            Console.WriteLine($"Strength - {Strength}\nPerception - {Perception}\n" +
                $"Endurance - {Endurance}\nCharisma - {Charisma}\nIntelligence - {Intelligence}\n" +
                $"Agility - {Agility}\nLuck - {Luck} ");
        }
    }
}


