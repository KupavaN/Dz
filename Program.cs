using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string ShowGoodsCommand = "1";
            const string BuyItemCommand = "2";
            const string ShowInventoryCommand = "3";
            const string ExitCommand = "4";
            bool isWork = true;
            Player inventory = new Player();
            Merchant goods = new Merchant();


            while (isWork)
            {
                Console.Clear();
                inventory.ShowGold();
                Console.WriteLine($"Press: {ShowGoodsCommand} to show goods.\n" +
                    $"Press: {BuyItemCommand} to buy item. \n" +
                    $"Press: {ShowInventoryCommand} to check your inventory. \n" +
                    $"Press: {ExitCommand} to close programm.");
                string input = Console.ReadLine();

                switch (input)
                {
                    case ShowGoodsCommand:
                        goods.ShowGoods();
                        break;
                    case BuyItemCommand:
                        inventory.BuyItem(goods);
                        break;
                    case ShowInventoryCommand:
                        inventory.ShowInventory();
                        break;
                    case ExitCommand:
                        isWork = false;
                        break;
                }
            }
        }

        class Item
        {
            public string Name { get; private set; }
            public int Price { get; private set; }
            

            public Item(string name, int price)
            {
                Name = name;
                Price = price;
                
            }

            public void ShowInfo()
            {
                Console.WriteLine($"Item: {Name}. \nPrice: {Price}. \n.");
            }

            public void ShowPlayerInfo()
            {
                Console.WriteLine($"{Name}.");
            }
        }

        class Player
        {
            List<Item> _items = new List<Item>();
            private int _gold = 150;
            private int _goldToPay;

            public void ShowGold()
            {
                Console.WriteLine($"Your gold {_gold}");
            }

            public bool CheckSolvancy(Item item)
            {
                _goldToPay = item.Price;

                if (_gold - _goldToPay >= 0)
                {
                    _gold -= _goldToPay;
                    return true;
                }
                else
                {
                    _goldToPay = 0;
                    return false;
                }
            }

            public void ShowInventory()
            {
                if (_items.Count > 0)
                {
                    Console.WriteLine("Your items:");

                    for (int i = 0; i < _items.Count; i++)
                    {
                        _items[i].ShowPlayerInfo();
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Your inventory is empty.");
                }

                Console.Read();
            }

            public void BuyItem(Merchant merchant)
            {

                if (merchant.TryToGetIndex(out Item item))
                {
                    _items.Add(item);
                    _gold -= item.Price;
                    Console.WriteLine("You bougth item.");
                }
                else
                {
                    Console.WriteLine("No items in shop.");
                }

            }
        }

        class Merchant
        {
            List<Item> _goods = new List<Item>();

            public Merchant()
            {
                _goods.Add(new Item("Mjolnir", 70));
                _goods.Add(new Item("Heal potion", 10));
                _goods.Add(new Item("Mana potion", 15));
                _goods.Add(new Item("Forgotten god's armor", 90));
                _goods.Add(new Item("Ring of Power", 30));
            }

            public void ShowGoods()
            {
                for (int i = 0; i < _goods.Count; i++)
                {
                    Console.WriteLine($"Item index: {_goods.IndexOf(_goods[i]) + 1}");
                    _goods[i].ShowInfo();
                    Console.WriteLine();
                }

                Console.Read();
            }

            public bool TryToGetIndex(out Item item)
            {
                if (_goods.Count > 0)
                {
                    item = _goods[GetItem()];
                    _goods.Remove(item);
                    return true;
                }
                else
                {
                    item = null;
                    return false;
                }
            }

            public int GetItem()
            {
                bool isItemBought = false;
                int index = 0;

                if (_goods.Count != 0)
                {
                    int itemIndex = ReadNumber("Enter the item index:");

                    for (int i = 0; i < _goods.Count; i++)
                    {
                        if (itemIndex == _goods.IndexOf(_goods[i]) + 1)
                        {
                            index = _goods.IndexOf(_goods[i]);
                            isItemBought = true;
                            Console.WriteLine("Good deal.");
                            Console.Read();
                            break;
                        }
                    }

                    if (isItemBought == false)
                    {
                        Console.WriteLine("Incorrect index");
                    }
                }
                else
                {
                    Console.WriteLine("Merchant has no items for sale.");
                }

                return index;
            }

            private int ReadNumber(string text)
            {
                int input = 0;
                bool isWork = true;

                while (isWork)
                {
                    Console.WriteLine(text);
                    bool isCorrect = int.TryParse(Console.ReadLine(), out input);

                    if (isCorrect != true)
                    {
                        Console.WriteLine("Incorrect input.");
                        isWork = true;
                    }
                    else
                    {
                        isWork = false;
                    }
                }

                return input;
            }            
        }
    }
}
