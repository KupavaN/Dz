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
            // ДЗ-5           
            string name = "Kurilov";
            string surname = "Pavel";
            string checkName = name;
            string itog = name + " " + surname;
            Console.WriteLine(itog);
            name = surname;
            surname = checkName;
            string itogNew = name + " " + surname;
            Console.WriteLine(itogNew);
        }
    }
}
