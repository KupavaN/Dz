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
            string[] Fio = { "Ivanov Petr Sergeevich", "Petrov Sergei ivanovich", "Sergeev Ivan Petrovich" };
            string[] Role = { "doctor", "manager", "builder" };
            bool isWork = true;

            while (isWork == true)
            {
                Console.Clear();
                Console.WriteLine("1 to add new dossier.\n2 to show all dossier.\n3 to delete dossier.\n4 to search by surname.\n5 to close the programm.");
                string userInput;
                userInput = Console.ReadLine();
                
                switch (userInput)
                {
                    case "1":
                        {
                            AddDossier(ref Fio, ref Role);
                        }
                        break;
                    case "2":
                        {
                            ShowDossier(Fio, Role);
                        }
                        break;
                    case "3":
                        {
                            DeleteDossierInfo(ref Fio, ref Role);
                        }
                        break;
                    case "4":
                        {
                            SearchDossier(Fio, Role);
                        }
                        break;
                    case "5":
                        isWork = false;
                        break;
                }
            }
        }
        static string[] AddDossierInfo(string[] Fio, string checkFio)
        {
            string[] tempFio = new string[Fio.Length + 1];

            for (int i = 0; i < Fio.Length; i++)
            {
                tempFio[i] = Fio[i];
            }

            Fio = tempFio;
            Fio[Fio.Length - 1] = checkFio;
            return Fio;
        }
        static void AddDossier(ref string[] Fio, ref string[] Role)
        {
            string newFio;
            string newRole;

            Console.Clear();
            Console.WriteLine("Enter FIO: ");
            newFio = Console.ReadLine();
            Fio = AddDossierInfo(Fio, newFio);
            Console.WriteLine("Enter role: ");
            newRole = Console.ReadLine();
            Role = AddDossierInfo(Role, newRole);
            Console.ReadKey();
            Console.Clear();
        }
        static void ShowDossier(string[] Fio, string[] Role)
        {
            int dosserNumber = 1;

            for (int i = 0; i < Fio.Length; i++)
            {
                Console.Write(dosserNumber + " " + Fio[i] + " - " + Role[i] + ". ");
                dosserNumber++;
            }

            Console.WriteLine();
            Console.ReadKey();
        }
        static void SearchDossier( string[] Fio, string[] Role)
        {
            string surname;
            bool isDossierFind = false;
            Console.WriteLine("Enter the surname to find dossier.");
            surname = Console.ReadLine();
            int dosserNumber = 0;

            if (Fio.Length == 0)
            {
                Console.WriteLine("There is no dossier in the database.");
            }

            if (Fio.Length != 0)
            {
                for (int i = 0; i < Fio.Length; i++)
                {
                    dosserNumber++;

                    if (surname.ToLower() == Fio[i].ToLower())
                    {
                        Console.WriteLine(dosserNumber + " " + Fio[i] + "-" + Role[i] + ". ");
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
        public static void DeleteDossierInfo(ref string[] Fio, ref string[] Role)
        {
            string indexToDelete;
            Console.WriteLine("select the number of the dossier to be deleted");
            indexToDelete = Console.ReadLine();
            Fio = DeleteDossier(Fio, indexToDelete);
            Role = DeleteDossier(Role, indexToDelete);
        }
        public static string[] DeleteDossier(string[] Fio, string indexToDelete)
        {
            int indexChecker = Convert.ToInt32(indexToDelete);

            if (indexChecker <= Fio.Length)
            {
                for (int i = 0; i < indexChecker; i++)
                {
                    for (int j = 0; j < Fio.Length - 1; j++)
                    {
                        indexToDelete = Fio[j];
                        Fio[j] = Fio[j + 1];
                        Fio[j + 1] = indexToDelete;
                    }
                }

                Array.Resize(ref Fio, Fio.Length - 1);
            }

            else if (Fio.Length == 0)
            {
                Console.WriteLine("No dossier found in database");
            }
            else
            {
                Console.WriteLine("There is no dossier with this number");
            }

            Console.WriteLine();
            Console.ReadKey();
            return Fio;
        }
    }
}
