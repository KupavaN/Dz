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
            Dictionary<int, string> dictionary = new Dictionary<int, string>()
            {
                {1,"A large, round, green fruit that is pink inside with a lot of black seeds" },
                {2, "A hard, round fruit with a green or red skin" },
                {3, "A type of food made with meat, vegetables, or fruit which is covered in pastry and baked" },
                {4, "A valuable, shiny, yellow metal used to make coins and jewellery (symbol Au)" }
            };
            const string Watermelon = "1";
            const string Apple = "2";
            const string Pie = "3";
            const string Gold = "4";

            bool isDictionaryOpen = true;

            while (isDictionaryOpen)
            {
                Console.WriteLine($"There are 4 words in our dictionary :Watermelon = {Watermelon},Apple = {Apple},Pie = {Pie},Gold = {Gold}.");
                Console.WriteLine("Enter the number of the word you want to know the meaning of. \n0 - Close the dictionary ");
                int userInput = Convert.ToInt32(Console.ReadLine());

                if (dictionary.ContainsKey(userInput))
                {
                    Console.WriteLine(dictionary[userInput]);
                    Console.Read();
                }
                else if (userInput !=0 )
                {
                    Console.WriteLine("Unknown word.");
                    Console.Read();
                }

                if (userInput == 0)
                {
                    isDictionaryOpen = false;
                }
                else
                {
                    Console.WriteLine("Incorrect input.");
                    Console.Read();
                }
                Console.Clear();                
            }
        }
    }
}

