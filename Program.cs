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
            const string NewDossier = "1";
            const string ShowAllDossier = "2";
            const string DossierToRemove = "3";
            const string Exit = "4";
            Dictionary<string, string> staff = new Dictionary<string, string>();
            staff.Add("Petrov Ivan Sidorovich", "engeneer");
            staff.Add("Ivanov Sidor Petrovich", "driver");
            staff.Add("Sidorov Petr Ivanovich", "artist");
            bool isWork = true;

            while (isWork)
            {
                Console.WriteLine($"Add dossier - {NewDossier} \n" +
                    $"Show dossier - {ShowAllDossier} \n" +
                    $"Remove dossier -{DossierToRemove} \n" +
                    $"Exit programm -{Exit}");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case NewDossier:
                        AddDossier(staff);
                        break;
                    case ShowAllDossier:
                        ShowDossier(staff);
                        break;
                    case DossierToRemove:
                        RemoveDossier(staff);
                        break;
                    case Exit:
                        isWork = false;
                        break;
                    default:
                        Console.WriteLine("Incorrect input.");
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            }
        }

        static void AddDossier(Dictionary<string, string> staff)
        {
            Console.WriteLine("Enter new employee data");
            string newWorkerData = Console.ReadLine();
            Console.WriteLine("Enter new employee position");
            string newWorkerposition = Console.ReadLine();

            if (staff.ContainsKey(newWorkerData) == false)
            {
                staff.Add(newWorkerData, newWorkerposition);
            }
            else
            {
                Console.WriteLine("This data is already in the database");
            }
        }

        static void ShowDossier(Dictionary<string, string> staff)
        {
            foreach (var person in staff)
            {
                Console.WriteLine($"{person.Key} - {person.Value}");
            }
        }

        static void RemoveDossier(Dictionary<string, string> staff)
        {
            Console.WriteLine("Enter employee data to delete it");
            string deleteWorkerData = Console.ReadLine();

            if (staff.ContainsKey(deleteWorkerData) == false)
            {
                Console.WriteLine("No employee found.");
            }
            else
            {
                staff.Remove(deleteWorkerData);                
            }
        }
    }
}

