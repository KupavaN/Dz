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
            Console.WriteLine(ReadInt());
        }

        static int ReadInt()
        {
            int convert = 0;
            bool isConversionDone = false;

            while (isConversionDone == false)
            {
                Console.Write("Enter number: ");
                string input = Console.ReadLine();
                isConversionDone = int.TryParse(input, out convert);

                if (isConversionDone == false)
                {                    
                    Console.WriteLine("The conversion failed. Try again");
                }
            }
            return convert;
        }

    }
}
