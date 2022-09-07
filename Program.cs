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
            const string SumList = "sum";
            const string Exit = "exit";

            while (isProgrammOpen)
            {                
                Console.WriteLine($"Enter numbers whitch you want to add to the list \nEnter {SumList} to sum numbers in the list.\nEnter {Exit} to exit the programm.");
                string userInput = Console.ReadLine();

                if (userInput == Exit)
                {                                                                                                                                           
                    isProgrammOpen = false;
                }
                else if (userInput == SumList)
                {
                    Sum(numbers);                   
                }
                else
                {
                    int addNumber = 0;
                    bool isTrue;
                    isTrue = int.TryParse(userInput, out addNumber);

                    if (isTrue)
                    {
                        numbers.Add(addNumber);
                    }
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

