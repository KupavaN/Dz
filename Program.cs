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
            const string Exit = "4";
            bool isWork = true;            
            PackOfCards packOfCards = new PackOfCards();
            Player playerCards = new Player();
            string userInput;            
            int playerScore = 0;


            while (isWork)
            {
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine($"{TakeACard}-Take a card. \n{ShowHand}-Show card's in hand. \n{Enougth}-Enougth card's. \n{Exit}-Exit.");                
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case TakeACard:
                        playerCards.TakeCard(packOfCards);
                        break;
                        case ShowHand:
                        Console.WriteLine("\nYour cards:");
                        playerCards.ShowHand();
                        break;
                    case Enougth:                        
                        Console.WriteLine("\nYour score:");
                        playerScore = playerCards.ShowScore();
                        Console.WriteLine(playerScore);
                        Console.WriteLine("\nYour cards:");
                        playerCards.ShowHand();
                        isWork = false;
                        break;
                    case Exit:
                        isWork = false;
                        break;
                }
            }
        }
    }

    class Player
    {
        private List<Card> _cardsInHand = new List<Card>();

        public void TakeCard(PackOfCards packOfCards)
        {

            if (packOfCards.TryGetCard(out Card card))
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
                score += _cardsInHand[i].CardValue;
            }

            return score;
        }
    }
   
    class Card
    {
        public string CardName { get; private set; }
        public string CardSuit { get; private set; }
        public int CardValue { get; private set; }

        public Card(string cardName, string cardSuit, int cardValue)
        {
            CardName = cardName;
            CardSuit = cardSuit;
            CardValue = cardValue;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"CardName - {CardName} \nCardSuit - {CardSuit} \nCardValue - {CardValue}");
        }
    }

    class PackOfCards
    {
        private List<Card> _cards = new List<Card>();
        private int _minimalNumberCard = 0;
        private int _maximumNumberCard = 36;

        public PackOfCards()
        {
            _cards.Add(new Card("Ace", "Heart", 11));
            _cards.Add(new Card("Ace", "Diamond", 11));
            _cards.Add(new Card("Ace", "Club", 11));
            _cards.Add(new Card("Ace", "Spade", 11));
            _cards.Add(new Card("Six", "Heart", 6));
            _cards.Add(new Card("Six", "Diamond", 6));
            _cards.Add(new Card("Six", "Club", 6));
            _cards.Add(new Card("Six", "Spade", 6));
            _cards.Add(new Card("Seven", "Heart", 7));
            _cards.Add(new Card("Seven", "Diamond", 7));
            _cards.Add(new Card("Seven", "Club", 7));
            _cards.Add(new Card("Seven", "Spade", 7));
            _cards.Add(new Card("Eight", "Heart", 8));
            _cards.Add(new Card("Eight", "Diamond", 8));
            _cards.Add(new Card("Eight", "Club", 8));
            _cards.Add(new Card("Eight", "Spade", 8));
            _cards.Add(new Card("Nine", "Heart", 9));
            _cards.Add(new Card("Nine", "Diamond", 9));
            _cards.Add(new Card("Nine", "Club", 9));
            _cards.Add(new Card("Nine", "Spade", 9));
            _cards.Add(new Card("Ten", "Heart", 10));
            _cards.Add(new Card("Ten", "Diamond", 10));
            _cards.Add(new Card("Ten", "Club", 10));
            _cards.Add(new Card("Ten", "Spade", 10));
            _cards.Add(new Card("Jack", "Heart", 2));
            _cards.Add(new Card("Jack", "Diamond", 2));
            _cards.Add(new Card("Jack", "Club", 2));
            _cards.Add(new Card("Jack", "Spade", 2));
            _cards.Add(new Card("Queen", "Heart", 3));
            _cards.Add(new Card("Queen", "Diamond", 3));
            _cards.Add(new Card("Queen", "Club", 3));
            _cards.Add(new Card("Queen", "Spade", 3));
            _cards.Add(new Card("King", "Heart", 4));
            _cards.Add(new Card("King", "Diamond", 4));
            _cards.Add(new Card("King", "Club", 4));
            _cards.Add(new Card("King", "Spade", 4));
        }

        private int GetNumberCard()
        {
            Random randomCard = new Random();
            int numberCard = randomCard.Next(_minimalNumberCard, _maximumNumberCard);
            _maximumNumberCard--;
            return numberCard;
        }       
       
        public bool TryGetCard(out Card card)
        {
            if (_cards.Count > 0)
            {
                card = _cards[GetNumberCard()];
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
