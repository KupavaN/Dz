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
            string name = "";
            string surname= "";
            string age =("");
            int userPassword;
            string userConsoleColor;
            string userInput = "";
            bool isGameActive = true;
            bool isRegistrarionActive = true;
            bool isVaultSecurityPass = true;
            Random random = new Random();
            int minPassvordCount = 1000;
            int maxPassvordCount = 10000;
            int password = random.Next(minPassvordCount, maxPassvordCount);
            bool incorrectPassword = false;
            bool incorrectConsoleColor = false;
            int secret = random.Next(1,4);
            string secretWord = "";

            if (secret == 1)
            {
                secretWord = "red";
            }
            if (secret == 2)
            {
                secretWord = "blue";
            }
            if (secret == 3)
            {
                secretWord = "green";
            }

            while (isGameActive == true)
            {

                Console.WriteLine("Congratulations! You have won a place in the local vault.");
                Console.WriteLine("Now you only need to register");
                Console.WriteLine("We need some information about you");
                Console.Read();

                while (isRegistrarionActive == true)
                {
                    Console.Clear();
                    Console.WriteLine("Now we know: ");
                    Console.WriteLine($"Your name - {name}");
                    Console.WriteLine($"Your surname - {surname}");
                    Console.WriteLine($"Your age - {age}");
                    Console.WriteLine("To specify your name press 1 ");
                    Console.WriteLine("to specify your surname press 2 ");
                    Console.WriteLine("to specify your age press 3");
                    Console.WriteLine("If you scpecify all information please press 4");
                    Console.WriteLine("If you want escape game enter - esc ");
                    userInput = Console.ReadLine();

                    switch (userInput)
                    {
                        case "1":
                           
                            if (name != "")
                            {
                                Console.WriteLine("You already confirm name");
                                Console.Read();
                            }
                            else
                            {
                                Console.WriteLine("Enter your name");
                                name = Console.ReadLine();
                            }
                            break;
                        case "2":
                            
                            if (surname != "")
                            {
                                Console.WriteLine("You already confirm surname");
                                Console.Read();
                            }
                            else
                            {
                                Console.WriteLine("Enter your surname");
                                surname = Console.ReadLine();
                            }
                            break;
                        case "3":
                           
                            if (age != "")
                            {
                                Console.WriteLine("You already confirm age");
                                Console.Read();
                            }
                            else
                            {
                                Console.WriteLine("Enter your age");
                                age = Console.ReadLine();
                            }
                            break;
                        case "4":
                            
                            if (name != "" && surname != "" && age != "")
                            {
                                Console.WriteLine("Great move on to the next step");
                                isRegistrarionActive = false;
                            }
                            else
                            {
                                Console.WriteLine("You have not provided all the data");
                                Console.Read();
                            }
                            break;
                        case "esc":
                            isGameActive = false;
                            isRegistrarionActive = false;
                            isVaultSecurityPass = false;
                            break;
                    }
                }
               
                if (isGameActive == false)
                {
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Now we will generate password and secret word");
                    Console.WriteLine("Attention! Dont forget it.");
                    Console.WriteLine("You will not be able to get into the storage without this data");
                    Console.WriteLine($"Your password is {password} and your secret word is {secretWord}");
                    Console.Read();
                    Console.Clear();
                }

                while (isVaultSecurityPass == true)
                {
                    Console.Clear();
                    Console.WriteLine("To open the vault door your password must be correct");
                    Console.WriteLine("Also console background must be changed. Try to guess the color");
                    Console.WriteLine($"Password status {incorrectPassword}");
                    Console.WriteLine($"Console background color correct {incorrectConsoleColor}");
                    Console.WriteLine("To enter password press 1");
                    Console.WriteLine("To change console background press 2");
                    Console.WriteLine("If password correct and you prepare to come in vault enter - LetMeIn");
                    Console.WriteLine("If you want escape game enter - esc ");
                    userInput = Console.ReadLine();

                    switch (userInput)
                    {
                        case "1":
                            
                            if (incorrectPassword == true)
                            {
                                Console.WriteLine("You already confirm password");
                                Console.Read();
                            }
                            else
                            {
                                Console.WriteLine("Enter password");
                                userPassword = Convert.ToInt32(Console.ReadLine());
                                
                                if (userPassword == password)
                                {
                                    incorrectPassword = true;
                                }
                                if (userPassword != password)
                                {
                                    Console.WriteLine("Wrong");
                                    Console.Read();
                                }
                            }
                            break;
                        case "2":
                            
                            if (incorrectConsoleColor == true)
                            {
                                Console.WriteLine("You already confirm console background color");
                                Console.Read();
                            }
                            else
                            {
                                Console.WriteLine("Write color and change console background");
                                userConsoleColor = Console.ReadLine();
                                
                                if (userConsoleColor == secretWord)
                                {
                                    incorrectConsoleColor = true;
                                }
                                if (incorrectConsoleColor == true && secret == 1)
                                {
                                    Console.BackgroundColor = ConsoleColor.Red;
                                }
                                
                                if (incorrectConsoleColor == true && secret == 2)
                                {
                                    Console.BackgroundColor = ConsoleColor.Blue;
                                }
                                
                                if (incorrectConsoleColor == true && secret == 3)
                                {
                                    Console.BackgroundColor = ConsoleColor.Green;
                                }
                                
                                if (userConsoleColor != secretWord)
                                {
                                    Console.WriteLine("Incorrect");
                                    Console.Read();
                                }
                            }
                            break;
                        case "LetMeIn":
                            
                            if (incorrectPassword == true && incorrectConsoleColor == true)
                            {
                                Console.WriteLine("Correct. Come in quickly!");
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.Clear();
                                isVaultSecurityPass = false;
                            }
                            break;
                        case "esc":
                            isGameActive = false;
                            isRegistrarionActive = false;
                            isVaultSecurityPass = false;
                            break;
                    }
                }
                
                if (isGameActive == false)
                {
                    Console.WriteLine("Have a nice day");
                }
                else if (isGameActive == true)
                {
                    isRegistrarionActive = true;
                    isVaultSecurityPass = true;
                    Console.WriteLine("You complete the game.");
                    Console.WriteLine("Enter - esc to close the game, or it will restart");                   
                }
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "esc":
                        isGameActive = false;
                        break;
                }
                Console.Clear();                
            }
        }
    }
}
