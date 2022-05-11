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
            int peopleInLine;
            int appointmentTime = 10;
            int time;
            int minutes;
            int hours;
            Console.Write("How many people are in line? ");
            peopleInLine = Convert.ToInt32(Console.ReadLine());
            time = peopleInLine * appointmentTime;
            hours = time / 60;
            minutes = time % 60;
            Console.WriteLine($"You have to wait for your turn for {hours} hours and {minutes} minutes");
        }
    }
}
