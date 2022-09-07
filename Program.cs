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
            const string AddNumber = "add";
            const string SumList = "sum";
            const string Exit = "exit";

            while (isProgrammOpen)
            {                
                Console.WriteLine($"Enter {AddNumber} to add the number to the list. \nEnter {SumList} to sum numbers in the list.\nEnter {Exit} to exit the programm.");
                string choosePoint = Console.ReadLine();

                if (choosePoint == AddNumber)
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
                else if (choosePoint == Exit)
                {
                    isProgrammOpen = false;
                }
                else if (choosePoint == SumList)
                {
                    Sum(numbers);                   
                }
                else
                {
                    Console.WriteLine("Incorrect input");
                }

                Console.Clear();                               
            }
        }

        static void Sum(List<int> numbers)
        {
            int sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine(sum);
            Console.Read();
        }
    }
}

