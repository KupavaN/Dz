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
            const string DeleteTheDossier = "3";
            const string SearchTheDossier = "4";
            const string ExitProgramm = "5";
            string[] fullNames = { "Ivanov Petr Sergeevich", "Petrov Sergei ivanovich", "Sergeev Ivan Petrovich" };
            string[] roles = { "doctor", "manager", "builder" };
            bool isWork = true;

            while (isWork)
            {
                Console.Clear();                
                Console.WriteLine($"{NewDossier} to add new dossier.\n{ShowAllDossier} to show all dossier.\n{DeleteTheDossier} to delete dossier.\n{SearchTheDossier} to search by surname.\n{ExitProgramm} to close the programm.");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case NewDossier:
                        AddDossier(ref fullNames, ref roles);
                        break;
                    case ShowAllDossier:
                        ShowDossier(fullNames, roles);
                        break;
                    case DeleteTheDossier:
                        DeleteDossier(ref fullNames, ref roles);
                        break;
                    case SearchTheDossier:
                        SearchDossier(fullNames, roles);
                        break;
                    case ExitProgramm:
                        isWork = false;
                        break;
                    default:
                        Console.WriteLine("Wrong number");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
        static string[] AddElement(string[] array, string element)
        {
            string[] tempArray = new string[array.Length + 1];

            for (int i = 0; i < array.Length; i++)
            {
                tempArray[i] = array[i];
            }

            tempArray[tempArray.Length - 1] = element;
            return tempArray;
        }

        static void AddDossier(ref string[] fullNames, ref string[] roles)
        {
            Console.Clear();
            Console.WriteLine("Enter full name: ");
            string newfullName = Console.ReadLine();
            fullNames = AddElement(fullNames, newfullName);
            Console.WriteLine("Enter role: ");
            string newRole = Console.ReadLine();
            roles = AddElement(roles, newRole);
        }

        static void ShowDossier(string[] fullNames, string[] roles)
        {
            for (int i = 0; i < fullNames.Length; i++)
            {
                Console.Write(i + 1 + " " + fullNames[i] + " - " + roles[i] + ". ");
            }
        }

        static void SearchDossier(string[] fullNames, string[] roles)
        {            
            bool isDossierFind = false;
            Console.WriteLine("Enter the surname to find dossier.");
            string findSurname = Console.ReadLine();
            int wordCount = 0;

            if (fullNames.Length == 0)
            {
                Console.WriteLine("There is no dossier in the database.");
            }
            else
            {
                for (int i = 0; i < fullNames.Length; i++)
                {
                    string words = fullNames[i];
                    string [] fullNamesToWords=words.Split(' ');

                    if (findSurname.ToLower() == fullNamesToWords[0].ToLower())
                    {
                        Console.WriteLine(i + 1 + " " + fullNames[wordCount] + "-" + roles[wordCount] + ". ");
                        isDossierFind = true;
                    }

                    wordCount++;
                }

                if (isDossierFind == false)
                {
                    Console.WriteLine("Dossier not found.");
                }
            }
        }

        static void DeleteDossier(ref string[] fullNames, ref string[] roles)
        {
            Console.WriteLine("select the number of the dossier to be deleted");
            int indexToDelete = Convert.ToInt32(Console.ReadLine());

            if (indexToDelete <= fullNames.Length)
            {
                indexToDelete--;
                fullNames = DeleteDossierInfo(fullNames, indexToDelete);
                roles = DeleteDossierInfo(roles, indexToDelete);
            }

            if (fullNames.Length == 0)
            {
                Console.WriteLine("No dossier found in database");
            }

            if (indexToDelete >= fullNames.Length)
            {
                Console.WriteLine("There is no dossier with this number");
            }
        }

        static string[] DeleteDossierInfo(string[] array, int indexToDelete)
        {
            string[] tempArray = new string[array.Length - 1];

            for (int i = 0; i < indexToDelete; i++)
            {
                tempArray[i] = array[i];
            }

            for (int i = indexToDelete; i < tempArray.Length; i++)
            {
                tempArray[i] = array[i + 1];
            }

            array = tempArray;
            return array;
        }
    }
}
