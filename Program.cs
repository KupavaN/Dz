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
            bool isActive = true;
            
            while (isActive)
            {
                Console.WriteLine("Enter the number you want add to the array:");
                Console.WriteLine("Enter 'sum' to sum all array numbers: ");
                Console.WriteLine("enter 'exit' if you want close the programm: \n");
                string userInput = Console.ReadLine();

                if (userInput != "sum" && userInput != "exit")
                {
                    int userNumber = Convert.ToInt32(userInput);
                    int[] tempArray = new int[array.Length + 1];
                    for (int i = 0; i < array.Length; i++)
                    {
                        tempArray[i] = array[i];
                    }                   
                    tempArray[tempArray.Length - 1] = userNumber;
                    array = tempArray;
                }
                else if (userInput == "sum")
                {
                    int sum = 0;

                    for (int i = 0; i < array.Length; i++)
                    {
                        sum += array[i];
                    }

                    Console.WriteLine();
                    Console.WriteLine($"Sum = {sum}");
                }
                else if (userInput == "exit")
                {
                    isActive = false;
                }                                
            }           
        }
    }
}
