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
            List<int> numbers = new List<int>(0);
            bool isProgrammOpen = true;

            while (isProgrammOpen)
            {                
                Console.WriteLine("Enter 1 to add the number to the list. \nEnter sum to sum numbers in the list.\nEnter exit to exit the programm.");
                string choosePoint = Console.ReadLine();

                if (choosePoint == "1")
                {
                    Console.WriteLine("Enter numbers whitch you want to add to the list");
                    string userInput = Console.ReadLine();
                    int addNumber = 0;
                    bool isTrue;
                    isTrue = int.TryParse(userInput, out addNumber);

                    if (isTrue)
                    {
                        numbers.Add(addNumber);                        
                    }                                                                    
                }
                else if (choosePoint == "exit")
                {
                    isProgrammOpen = false;
                }
                else if (choosePoint == "sum")
                {
                    int sum = 0;

                    for(int i = 0; i < numbers.Count; i++)
                    {
                        sum += numbers[i];
                    }

                    Console.WriteLine(sum);
                    Console.Read();
                }
                else
                {
                    Console.WriteLine("Incorrect input");
                }

                Console.Clear();                               
            }
        }
    }
}

