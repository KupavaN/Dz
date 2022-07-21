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
            int arrayLength = 0;
            int[] array = new int[arrayLength];           
            int userNumber;
            bool isActive = true;
            int[] arraySum = new int[array.Length + 1];
            int sum = 0;
            int sumBase = 0;

            while (isActive)
            {
                Console.WriteLine("Enter the number you want add to the array:");
                Console.WriteLine("Enter 'sum' to sum all array numbers: ");
                Console.WriteLine("enter 'exit' if you want close the programm: \n");
                string userInput = Console.ReadLine();

                if (userInput != "sum" && userInput != "exit")
                {
                    userNumber = Convert.ToInt32(userInput);
                    arrayLength++;
                    array = new int[arrayLength];

                    for (int i = 0; i < arraySum.Length; i++)
                    {
                        array[i] = arraySum[i];
                    }

                    array[arrayLength - 1] = userNumber;
                    arraySum = new int[arrayLength];

                    for (int i = 0; i < array.Length; i++)
                    {
                        arraySum[i] = array[i];
                    }

                    arraySum[arrayLength - 1] = userNumber;                    
                }
                else if (userInput == "sum")
                {

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
