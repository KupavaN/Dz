using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gold = 0;
            int startGold = 100;
            int healPotion = 0;
            int healPotionPrice = 60;
            int healPotionPower = 50;           
            int manaPotion = 0;
            int manaPotionPrice = 40;
            int manaPotionPower = 30;
            int vitality =0;
            int strength = 0;
            int power = 0;
            int intellence = 0;
            int perkPoints = 0;
            int loop = 0;
            string userInput;
            bool chosenTemplar = false;
            bool chosenHuskarl = false;
            bool chosenCleric = false;
            bool startGame = true;
            bool nowGameStart = true;
            bool playerInTheShop = true;
            bool bossIsAlive = true;
            bool bossStep = true;
            bool isloopComplete = true;
            bool nextLoop = false;

            Console.SetCursorPosition(50, 5);
            Console.WriteLine("Welcome to the dungeon of Sigmarr!!! ");
            Console.Read();
            Console.Clear();
            Console.WriteLine("Choose your class");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Templar - press 1");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Huskarl - press 2");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Cleric - press 3");
            Console.ResetColor();            
            while (startGame == true)
            {
                userInput = Console.ReadLine();


                switch (userInput)
                {

                    case "1":
                        Console.WriteLine("You chose Templar");
                        chosenTemplar = true;
                        vitality += 8;
                        strength += 4;
                        power += 8;
                        intellence += 5;
                        startGame = false;
                        break;
                    case "2":
                        Console.WriteLine("You chose Huskarl");
                        chosenHuskarl = true;
                        vitality += 5;
                        strength += 6;
                        power += 5;
                        intellence += 3;
                        startGame = false;
                        break;
                    case "3":
                        Console.WriteLine("You chose Cleric");
                        chosenCleric = true;
                        vitality += 4;
                        strength += 3;
                        power += 4;
                        intellence += 9;
                        startGame = false;
                        break;
                }
            }
            Console.Read();
            Console.Clear();
            gold = gold + startGold;
            
            while (nowGameStart == true)
            {
                while (playerInTheShop == true)
                {
                    Console.WriteLine("Restock your supplies before the battle");
                    Console.WriteLine($"You have {gold} coins");
                    Console.WriteLine($"You have {healPotion} heal potion");
                    Console.WriteLine($"You have {manaPotion} mana potion");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Heal potion restor {healPotionPower} healf and costs {healPotionPrice} coins");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Mana potion restor {manaPotionPower} mana and costs {manaPotionPrice} coins");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("To buy a heal potion press 1");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("To buy a heal potion press 2");
                    Console.ResetColor();
                    Console.WriteLine("if you are ready to fight press Y");
                    Console.WriteLine("If you want exit (becourse you are pathetic kid) press esc");
                    userInput = Console.ReadLine();
                    Console.Clear();

                    switch (userInput)
                    {
                        case "1":

                            if (gold >= healPotionPrice)
                            {
                                gold -= healPotionPrice;
                                healPotion += 1;
                                Console.WriteLine("You bougt 1 heal potion");                               
                            }
                            else
                            {
                                Console.WriteLine("You don't have enough coins");                               
                            }
                            break;
                        case "2":

                            if (gold >= manaPotionPrice)
                            {
                                gold -= manaPotionPrice;
                                manaPotion += 1;
                                Console.WriteLine("You bougt 1 mana potion");
                            }
                            else
                            {
                                Console.WriteLine("You don't have enough coins");
                            }
                            break;
                        case "Y":
                            playerInTheShop = false;
                            break;
                        case "esc":
                            Console.WriteLine("Have a nice day");
                            nowGameStart = false;
                            playerInTheShop = false;
                            bossIsAlive = false;
                            isloopComplete = false;
                            nextLoop = false;
                            break;
                    }                    
                }

                Random random = new Random();                
                int bossLoop = 10 * loop;
                int bossHealf = random.Next(120, 160) + bossLoop;
                int bossArmour = random.Next(60, 100) + bossLoop;
                int bossDamage = random.Next(30, 40) + bossLoop;
                int healf = vitality * 10;
                int damage = strength * 10;
                int armour = power * 10;
                int mana = intellence * 10;
                int slash = damage;
                bool prayer = false;
                bool isPahomInvocated = false;
                bool odinProtectYou = false;                
                // Templar abilities
                int pray = 15;
                int sacred = 30;
                int sacredPower = damage * 2;
                int blessing = 25;
                int blessingPower = intellence * 12;
                // Huskarl abilities
                int appealToOdin = healf / 2;
                int raiseTheShield = 20;
                int raiseTheShieldPower = 50;
                int rage = 15;
                int ragePower = damage * 2;
                // Cleric abilities
                int mess = 20;
                int messPower = 40;
                int theInvocationOfPahom = 50;
                int pahomDash = 40;
                int pahomDashPower = (intellence - strength) * 20;

                int bossRandomName = random.Next(1, 6);
                string bossName = "";
                int bossRandomSurname = random.Next(1, 6);
                string bossSurname = "";

                    if (bossRandomName == 1)
                    {
                        bossName = "Sigmarras";
                    }
                    else if (bossRandomName == 2)
                    {
                        bossName = "Nikitos";
                    }
                    else if (bossRandomName == 3)
                    {
                        bossName = "Sigmaritos";
                    }
                    else if (bossRandomName == 4)
                    {
                        bossName = "Sigmaruto";
                    }
                    else if (bossRandomName == 5)
                    {
                        bossName = "Sigmarrishe";
                    }

                    if (bossRandomSurname == 1)
                    {
                        bossSurname = "The trap";
                    }
                    else if (bossRandomSurname == 2)
                    {
                        bossSurname = "The most lame";
                    }
                    else if (bossRandomSurname == 3)
                    {
                        bossSurname = "THe faggot";
                    }
                    else if (bossRandomSurname == 4)
                    {
                        bossSurname = "from Konoha";
                    }
                    else if (bossRandomSurname == 5)
                    {
                        bossSurname = "The dick eater";
                    }

                    Console.WriteLine("Prepare to fight");
                    Console.WriteLine($"You will fight against {bossName} {bossSurname}");
                    
                while (bossIsAlive)
                {
                    if (chosenTemplar == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Your healf - {healf}.");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"Your armour - {armour}.");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"Your mana - {mana}.");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine($"Prayer Active {prayer}");
                        Console.WriteLine($"You have {healPotion} heal potion and {manaPotion} mana potion.");
                        Console.ResetColor();
                        Console.WriteLine($"{bossName} {bossSurname} have {bossHealf} healf and {bossArmour} armour.");
                        Console.WriteLine($"{bossName} {bossSurname} damage {bossDamage}");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Your abilities:");
                        Console.WriteLine($"Slash - hurts your enemy to {slash} damage. Press 1");
                        Console.WriteLine($"You need pray if you want cast sacred and blessing.");
                        Console.WriteLine($"Pray costs {pray} mana. Press 2");
                        Console.WriteLine($"Sacred slash - hurts your enemy to {sacredPower} damage.");
                        Console.WriteLine($"Sacred slash cost {sacred} mana. Press 3");
                        Console.WriteLine($"Blessing heal you {blessingPower} healh.");
                        Console.WriteLine($"Blessing cost {blessing} mana. Press 4");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Use heal potion and restor {healPotionPower} healf. Press H ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"Use mana potion and restor {manaPotionPower} mana. Press M ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("If you want exit (becourse you are pathetic kid) press esc");
                        Console.ResetColor();
                    }

                    if (chosenHuskarl == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Your healf - {healf}.");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"Your armour - {armour}.");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"Your mana - {mana}.");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine($"Appeal To Odin Active {odinProtectYou}");
                        Console.WriteLine($"You have {healPotion} heal potion and {manaPotion} mana potion.");
                        Console.ResetColor();
                        Console.WriteLine($"{bossName} {bossSurname} have {bossHealf} healf and {bossArmour} armour.");
                        Console.WriteLine($"{bossName} {bossSurname} damage {bossDamage}");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Your abilities:");
                        Console.WriteLine($"Slash - hurts your enemy to {slash} damage. Press 1");
                        Console.WriteLine($"You need appeal to Odin if you want cast Raise the shield and Rage.");
                        Console.WriteLine($"Appeal to Odin cost {appealToOdin} healf. Press 2");
                        Console.WriteLine($"Raise the shield - restore {raiseTheShieldPower} armour.");
                        Console.WriteLine($"Raise the shield cost {raiseTheShield} mana. Press 3");
                        Console.WriteLine($"Rage - hurts your enemy to {ragePower} damage.");
                        Console.WriteLine($"Rage cost {rage} mana. Press 4");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Use heal potion and restor {healPotionPower} healf. Press H ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"Use mana potion and restor {manaPotionPower} mana. Press M ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("If you want exit (becourse you are pathetic kid) press esc");
                        Console.ResetColor();
                    }

                    if (chosenCleric == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Your healf - {healf}.");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"Your armour - {armour}.");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"Your mana - {mana}.");
                        Console.ForegroundColor = ConsoleColor.Magenta;                        
                        Console.WriteLine($"Pahom summon {isPahomInvocated}");
                        Console.WriteLine($"You have {healPotion} heal potion and {manaPotion} mana potion.");
                        Console.ResetColor();
                        Console.WriteLine($"{bossName} {bossSurname} have {bossHealf} healf and {bossArmour} armour.");
                        Console.WriteLine($"{bossName} {bossSurname} damage {bossDamage}");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Your abilities:");
                        Console.WriteLine($"Slash - hurts your enemy to {slash} damage. Press 1");
                        Console.WriteLine("You need summon Pahom to use Pahom dash.");
                        Console.WriteLine($"Summon Pahom cost {theInvocationOfPahom} mana. Press 2");
                        Console.WriteLine($"Pahom dash - hurts your enemy to {pahomDashPower} damage.");
                        Console.WriteLine($"Pahom dash cost {pahomDash} mana. Press 3");
                        Console.WriteLine($"Mess heal you {messPower} healh.");
                        Console.WriteLine($"Mess cost {mess} mana. Press 4");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Use heal potion and restor {healPotionPower} healf. Press H ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"Use mana potion and restor {manaPotionPower} mana. Press M ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("If you want exit (becourse you are pathetic kid) press esc");
                        Console.ResetColor();
                    }

                    userInput = Console.ReadLine();
                        Console.Clear();

                    switch (userInput)
                    {
                        case "1":
                            Console.WriteLine("You slash!");
                            if ((bossArmour - (slash / 2)) == 0)
                            {
                                bossHealf -= slash;
                                bossStep = true;
                            }
                            if ((bossArmour - (slash / 2)) < 0)
                            {
                                bossHealf -= (slash - bossArmour);
                                bossArmour -= slash;
                                bossStep = true;
                            }
                            if ((bossArmour - (slash/2)) > 0)
                            {
                                bossArmour -= slash / 2;
                                bossStep = true;
                            }
                            break;
                        case "2":
                            if (chosenTemplar)
                            {                                
                                if ((mana - pray) < 0)
                                {
                                    Console.WriteLine("Not enough mana");
                                    bossStep = false;
                                }
                                if (prayer == true)
                                {
                                    Console.WriteLine("You have already pray");
                                    bossStep = false;
                                }
                                if ((mana - pray) >= 0 && prayer == false)
                                {
                                    Console.WriteLine("You pray!");                                
                                    prayer = true;
                                    mana -= pray;
                                    bossStep = true;
                                }
                            }
                            if (chosenHuskarl)
                            {                                
                                if ((healf - appealToOdin) <= 0 )
                                {
                                    Console.WriteLine("No! It will kill you!");
                                    bossStep |= false;
                                }
                                if (odinProtectYou == true)
                                {
                                    Console.WriteLine("Odin has already protected you");
                                    bossStep = false;
                                }
                                if (odinProtectYou == false && (healf - appealToOdin) > 0)
                                {
                                    Console.WriteLine("You appeal to Odin");
                                    odinProtectYou = true;
                                    healf -= appealToOdin;
                                    bossStep = true;
                                }                                              
                            }
                            if (chosenCleric)
                            {
                                if ((mana - theInvocationOfPahom) < 0)
                                {
                                    Console.WriteLine("Not enough mana");
                                    bossStep = false;
                                }
                                if (isPahomInvocated == true)
                                {
                                    Console.WriteLine("You have already summon Pahom");
                                    bossStep = false;
                                }
                                if ((mana - theInvocationOfPahom) >= 0 && isPahomInvocated == false)
                                {
                                    Console.WriteLine("Praise the Pahom!");
                                    isPahomInvocated = true;
                                    mana -= theInvocationOfPahom;
                                    bossStep = true;
                                }
                            }
                            break;
                        case "3":
                            if (chosenTemplar)
                            {


                                if ((mana - sacred) < 0)
                                {
                                    Console.WriteLine("Not enough mana");
                                    bossStep = false;
                                }
                                if (prayer == true && (bossArmour - (sacredPower / 2)) == 0 && (mana - sacred) >= 0)
                                {
                                    Console.WriteLine("You use sacred slash!");
                                    bossHealf -= sacredPower;
                                    mana -= sacred;
                                    bossStep = true;
                                }
                                if (prayer == true && (bossArmour - (sacredPower / 2)) < 0 && (mana - sacred) >= 0)
                                {
                                    Console.WriteLine("You use sacred slash!");
                                    bossHealf -= (sacredPower - bossArmour);
                                    bossArmour -= sacredPower;
                                    mana -= sacred;
                                    bossStep = true;
                                }
                                if (prayer == true && (bossArmour - (sacredPower / 2)) > 0 && (mana - sacred) >= 0)
                                {
                                    Console.WriteLine("You use sacred slash!");
                                    bossArmour -= sacredPower / 2;
                                    mana -= sacred;
                                    bossStep = true;
                                }
                                if (prayer == false)
                                {
                                    Console.WriteLine("First you need to pray");
                                    bossStep = false;
                                }
                            }
                            if (chosenHuskarl)
                            {
                                if (mana - raiseTheShield < 0)
                                {
                                    Console.WriteLine("Not enough mana");
                                    bossStep = false;
                                }
                                if (odinProtectYou == true && (mana - raiseTheShield) >= 0)
                                {
                                    Console.WriteLine("You raise the shield");
                                    armour += raiseTheShieldPower;
                                    mana -= raiseTheShield;
                                    bossStep = true;
                                }
                                if (odinProtectYou == false)
                                {
                                    Console.WriteLine("First you need to appeal to Odin");
                                    bossStep = false;
                                }
                            }
                            if (chosenCleric)
                            {
                                if ((mana - pahomDash) < 0)
                                {
                                    Console.WriteLine("Not enough mana");
                                    bossStep = false;
                                }
                                if (isPahomInvocated == true && (bossArmour - (pahomDashPower / 2)) == 0 && (mana - pahomDash) >= 0)
                                {
                                    Console.WriteLine("Pahom farts and hit your enemy in the face!");
                                    bossHealf -= pahomDashPower;
                                    mana -= pahomDash;
                                    bossStep = true;
                                }
                                if (isPahomInvocated == true && (bossArmour - (pahomDashPower / 2)) < 0 && (mana - pahomDash) >= 0)
                                {
                                    Console.WriteLine("Pahom farts and hit your enemy in the face!");
                                    bossHealf -= (pahomDashPower - bossArmour);
                                    bossArmour -= pahomDashPower;
                                    mana -= pahomDash;
                                    bossStep = true;
                                }
                                if (isPahomInvocated == true && (bossArmour - (pahomDashPower / 2)) > 0 && (mana - pahomDash) >= 0)
                                {
                                    Console.WriteLine("Pahom farts and hit your enemy in the face!");
                                    bossArmour -= pahomDashPower / 2;
                                    mana -= pahomDash;
                                    bossStep = true;
                                }
                                if (isPahomInvocated == false)
                                {
                                    Console.WriteLine("First you need to Summon Pahom");
                                    bossStep = false;
                                }
                            }
                            break;
                        case "4":
                            if (chosenTemplar)
                            {
                                if ((mana - blessing) < 0)
                                {
                                    Console.WriteLine("Not enough mana");
                                    bossStep = false;
                                }
                                if (prayer == true && (mana - blessing) >= 0)
                                {
                                    Console.WriteLine("You are blessing!");
                                    healf += blessingPower;
                                    mana -= blessing;
                                    bossStep = true;
                                }
                                if (prayer == false)
                                {
                                    Console.WriteLine("First you need to pray");
                                    bossStep = false;
                                }                                
                            }
                            if (chosenHuskarl)
                            {
                                if ((mana - rage) < 0)
                                {
                                    Console.WriteLine("Not enough mana");
                                    bossStep = false;
                                }
                                if (odinProtectYou == true && (bossArmour - (ragePower / 2)) == 0 && (mana - rage) >= 0)
                                {
                                    Console.WriteLine("You slash in rage!");
                                    bossHealf -= ragePower;
                                    mana -= rage;
                                    bossStep = true;
                                }
                                if (odinProtectYou == true && (bossArmour - (ragePower / 2)) < 0 && (mana - rage) >= 0)
                                {
                                    Console.WriteLine("You slash in rage!");
                                    bossHealf -= (ragePower - bossArmour);
                                    bossArmour -= ragePower;
                                    mana -= rage;
                                    bossStep = true;
                                }
                                if (odinProtectYou == true && (bossArmour - (ragePower / 2)) > 0 && (mana - rage) >= 0)
                                {
                                    Console.WriteLine("You slash in rage!");
                                    bossArmour -= ragePower / 2;
                                    mana -= rage;
                                    bossStep = true;
                                }
                                if (odinProtectYou == false)
                                {
                                    Console.WriteLine("First you need to appeal to Odin");
                                    bossStep = false;
                                }
                            }
                            if (chosenCleric)
                            {
                                if ((mana - mess) < 0)
                                {
                                    Console.WriteLine("Not enough mana");
                                    bossStep = false;
                                }
                                if (prayer == true && (mana - mess) >= 0)
                                {
                                    Console.WriteLine("You are Messing!");
                                    healf += messPower;
                                    mana -= mess;
                                    bossStep = true;
                                }
                                if (prayer == false)
                                {
                                    Console.WriteLine("First you need to mess");
                                    bossStep = false;
                                }
                            }
                            break;
                        case "H":
                            if (healPotion <= 0)
                            {
                                Console.WriteLine("No potion");
                                bossStep = false;
                            }
                            if (healPotion > 0)
                            {
                                Console.WriteLine("You drink heal potion");
                                healPotion --;
                                healf += healPotionPower;
                                bossStep = true;
                            }                            
                            break;
                        case "M":
                            if (manaPotion <= 0)
                            {
                                Console.WriteLine("No potion");
                                bossStep = false;
                            }
                            if (manaPotion >0)
                            {
                                Console.WriteLine("You drink mana potion");
                                manaPotion--;
                                mana += manaPotionPower;
                                bossStep = true;
                            }                            
                            break;
                        case "esc":
                            Console.WriteLine("Have a nice day");
                            startGame = false;
                            nowGameStart = false;
                            playerInTheShop = false;
                            bossIsAlive = false;
                            isloopComplete = false;
                            nextLoop = false;
                            break;
                        default:
                            Console.WriteLine("Invalid skill");
                            bossStep = false;
                            break;
                    }
                      if (bossHealf <= 0)
                      {
                        Console.Clear();
                        Console.WriteLine("You win");
                        Console.Read();
                        bossIsAlive = false;
                      }
                      if (bossHealf > 0 && userInput != "" && bossStep == true) 
                      {
                        if (armour - (bossDamage / 2) == 0)
                        {
                            armour -= bossDamage / 2;
                        }
                        if (armour - (bossDamage / 2) < 0)
                        {
                            healf -= (bossDamage - armour);
                            armour -= bossDamage;
                        }
                        if (armour - (bossDamage / 2) > 0)
                        {
                            armour -= bossDamage / 2;
                        }
                      }
                      if (healf <= 0)
                      {
                        Console.Clear();
                        startGame = false;
                        nowGameStart = false;
                        playerInTheShop = false;
                        bossIsAlive = false;
                        isloopComplete = false;
                        nextLoop = false;
                        Console.WriteLine("You suck");
                        Console.Read();
                      }
                      if (armour <= 0)
                      {
                         armour = 0;
                      }
                      if (bossArmour <= 0)
                      {
                         bossArmour = 0;
                      }                    
                }
                if (healf > 0)
                {
                    Console.WriteLine("Congratulations! You are moving to a new loop");
                    Console.WriteLine("Lets upgrade your skills ");
                    Console.Read();
                    gold += 40;
                    perkPoints += 2;
                    isloopComplete = true;

                    while (isloopComplete)
                    {
                        Console.WriteLine($"Your vitality - {vitality}");
                        Console.WriteLine($"Your strength - {strength}");
                        Console.WriteLine($"Your power - {power} ");
                        Console.WriteLine($"Your intellence - {intellence}");
                        Console.WriteLine($"You have {perkPoints} points");
                        Console.WriteLine(" + vitality. Press 1");
                        Console.WriteLine(" + strength. Press 2");
                        Console.WriteLine(" + power. Press 3");
                        Console.WriteLine(" + intellence. Press 4");
                        Console.WriteLine("If you ready to the next loop press Y");
                        Console.WriteLine("If you want exit press esc");
                        userInput = Console.ReadLine();
                        Console.Clear();

                        switch (userInput)
                        {
                            case "1":
                                if (perkPoints > 0)
                                {
                                    vitality++;
                                    perkPoints--;
                                }
                                if (perkPoints <= 0)
                                {
                                    Console.WriteLine("no free points");
                                }
                                break;
                            case "2":
                                if (perkPoints > 0)
                                {
                                    strength++;
                                    perkPoints--;
                                }
                                if (perkPoints <= 0)
                                {
                                    Console.WriteLine("no free points");
                                }
                                break;
                            case "3":
                                if (perkPoints > 0)
                                {
                                    power++;
                                    perkPoints--;
                                }
                                if (perkPoints <= 0)
                                {
                                    Console.WriteLine("no free points");
                                }
                                break;
                            case "4":
                                if (perkPoints > 0)
                                {
                                    intellence++;
                                    perkPoints--;
                                }
                                if (perkPoints <= 0)
                                {
                                    Console.WriteLine("no free points");
                                }
                                break;
                            case "Y":
                                Console.WriteLine("good luck");
                                loop++;
                                nextLoop = true;
                                isloopComplete = false;
                                break;
                            case "esc":
                                Console.WriteLine("Have a nice day");
                                startGame = false;
                                nowGameStart = false;
                                playerInTheShop = false;
                                bossIsAlive = false;
                                isloopComplete = false;
                                break;
                        }
                    }
                }
                while (nextLoop == true)
                {
                    startGame = true;
                    nowGameStart = true;
                    playerInTheShop = true;
                    bossIsAlive = true;
                    nextLoop = false;
                }                                
            }
        }
    }
}
