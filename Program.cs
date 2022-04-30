using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ДЗ-1
            string name = "player";
            byte healf = 150;
            short armor = 400;
            int gold = 100000;
            float jamInLiterJar = 0.8f;
            string npcHello = "Hello adventurer";
            bool armorBroken = armor <= 0;
            bool playerAlive = healf > 0;
            int crystal = 50;
            double inventoryWeight = 45.0;

            
            









            //string str1 = "Hello";
            // string name = "Man!";
            //string str2 = str1 + " " + name;
            // Console.WriteLine(str2);
            //Console.ReadLine();

            // string name;
            // int age;
            // Console.Write("Как Вас зовут?");
            // name = Console.ReadLine();
            // Console.Write("Сколько Вам лет?");
            // age = Convert.ToInt32 (Console.ReadLine());
            // Console.WriteLine(name + " Вы " + age + "летний" + " хуесос");
            // Console. ReadLine();



            //float health;
            //int armor;
            //int damage;

            //Console.Write("Укажите колличество очков жизни от 0 до 100: ");
            //health = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Укажите колличество очков брони от 0-50: ");
            //armor = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Укажите колличество урона от 0 до 30: ");
            //damage = Convert.ToInt32(Console.ReadLine());
            //health -= Convert.ToSingle(damage) / 100 * armor;
            //Console.WriteLine("После атаки равной " + damage + " урона у Вас осталось " + health + " очков жизни");
            //Console.ReadLine();



            int money;
            int appleCount;
            int applePrice = 10;
            bool enogthMoney;

            Console.WriteLine("Going to the dungeon, you decide to restock your supplies.");                            
            Console.Write("You open the bag. How many coins you have? ");
            money = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You close the bag and head to the market");           
            Console.WriteLine("Welcome to the Sweet Apple. You can bye apples here." +
                " 1 apple for " + applePrice + " coins");         
            Console.Write("How many apples you need ? ");
            appleCount = Convert.ToInt32(Console.ReadLine());
            enogthMoney = money >= appleCount * applePrice;
            appleCount *= Convert.ToInt32(enogthMoney);
            money -= appleCount * applePrice;
            Console.WriteLine("Have a good day.");
            Console.WriteLine("Now you have " + appleCount + " apples and " + money + " coins");
            Console.ReadLine (); 




        }
    }
}
