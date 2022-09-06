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
            Queue <int> buyers = new Queue<int>();
            buyers.Enqueue(100);
            buyers.Enqueue(75);
            buyers.Enqueue(380);
            buyers.Enqueue(97);
            buyers.Enqueue(34);
            buyers.Enqueue(421);
            int till = 0;
            
            while (buyers.Count > 0)
            {
                Console.WriteLine($"Cash in till: {till}. Press any button to serve the buyer\n");
                Console.ReadKey();
                Console.Clear();
                till += buyers.Dequeue();                
            }

            Console.WriteLine($"Cash in till: {till}. All buyers served. Press any button to close the programm. \n");
            Console.ReadKey();
            Console.Clear();
        }
    }
}

