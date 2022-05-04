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
            // ДЗ-4
            int totalPictures = 52;
            int totalLines;
            int picturesInLine = 3;
            int picturesNotFullLine;
            totalLines = totalPictures / picturesInLine;
            picturesNotFullLine = totalPictures % picturesInLine;            
            Console.WriteLine($"There are {totalLines} Lines and {picturesNotFullLine} more picture.");
        }
    }
}
