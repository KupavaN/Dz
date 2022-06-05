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
            string password = "123";
            int attempts = 3;
            string userInput;

            
            Console.WriteLine("Enter password");            

            for (int i = attempts; i >0; i--)
            {
                Console.WriteLine($"You have {i} attempts");
                userInput = Console.ReadLine();
                
                if (userInput == password)
                {
                    Console.WriteLine("Secret messege: \nHello world!");                    
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid password");  
                    
                }                
            }

        }
    }
}
