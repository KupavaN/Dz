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
            int number = rand.Next(0, 101);
            int firstNumberMultiple = 3;
            int secondNumberMultiple = 5;
            int multipleOne = firstNumberMultiple;
            int multipleTwo = secondNumberMultiple;                       
            bool isNumberDivideToFirstNumberMultiple = firstNumberMultiple < number;
            bool isNumberDivideToSecondNumberMultiple = secondNumberMultiple < number;
            bool isTheSumCorrect = isNumberDivideToFirstNumberMultiple == true && isNumberDivideToSecondNumberMultiple == true;
            
            while (isTheSumCorrect == true)
            {                
                if (isNumberDivideToFirstNumberMultiple == true)
                {
                    Console.WriteLine(firstNumberMultiple);
                    firstNumberMultiple += multipleOne;                    
                    if (secondNumberMultiple < firstNumberMultiple)
                    {
                        isNumberDivideToSecondNumberMultiple = true;
                    }
                    if (firstNumberMultiple > number)
                    {
                        isNumberDivideToFirstNumberMultiple = false;
                    }                                       
                    if (secondNumberMultiple > number || secondNumberMultiple > firstNumberMultiple)
                    {
                        isNumberDivideToSecondNumberMultiple = false;
                    }                    
                        if (isNumberDivideToSecondNumberMultiple == true)
                    {
                        Console.WriteLine(secondNumberMultiple);
                        secondNumberMultiple += multipleTwo;
                    }                                            
                }

            }                                            
        }  
    }
}

