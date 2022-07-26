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
            int userInput;
            int[] array = { 1, 2, 3, 4,};
            int numberChecker = 0;
           
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Enter how many numbers should be move the list by");
            userInput = Console.Read();

            for (int i = 0; i < userInput; i++)
            {
                for (int j =0; j<array.Length - 1;j++)
                {                                        
                        numberChecker = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = numberChecker;                                            
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
        }
    }
}
