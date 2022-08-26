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
            List<string> words = new List<string>();
            List<string> wordsMeaning = new List<string>();
            words.Add("Watermelon");
            words.Add("Apple");
            words.Add("Pie");
            words.Add("Gold");
            wordsMeaning.Add("A large, round, green fruit that is pink inside with a lot of black seeds");
            wordsMeaning.Add("A hard, round fruit with a green or red skin");
            wordsMeaning.Add("A type of food made with meat, vegetables, or fruit which is covered in pastry and baked");
            wordsMeaning.Add("A valuable, shiny, yellow metal used to make coins and jewellery (symbol Au)");
            bool isDictionaryOpen = true;
            
            while (isDictionaryOpen)
            {
                Console.WriteLine("There are 4 words in our dictionary : Waterlemon, Apple, Pie, Gold.");
                Console.WriteLine("1 - Enter the word you want to know the meaning of. \n2 - Close the dictionary ");
                int chooseStep = Convert.ToInt32(Console.ReadLine());

                if (chooseStep == 1)
                {
                    Console.WriteLine("Enter the word:");
                    string userInput = Console.ReadLine();

                    for (int i = 0; i < words.Count; i++)
                    {
                        if (userInput == words[i])
                        {
                            Console.WriteLine(wordsMeaning[i]);
                            Console.Read();
                        }
                        else
                        {
                            Console.WriteLine("Unknown word.");
                            Console.Read();                            
                        }
                    }
                }
                else if (chooseStep == 2)
                {
                    isDictionaryOpen = false;
                }
                else
                {
                    Console.WriteLine("Incorrect input.");
                    Console.Read();
                }
                Console.Clear();
                Console.Read();
            }            
        }
    }
}

