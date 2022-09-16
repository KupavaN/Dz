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
            player player1 = new player(3,7,2,3,4,7,9);
            player1.showStats();            
        }

        class player
        {
            int Strength;
            int Perception;
            int Endurance;
            int Charisma;
            int Intelligence;
            int Agility;
            int Luck;

            public player(int strength,int perception, int endurance,int charisma,
                int intelligence, int agility, int luck)
            {
                Strength= strength;
                Perception= perception;
                Endurance= endurance;
                Charisma= charisma;
                Intelligence= intelligence;
                Agility= agility;
                Luck= luck;
            }

            public player()
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
}


