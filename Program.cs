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
            int rubToUsd = 75;
            int rubToEur = 80;
            int usdToRub = 74;
            float usdToEur = 0.96f;
            int eurToRub = 78;
            float eurToUsd = 0.85f;
            float currencyCount;
            
            string userInput;
            bool isProgrammWorks = true;

            float rub;
            float usd;
            float eur;           
            
            Console.Write("Enter your rub count ");
            rub = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter your usd count ");
            usd = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter your eur count ");
            eur = Convert.ToSingle(Console.ReadLine());

            while (isProgrammWorks == true)
            {
                Console.WriteLine("Hello friend. You can exchange currency there");
                Console.WriteLine($"You have {rub} rub {usd} usd and {eur} eur.");
                Console.WriteLine("If you want to exchange rub to usd press 1");
                Console.WriteLine("If you want to exchange rub to eur press 2");
                Console.WriteLine("If you want to exchange usd to rub press 3");
                Console.WriteLine("If you want to exchange usd to eur press 4");
                Console.WriteLine("If you want to exchange eur to rub press 5");
                Console.WriteLine("If you want to exchange eur to usd press 6");
                Console.WriteLine("If you want to close the programm enter Exit");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("You have chosen rub to usd");
                        Console.Write("How much do you want to exchange ");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        if (rub >= currencyCount)
                        {
                            rub-=currencyCount;
                            usd += currencyCount / rubToUsd;
                            Console.WriteLine("Completed successfully");
                            Console.WriteLine("You will be redirected to the selection screen");
                        }
                        else
                        {
                            Console.WriteLine("Invalid value.");
                            Console.WriteLine("You will be redirected to the selection screen");
                        }
                        break;
                    case "2":
                        Console.WriteLine("You have chosen rub to eur");
                        Console.Write("How much do you want to exchange ");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        if (rub >= currencyCount)
                        {
                            rub -= currencyCount;
                            eur += currencyCount / rubToEur;
                            Console.WriteLine("Completed successfully");
                            Console.WriteLine("You will be redirected to the selection screen");
                        }
                        else
                        {
                            Console.WriteLine("Invalid value.");
                            Console.WriteLine("You will be redirected to the selection screen");
                        }
                        break;
                    case "3":
                        Console.WriteLine("You have chosen usd to rub");
                        Console.Write("How much do you want to exchange ");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        if (usd >= currencyCount)
                        {
                            usd -= currencyCount;
                            rub += currencyCount * usdToRub;
                            Console.WriteLine("Completed successfully");
                            Console.WriteLine("You will be redirected to the selection screen");
                        }
                        else
                        {
                            Console.WriteLine("Invalid value.");
                            Console.WriteLine("You will be redirected to the selection screen");
                        }
                        break;
                    case "4":
                        Console.WriteLine("You have chosen usd to eur");
                        Console.Write("How much do you want to exchange ");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        if (usd >= currencyCount)
                        {
                            usd -= currencyCount;
                            eur += currencyCount / usdToEur;
                            Console.WriteLine("Completed successfully");
                            Console.WriteLine("You will be redirected to the selection screen");
                        }
                        else
                        {
                            Console.WriteLine("Invalid value.");
                            Console.WriteLine("You will be redirected to the selection screen");
                        }
                        break;
                    case "5":
                        Console.WriteLine("You have chosen eur to rub");
                        Console.Write("How much do you want to exchange ");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        if (eur >= currencyCount)
                        {
                            eur -= currencyCount;
                            rub += currencyCount * eurToRub;
                            Console.WriteLine("Completed successfully");
                            Console.WriteLine("You will be redirected to the selection screen");
                        }
                        else
                        {
                            Console.WriteLine("Invalid value.");
                            Console.WriteLine("You will be redirected to the selection screen");
                        }
                        break;
                    case "6":
                        Console.WriteLine("You have chosen eur to usd");
                        Console.Write("How much do you want to exchange ");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        if (eur >= currencyCount)
                        {
                            eur -= currencyCount;
                            usd += currencyCount * eurToUsd;
                            Console.WriteLine("Completed successfully");
                            Console.WriteLine("You will be redirected to the selection screen");
                        }
                        else
                        {
                            Console.WriteLine("Invalid value.");
                            Console.WriteLine("You will be redirected to the selection screen");
                        }
                        break;
                    case "Exit":
                        isProgrammWorks = false;
                        break;
                    default:
                        Console.WriteLine("Invalid value.");
                        Console.WriteLine("You will be redirected to the selection screen");
                        break;
                }
            }
        }
    }
}
