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
            string name = "Kurilov";
            string surname = "Pavel";          
            string itog = name + " " + surname;
            Console.WriteLine(itog);
            string nameCorrect = "Pavel";
            string surnameCorrect = "Kurilov";
            name = nameCorrect;
            surname = surnameCorrect;
            string itogNew = name + " " + surname;
            Console.WriteLine(itogNew);
        }
    }
}
