﻿using System;
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
           
           Random random = new Random();            
            int minimumPossibleNumber = 0;
            int maximumPossibleNumber = 101;
            int number = random.Next(minimumPossibleNumber, maximumPossibleNumber);
            int firstNumberMultiple = 3;
            int secondNumberMultiple = 5;            
            int score = 0;
            int totalCount = score;

            for (totalCount = score; totalCount <= number; totalCount++)
            {
                if ((totalCount % firstNumberMultiple == 0) ||(totalCount % secondNumberMultiple == 0))
                {
                    Console.WriteLine(totalCount);
                }
            }
            Console.WriteLine($"These are all multiples of {firstNumberMultiple} and {secondNumberMultiple} for the number {number}");               
        }  
    }
}
