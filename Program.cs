﻿using System;
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

            string[] arrayFio = { "Ivanov Petr Sergeevich", "Petrov Sergei ivanovich", "Sergeev Ivan Petrovich" };
            string[] arrayRole = { "doctor", "manager", "builder" };
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
                            AddDossier(ref arrayFio, ref arrayRole);
                        }
                        break;
                    case "2":
                        {
                            ShowDossier(ref arrayFio, ref arrayRole);
                        }
                        break;
                    case "3":
                        {
                            DeleteDossier(ref arrayFio, ref arrayRole);
                        }
                        break;
                    case "4":
                        {
                            SearchDossier(ref arrayFio, ref arrayRole);
                        }
                        break;
                    case "5":
                        isWork = false;
                        break;
                }
            }
        }
        static void AddDossier(ref string[] arrayFio, ref string[] arrayRole)
        {
            Console.WriteLine("Enter Fio");
            string userInputFio = Console.ReadLine();            
                string userNumberFio = userInputFio;
                string[] tempArrayFio = new string[arrayFio.Length + 1];

                for (int i = 0; i < arrayFio.Length; i++)
                {
                    tempArrayFio[i] = arrayFio[i];
                }
                tempArrayFio[tempArrayFio.Length - 1] = Convert.ToString(userNumberFio);
                arrayFio = tempArrayFio;
            
            Console.WriteLine("Enter Role");
            string userInputRole = Console.ReadLine();            
                string userNumberRole =userInputRole;
                string[] tempArrayRole = new string[arrayRole.Length + 1];

                for (int i = 0; i < arrayRole.Length; i++)
                {
                    tempArrayRole[i] = arrayRole[i];
                }
                tempArrayRole[tempArrayRole.Length - 1] = Convert.ToString(userNumberRole);
                arrayRole = tempArrayRole;            
        }
        static void ShowDossier(ref string[] arrayFio, ref string[] arrayRole)
        {
            int dosserNumber = 1;

            for (int i = 0; i < arrayFio.Length; i++)
            {
                Console.Write(dosserNumber + " " + arrayFio[i] + " - " + arrayRole[i] + ". ");
                dosserNumber++;
            }
            Console.WriteLine();
            Console.ReadKey();

        }
        static void SearchDossier(ref string[] arrayFio, ref string[] arrayRole)
        {
            string surname;
            bool isDossierFind = false;
            Console.WriteLine("Enter the surname to find dossier.");
            surname = Console.ReadLine();
            int dosserNumber = 0;

            if (arrayFio.Length == 0)
            {
                Console.WriteLine("There is no dossier in the database.");
            }

            if (arrayFio.Length != 0)
            {
                for (int i = 0; i < arrayFio.Length; i++)
                {
                    dosserNumber++;

                    if (surname.ToLower() == arrayFio[i].ToLower())
                    {
                        Console.WriteLine(dosserNumber + " " + arrayFio[i] + "-" + arrayRole[i] + ". ");
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
        public static void DeleteDossier(ref string[] arrayFio, ref string[] arrayRole)
        {
            string indexToDelete;           
            Console.WriteLine("select the number of the dossier to be deleted");
            indexToDelete = Console.ReadLine();
            int indexChecker = Convert.ToInt32(indexToDelete);

            if (indexChecker<=arrayFio.Length)
            {
                for (int i = 0; i < indexChecker; i++)
                {
                    for (int j = 0; j < arrayFio.Length - 1; j++)
                    {
                        indexToDelete = arrayFio[j];
                        arrayFio[j] = arrayFio[j+1];
                        arrayFio[j+1] = indexToDelete;                        
                    }

                    for (int k = 0; k < arrayFio.Length - 1; k++)
                    {
                        indexToDelete = arrayRole[k];
                        arrayRole[k] = arrayRole[k+1];
                        arrayRole[k+1] = indexToDelete;
                    }
                }
                Array.Resize(ref arrayFio, arrayFio.Length-1);
                Array.Resize(ref arrayRole, arrayRole.Length-1);
            }

            else if(arrayFio.Length == 0)
            {
                Console.WriteLine("No dossier found in database");
            }
            else
            {
                Console.WriteLine("There is no dossier with this number");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
