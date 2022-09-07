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
            Dictionary<string, string> staff = new Dictionary<string, string>();
            staff.Add("Petrov Ivan Sidorovich", "engeneer");
            staff.Add("Ivanov Sidor Petrovich", "driver");
            staff.Add("Sidorov Petr Ivanovich", "artist");
            bool isWork = true;
            const string NewDossier = "1";
            const string ShowAllDossier = "2";
            const string DossierToRemove = "3";
            const string Exit = "4";

            while (isWork)
            {
                Console.WriteLine($"Add dossier - {NewDossier} \n" +
                    $"Show dossier - {ShowAllDossier} \n" +
                    $"Remove dossier -{DossierToRemove} \n" +
                    $"Exit programm -{Exit}");
                string userInput = Console.ReadLine();

                if (userInput == NewDossier)
                {
                    AddDossier(staff);
                }
                else if (userInput == ShowAllDossier)
                {
                    ShowDossier(staff);
                }
                else if (userInput == DossierToRemove)
                {
                    RemoveDossier(staff);
                }
                else if (userInput == Exit)
                {
                    isWork = false;
                }
                else
                {
                    Console.WriteLine("Incorrect input.");
                }

                Console.ReadKey();
                Console.Clear();
            }
        }

        static void AddDossier(Dictionary<string, string> staff)
        {
            Console.WriteLine("Enter new employee data");
            String newWorkerData = Console.ReadLine();
            Console.WriteLine("Enter new employee position");
            String newWorkerposition = Console.ReadLine();
            staff.Add(newWorkerData, newWorkerposition);
        }

        static void ShowDossier(Dictionary<string, string> staff)
        {
            foreach (var item in staff)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }

        static void RemoveDossier(Dictionary<string, string> staff)
        {
            Console.WriteLine("Enter employee data to delete it");
            String deleteWorkerData = Console.ReadLine();
            staff.Remove(deleteWorkerData);

            foreach (var item in staff)
            {
                if (item.Key != deleteWorkerData)
                {
                    Console.WriteLine("No employee found.");
                    break;
                }
            }
        }
    }
}

