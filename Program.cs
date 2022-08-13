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
            Conversation();
        }

        static int Conversation()
        {
            int convert = 0;
            bool conversionIsDone = false;

            while (conversionIsDone == false)
            {
                Console.Write("Enter number: ");
                string input = Console.ReadLine();
                conversionIsDone = int.TryParse(input, out convert);

                if (conversionIsDone == true)
                {
                    Console.WriteLine(convert);

                }
                else
                {
                    Console.WriteLine("The conversion failed. Try again");
                }
            }
            return convert;
        }

    }
}
