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
            bool isFightContinue = true;
            int playerHp = 100;
            int playerMp = 100;
            int playerArmor = 100;
            int playerDamage = 45;

            int bossHp = 100;            
            int bossArmor = 100;
            int bossDamage = 50;
            int armorRatio = 2;
           
            int paladinSlash = playerDamage * 3;
            int paladinSlashMpCost = 40;
            bool isPaladinAuraActive = false;
            int paladinAuraRoundTurn = 3;
            int paladinAuraRoundTurnDefault = 3;
            int paladinAuraMpCost = 60;
            int auraHpBonus = 15;
            int auraArmorBonus = 15;
            bool isHolyShieldActive = false;
            int holyShieldBonus = 20;
            int holyShieldHpCost = 30;
            bool bossTurn = false;
          
            while (isFightContinue == true)
            {
                Console.Clear();

                Console.WriteLine("Attention!!!");
                Console.WriteLine("As long as the enemy has armor, your attacks will only deal half the damage. ");
                Console.WriteLine("This rule also works for you");
                Console.WriteLine("*******************************");
                Console.WriteLine($"Paladin's aura active:{isPaladinAuraActive}");

                if (isPaladinAuraActive == true)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"The paladin's aura will be active for {paladinAuraRoundTurn} turns");
                    Console.ResetColor();
                }                               

                Console.WriteLine("*******************************");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Your Hp = {playerHp}");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Your Armor = {playerArmor}");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Your Mp = {playerMp}");
                Console.ResetColor();
                Console.WriteLine($"Your Damage = {playerDamage}");
                Console.WriteLine("*******************************");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Your Enemy Hp = {bossHp}");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Your Enemy Armor = {bossArmor}");
                Console.ResetColor();
                Console.WriteLine($"Your Enemy Damage = {bossDamage}");
                Console.WriteLine("*******************************");
                Console.WriteLine($"Use your abilities to fight");
                Console.WriteLine($"|||");
                Console.WriteLine($"Press '1' to slash your enemy");
                Console.WriteLine($"|||");
                Console.WriteLine($"Press '2' to activate Paladin's slash \n Paladin's slash cost {paladinSlashMpCost} mp and damage your enemy {paladinSlash}");
                Console.WriteLine($"|||");
                Console.WriteLine($"Press '3' to activate Paladin's aura.");
                Console.WriteLine($"Paladin's aura cost {paladinAuraMpCost} mp and works {paladinAuraRoundTurnDefault} turns");
                Console.WriteLine($"Paladin's aura restock {auraHpBonus} hp and {auraArmorBonus} armor in one turn");
                Console.WriteLine($"|||");
                Console.WriteLine($"Press '4' to use Sacred shield");
                Console.WriteLine($"Using the Sacred shield will save you from an enemy attack for 1 turn");
                Console.WriteLine($"It cost {holyShieldHpCost} hp and also restock {holyShieldBonus} mp");
                Console.WriteLine($"Attention!!! You cant use Sacred shield then Paladins aura disabled");
                Console.WriteLine($"|||");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("You slash enemy");

                        if (bossArmor - (playerDamage/ armorRatio) >0)
                        {
                            bossTurn = true;
                            bossArmor -= (playerDamage/ armorRatio);
                        }
                        if (bossArmor - (playerDamage/ armorRatio) < 0)
                        {
                            bossTurn = true;
                            bossHp -= (playerDamage/ armorRatio - bossArmor);
                            bossArmor-= (playerDamage/ armorRatio);
                        }
                        if (bossArmor == 0)
                        {
                            bossTurn = true;
                            bossHp -= playerDamage;
                        }
                        break;
                        case "2":
                        if (playerMp - paladinSlashMpCost < 0)
                        {
                            Console.WriteLine("Not enogth mp");
                            bossTurn = false;
                        }                            

                        if (playerMp-paladinSlashMpCost >=0 && bossArmor - (paladinSlash / armorRatio) > 0)
                        {
                            Console.WriteLine("You use Paladin's slash");
                            playerMp -= paladinSlashMpCost;
                            bossArmor -= paladinSlash / armorRatio;
                            bossTurn = true;
                        }
                        if (playerMp - paladinSlashMpCost >= 0 && bossArmor - (paladinSlash / armorRatio) < 0)
                        {
                            Console.WriteLine("You use Paladin's slash");
                            playerMp -= paladinSlashMpCost;
                            bossHp -= (paladinSlash / armorRatio - bossArmor);
                            bossArmor -= (paladinSlash / armorRatio);
                            bossTurn = true;
                        }
                        if (playerMp - paladinSlashMpCost >= 0 && bossArmor == 0)
                        {
                            Console.WriteLine("You use Paladin's slash");
                            playerMp -= paladinSlashMpCost;
                            bossHp -= paladinSlash;
                            bossTurn = true;
                        }                                               
                        break;
                    case "3":
                        if (isPaladinAuraActive == true)
                        {
                            Console.WriteLine("Paladin's aura is already active");
                            bossTurn = false;
                        }
                        if (isPaladinAuraActive == false && playerMp - paladinAuraMpCost >= 0)
                        {
                            Console.WriteLine("You activate Paladin's aura");
                            playerMp -= paladinAuraMpCost;
                            isPaladinAuraActive = true;
                            bossTurn = false;
                        }
                        break;
                    case "4":
                        if (isPaladinAuraActive == false || playerHp - holyShieldHpCost <= 0)
                        {
                            Console.WriteLine("You cant use Sacred shield");
                            bossTurn = false;
                        }
                        if (isPaladinAuraActive == true && playerHp - holyShieldHpCost > 0)
                        {
                            Console.WriteLine("You use Sacred shield");
                            playerHp -= holyShieldHpCost;
                            playerMp += holyShieldBonus;
                            isHolyShieldActive = true;
                            bossTurn = true;
                        }
                        break;
                }

                if (bossTurn == true && isPaladinAuraActive == true && paladinAuraRoundTurn>0)
                {
                    paladinAuraRoundTurn--;
                    playerHp += auraHpBonus;
                    playerArmor += auraArmorBonus;
                    if(paladinAuraRoundTurn == 0)
                    {
                        paladinAuraRoundTurn = paladinAuraRoundTurnDefault;
                        isPaladinAuraActive=false;
                    }
                }
                if(bossTurn == true && isHolyShieldActive == false && playerArmor - (bossDamage/ armorRatio) > 0)
                {
                    playerArmor -= (bossDamage/ armorRatio);
                }
                if (bossTurn == true && isHolyShieldActive == false && playerArmor - (bossDamage / armorRatio) < 0)
                {
                    playerHp -= (bossDamage / armorRatio - playerArmor);
                    playerArmor -= (bossDamage / armorRatio);
                }
                if (bossTurn == true && isHolyShieldActive == false && playerArmor == 0)
                {
                    playerHp -= bossDamage;
                }

                if (bossArmor<0)
                {
                    bossArmor = 0;
                }
                if (playerArmor<0)
                {
                    playerArmor = 0;
                }
                if (isHolyShieldActive == true)
                {
                    isHolyShieldActive = false;
                }

                if (bossHp <= 0 || playerHp <= 0)
                {                    
                    isFightContinue = false;
                }                
            }
            if (bossHp <= 0)
            {
                Console.Clear();
                Console.WriteLine("You win");                
            }

            if (playerHp <= 0)
            {
                Console.Clear();
                Console.WriteLine("You lose");                                
            }
            Console.ReadLine();
        }
    }
}
