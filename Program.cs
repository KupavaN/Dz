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
           
           Random rand = new Random();
              int number = 10;
             int firstNumberMultiple = 3;
              int secondNumberMultiple = 5;
              int multipleOne = firstNumberMultiple;
              int multipleTwo = secondNumberMultiple;
               bool finalOne = true;
             bool finalTwo = true;
            for (multipleOne = firstNumberMultiple; multipleOne <= number; multipleOne += firstNumberMultiple)
            {
                Console.WriteLine(multipleOne);
            }
            Console.WriteLine($"these are all multiples of {firstNumberMultiple}");

            for (multipleTwo = secondNumberMultiple; multipleTwo <= number; multipleTwo += secondNumberMultiple)
            {
                Console.WriteLine(multipleTwo);
            }
            Console.WriteLine($"these are all multiples of {secondNumberMultiple}");

        }  
    }
}
