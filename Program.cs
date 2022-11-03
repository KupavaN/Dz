using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandTakeACard = "1";
            const string CommandShowHand = "2";
            const string CommandEnougth = "3";
            bool isWork = true;
            Pack pack = new Pack();
            Player player = new Player();
            string userInput;

            while (isWork)
            {
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine($"{CommandTakeACard}-Take a card. \n{CommandShowHand}-Show card's in hand. \n{CommandEnougth}-Enougth card's and exit.");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case CommandTakeACard:
                        player.TakeCard(pack);
                        break;
                    case CommandShowHand:
                        player.ShowHand();
                        break;
                    case CommandEnougth:
                        isWork = false;
                        break;
                }
            }

            player.ShowScore();
            player.ShowHand();
        }
    }

    class Player
    {
        private List<Card> _cardsInHand = new List<Card>();

        public void TakeCard(Pack pack)
        {

            if (pack.TryGetCard(out Card card))
            {
                _cardsInHand.Add(card);
                Console.WriteLine("You take 1 card.");
            }
            else
            {
                Console.WriteLine("No cards in pack.");
            }
        }

        public void ShowHand()
        {
            Console.WriteLine("\nYour cards:");

            for (int i = 0; i < _cardsInHand.Count; i++)
            {
                _cardsInHand[i].ShowInfo();
                Console.WriteLine();
            }
        }

        public void ShowScore()
        {
            int score = 0;

            for (int i = 0; i < _cardsInHand.Count; i++)
            {
                score += _cardsInHand[i].Value;
            }

            Console.WriteLine($"\nYour score:{score}");
        }
    }

    class Card
    {
        public string Name { get; private set; }
        public string Suit { get; private set; }
        public int Value { get; private set; }

        public Card(string name, string suit, int value)
        {
            Name = name;
            Suit = suit;
            Value = value;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"CardName - {Name} \nCardSuit - {Suit} \nCardValue - {Value}");
        }
    }

    class Pack
    {
        private List<Card> _cards = new List<Card>();
        private int _minimalNumberCard = 0;
        private int _cardsLeftInPack = 36;

        public Pack()
        {
            AddToPack();
        }

        public bool TryGetCard(out Card card)
        {

            if (_cards.Count > 0)
            {
                card = _cards[GetCardInPackNumber()];
                _cards.Remove(card);
                return true;
            }
            else
            {
                card = null;
                return false;
            }
        }

        private int GetCardInPackNumber()
        {
            Random random = new Random();
            int numberCard = random.Next(_minimalNumberCard, _cardsLeftInPack);
            _cardsLeftInPack--;
            return numberCard;
        }

        enum Suit
        {
            Heart,
            Diamond,
            Club,
            Spade
        }

        private void AddToPack()
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>()
            {
             { "Ace", 11},
             { "Six", 6},
             { "Seven", 7},
             { "Eigth", 8},
             { "Nine", 9},
             { "Ten", 10},
             { "Jack", 2},
             { "Queen", 3},
             { "King", 4}
            };

            for (int i = 0; i < Convert.ToInt32(Suit.Spade + 1); i++)
            {
                string suit = Convert.ToString((Suit)i);
                foreach (var card in dictionary)
                {
                    _cards.Add(new Card(card.Key, suit, card.Value));
                }
            }
        }
    }
}
