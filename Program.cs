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

            string text = Console.ReadLine();
            int length = text.Length;            
            int count = 0;
            int bracketDepth = 0;
            if (length == 0)
            {
                Console.WriteLine("Invalid value");
                return;
            }
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] ==Convert.ToChar("("))
                {
                    count++;
                    bracketDepth--;
                    if (bracketDepth <= 0)
                    {
                        bracketDepth = 0;
                    }
                }
                else if (text[i] == Convert.ToChar(")"))
                {
                    count--;
                    bracketDepth++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine(bracketDepth);
            }
            else if (count > 0 || count <0)
            {
                Console.WriteLine("Incorrect bracket expression");
            }
        }
    }
}
