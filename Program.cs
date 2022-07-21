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
            int[] array = new int[0];
            int[] arraySum = new int[array.Length];
            bool isActive = true;                        

            while (isActive)
            {
                Console.WriteLine("Enter the number you want add to the array:");
                Console.WriteLine("Enter 'sum' to sum all array numbers: ");
                Console.WriteLine("enter 'exit' if you want close the programm: \n");
                string userInput = Console.ReadLine();                

                if (userInput != "sum" && userInput != "exit")
                {
                    int arrayChecker = 1;
                    int userNumber = Convert.ToInt32(userInput);                    
                    array = new int[array.Length + arrayChecker];

                    for (int i =0; i < arraySum.Length; i++)
                    {
                        array[i] = arraySum[i];
                    }

                    array[array.Length- arrayChecker] =userNumber;
                    arraySum = array;
                    arraySum = new int[arraySum.Length + arrayChecker];
                    arraySum = array;
                }
                else if (userInput == "sum")
                {
                    int sum = 0;
                    int sumBase = 0;

                    for (int i = 0; i < array.Length; i++)
                    {
                        sum += array[i];
                    }

                    Console.WriteLine($"Sum = {sum}");
                    sum = sumBase;
                    
                    Console.WriteLine();
                }
                else if (userInput == "exit")
                {
                    isActive = false;
                }                                
            }           
        }
    }
}
