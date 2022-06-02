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
            string userInput = "";
            string userSign;
            int frameLength = 0;
            int firstAndLastFrameSign = 2;
            string frameString = "";

            Console.WriteLine("Enter your word");
            userInput = Console.ReadLine();
            Console.WriteLine("Enter the symbol from which the rectangle will be created. For eximple F");
            userSign =Console.ReadLine();
            frameLength = userInput.Length+firstAndLastFrameSign;
                        
            for (int i = 0; i < (frameLength); i++)
            {
                frameString = frameString + userSign;
            }

            Console.WriteLine(frameString);
            Console.WriteLine(userSign+userInput+userSign);
            Console.WriteLine(frameString);
        }
    }
}
