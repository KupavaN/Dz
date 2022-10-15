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
            const string TakeACard = "1";
            const string ShowHand = "2";
            const string Enougth = "3";            
            bool isWork = true;
            Pack pack = new Pack();
            Player player = new Player();
            string userInput;

            while (isWork)
            {
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine($"{TakeACard}-Take a card. \n{ShowHand}-Show card's in hand. \n{Enougth}-Enougth card's and exit.");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case TakeACard:
                        player.TakeCard(pack);
                        break;
                    case ShowHand:
                        player.ShowHand();                       
                        break;
                    case Enougth:
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

        public int ShowScore()
        {
            int score = 0;

            for (int i = 0; i < _cardsInHand.Count; i++)
            {
                score += _cardsInHand[i].Value;
            }

            Console.WriteLine($"\nYour score:{score}");
            return score;
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
        private int _maximumNumberCard = 36;

        public Pack()
        {
            AddToPack();
        }
       
        enum name
        {
            Ace,
            Six,
            Seven,
            Eigth,
            Nine,
            Ten,
            Jack,
            Queen,
            King
        }

        enum suit
        {
            Heart,
            Diamond,
            Club,
            Spade
        }
               
        private void AddToPack()
        {
            List<int> value = new List<int> { 11, 6, 7, 8, 9, 10, 2, 3, 4 }; 
            int cardsNameCount = 9;
            int cardsSuitCount = 4;
            for (int i = 0; i < cardsNameCount; i++)
            {
                int card = i;
                for (int k = 0; k < cardsSuitCount; k++)
                {
                    string a=Convert.ToString((name)i);
                    string b=Convert.ToString((suit)k);
                    int c = value[i];
                    _cards.Add(new Card(a, b, c));
                }

            }

        }
        private int GetNumber()
        {
            Random randomNumber = new Random();
            int numberCard = randomNumber.Next(_minimalNumberCard, _maximumNumberCard);
            _maximumNumberCard--;
            return numberCard;
        }

        public bool TryGetCard(out Card card)
        {

            if (_cards.Count > 0)
            {
                card = _cards[GetNumber()];
                _cards.Remove(card);
                return true;
            }
            else
            {
                card = null;
                return false;
            }
        }        
    }
}
