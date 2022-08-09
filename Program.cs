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
            string[] fio = { "Ivanov Petr Sergeevich", "Petrov Sergei ivanovich", "Sergeev Ivan Petrovich" };
            string[] role = { "doctor", "manager", "builder" };
            bool isWork = true;

            while (isWork)
            {
                Console.Clear();
                Console.WriteLine("1 to add new dossier.\n2 to show all dossier.\n3 to delete dossier.\n4 to search by surname.\n5 to close the programm.");
                string userInput;
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        AddDossier(ref fio, ref role);
                        break;
                    case "2":
                        ShowDossier(fio, role);
                        break;
                    case "3":
                        DeleteDossier(ref fio, ref role);
                        break;
                    case "4":
                        SearchDossier(fio, role);
                        break;
                    case "5":
                        isWork = false;
                        break;
                }
            }
        }
        static string[] AddDossierInfo(string[] fio, string checkFio)
        {
            string[] tempFio = new string[fio.Length + 1];

            for (int i = 0; i < fio.Length; i++)
            {
                tempFio[i] = fio[i];
            }

            fio = tempFio;
            fio[fio.Length - 1] = checkFio;
            return fio;
        }
        static void AddDossier(ref string[] fio, ref string[] role)
        {
            Console.Clear();
            Console.WriteLine("Enter FIO: ");
            string newFio = Console.ReadLine();
            fio = AddDossierInfo(fio, newFio);
            Console.WriteLine("Enter role: ");
            string newRole = Console.ReadLine();
            role = AddDossierInfo(role, newRole);
            Console.ReadKey();
            Console.Clear();
        }
        static void ShowDossier(string[] fio, string[] role)
        {

            for (int i = 0; i < fio.Length; i++)
            {
                Console.Write(i + 1 + " " + fio[i] + " - " + role[i] + ". ");
            }

            Console.WriteLine();
            Console.ReadKey();
        }
        static void SearchDossier(string[] fio, string[] role)
        {
            string findFio;
            bool isDossierFind = false;
            Console.WriteLine("Enter the surname to find dossier.");
            findFio = Console.ReadLine();

            if (fio.Length == 0)
            {
                Console.WriteLine("There is no dossier in the database.");
            }

            else
            {
                for (int i = 0; i < fio.Length; i++)
                {

                    if (findFio.ToLower() == fio[i].ToLower())
                    {
                        Console.WriteLine(i + 1 + " " + fio[i] + "-" + role[i] + ". ");
                        isDossierFind = true;
                    }
                }

                if (isDossierFind == false)
                {
                    Console.WriteLine("Dossier not found.");
                }

                Console.WriteLine();
                Console.ReadKey();
            }
        }
        public static void DeleteDossier(ref string[] fio, ref string[] role)
        {
            string indexToDelete;
            Console.WriteLine("select the number of the dossier to be deleted");
            indexToDelete = Console.ReadLine();
            fio = DeleteDossierInfo(fio, indexToDelete);
            role = DeleteDossierInfo(role, indexToDelete);
        }
        public static string[] DeleteDossierInfo(string[] fio, string indexToDelete)
        {
            int indexChecker = Convert.ToInt32(indexToDelete);

            if (indexChecker <= fio.Length)
            {
                for (int i = 0; i < indexChecker; i++)
                {
                    for (int j = 0; j < fio.Length - 1; j++)
                    {
                        indexToDelete = fio[j];
                        fio[j] = fio[j + 1];
                        fio[j + 1] = indexToDelete;
                    }
                }

                Array.Resize(ref fio, fio.Length - 1);
            }

            else if (fio.Length == 0)
            {
                Console.WriteLine("No dossier found in database");
            }
            else
            {
                Console.WriteLine("There is no dossier with this number");
            }

            Console.WriteLine();
            Console.ReadKey();
            return fio;
        }
    }
}
