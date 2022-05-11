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
            int timeInLine;
            int minutesInLine;
            int hoursInLine;
            Console.Write("How many people are in line? ");
            peopleInLine = Convert.ToInt32(Console.ReadLine());
            timeInLine = peopleInLine * appointmentTime;
            hoursInLine = timeInLine / 60;
            minutesInLine = timeInLine % 60;
            Console.WriteLine($"You have to wait for your turn for {hoursInLine} hours and {minutesInLine} minutes");
        }
    }
}
