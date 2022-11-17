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



// int money;
//int appleCount;
//int applePrice = 10;
//bool enogthMoney;

//Console.WriteLine("Going to the dungeon, you decide to restock your supplies.");                            
//Console.Write("You open the bag. How many coins you have? ");
//money = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("You close the bag and head to the market");           
//Console.WriteLine("Welcome to the Sweet Apple. You can bye apples here." +
//   " 1 apple for " + applePrice + " coins");         
//Console.Write("How many apples you need ? ");
//appleCount = Convert.ToInt32(Console.ReadLine());
//enogthMoney = money >= appleCount * applePrice;
//appleCount *= Convert.ToInt32(enogthMoney);
//money -= appleCount * applePrice;
//Console.WriteLine("Have a good day.");
//Console.WriteLine("Now you have " + appleCount + " apples and " + money + " coins");
//Console.ReadLine (); 


/* int rubToUsd = 75;
 int usdToRub = 72;
 float rub;
 float usd;
 string userImput;
 float currencyCount;
 Console.Write(" Сколько у вас рублей ?");
 rub = Convert.ToSingle(Console.ReadLine());
 Console.Write(" Сколько у вас долларов ?");
 usd = Convert.ToSingle(Console.ReadLine());
 Console.WriteLine("Добро пожаловать в обменник:");
 Console.WriteLine("1 - для обмена рублей на доллары");
  Console.WriteLine("2 - для обмена долларов на рубли");
 userImput = Console.ReadLine();
 switch (userImput)
 {
     case "1":
         Console.WriteLine("Обмен рублей в доллары");
         Console.Write("Сколько вы хотите обменять? ");
         currencyCount = Convert.ToSingle(Console.ReadLine());
         if (rub >= currencyCount)
         {
             rub -= currencyCount;
             usd += currencyCount / rubToUsd;                                             
         }
         else 
         {
             Console.WriteLine("Недостаточно средств для выполнения операции");
         }
         break;
     case "2":
         Console.WriteLine("Обмен долларов на рубли");
         Console.Write("Сколько вы хотите обменять? ");
         currencyCount = Convert.ToSingle(Console.ReadLine());
         if (usd >= currencyCount)
         {
             usd -= currencyCount;
             rub += currencyCount * usdToRub;                        
         }
         break;                   
 }
 Console.WriteLine($"Баланс {rub} рублей и {usd} долларов ");
*/



/* string text = Console.ReadLine();
 int length = text.Length;
 int count = 0;
 int bracketDepth = 0;
 if (length == 0)
 {
     Console.WriteLine("Invalid value");
     return;
 }
 for (int i = 0; i < text.Length; i++)
 {
     if (text[i] == Convert.ToChar("("))
     {
         count++;
         bracketDepth--;
         if (bracketDepth <= 0)
         {
             bracketDepth = 0;
         }
     }
     else if (text[i] == Convert.ToChar(")"))
     {
         count--;
         bracketDepth++;
     }
 }
 if (count == 0)
 {
     Console.WriteLine(bracketDepth);
 }
 else if (count > 0 || count < 0)
 {
     Console.WriteLine("Incorrect bracket expression");
 }
*/


/*Задача
Найти наибольший элемент матрицы A(10,10) и записать ноль в те ячейки, где он находятся. Вывести наибольший элемент, исходную и полученную матрицу.
Массив под измененную версию не нужен.
int[,] array = { { 1, 2, 3 }, { 7, 5, 4 }, { 6, 5, 8 } };
int line = 2;
int column = 1;
int sum = 0;
int multiply = array[0, 0];

for (int i = 0; i < array.GetLength(0); i++)
{

    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write($"{array[i, j]} | ");
    }

    Console.WriteLine();
}

for (int j = 0; j < array.GetLength(1); j++)
{
    sum = sum + array[line, j];
}

for (int i = 0; i < array.GetLength(0); i++)
{
    multiply = multiply * array[i, column];
}

Console.WriteLine($"sum = {sum}");
Console.WriteLine($"mult = {multiply}");
*/


/*Задача
Найти наибольший элемент матрицы A(10,10) и записать ноль в те ячейки, где он находятся. Вывести наибольший элемент, исходную и полученную матрицу.
Массив под измененную версию не нужен.


int[,] array = new int[10, 10];
Random random = new Random();
int maxElement = int.MinValue;
int matrixZero = 0;
int minRandomNumber = 1;
int maxRandomNumber = 10;

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = random.Next(minRandomNumber, maxRandomNumber);
        Console.Write($"{array[i, j]} | ");

        if (maxElement < array[i, j])
        {
            maxElement = array[i, j];
        }
    }

    Console.WriteLine();
}

Console.WriteLine("\n***************************\n***************************\n***************************\n");

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] == maxElement)
        {
            array[i, j] = matrixZero;
        }

        Console.Write($"{array[i, j]} | ");
    }

    Console.WriteLine();
}

Console.WriteLine(maxElement);
*/


/*

Задача
Дан одномерный массив целых чисел из 30 элементов.
Найдите все локальные максимумы и вывести их. (Элемент является локальным максимумом, если он не имеет соседей, больших, чем он сам)

Крайние элементы являются локальными максимумами если не имеют соседа большего, чем они сами.

Программа должна работать с массивом любого размера.

Массив всех локальных максимумов не нужен.


int[] array = new int[30];
int arrayLength = array.Length;
int arrayCheckLenth = arrayLength - 1;
Random random = new Random();
int localNumber = 0;
int firsNumber;
int lastNumber;
int randomMin = 0;
int randomMax = 10;
int numberChecker = 1;

for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(randomMin, randomMax);
    Console.Write($"{ array[i]} ");
}

Console.WriteLine();

if (array[0] > array[1])
{
    firsNumber = array[0];
    Console.Write($"{firsNumber} ");
}

for (int i = numberChecker; i < array.Length - 1; i++)
{
    if (array[i] > array[i - numberChecker] && array[i] > array[i + numberChecker])
    {
        localNumber = array[i];
    }

    if (localNumber != 0)
    {
        Console.Write($"{localNumber} ");
    }

    localNumber = 0;
}

if (array[arrayCheckLenth] > array[arrayCheckLenth - numberChecker])
{
    lastNumber = array[arrayCheckLenth];
    Console.Write($"{lastNumber} ");
}

Console.WriteLine();
*/





/*Пользователь вводит числа, и программа их запоминает.
Как только пользователь введёт команду sum, программа выведет сумму всех веденных чисел.

Выход из программы должен происходить только в том случае, если пользователь введет команду exit.
Если введено не sum и не exit, значит это число и его надо добавить в массив.

Программа должна работать на основе расширения массива.

Внимание, нельзя использовать List<T> и Array.Resize


  int[] array = new int[0];            
bool isActive = true;

while (isActive)
{
    Console.WriteLine("Enter the number you want add to the array:");
    Console.WriteLine("Enter 'sum' to sum all array numbers: ");
    Console.WriteLine("enter 'exit' if you want close the programm: \n");
    string userInput = Console.ReadLine();

    if (userInput != "sum" && userInput != "exit")
    {
        int userNumber = Convert.ToInt32(userInput);
        int[] tempArray = new int[array.Length + 1];
        for (int i = 0; i < array.Length; i++)
        {
            tempArray[i] = array[i];
        }  

        tempArray[tempArray.Length - 1] = userNumber;
        array = tempArray;
    }
    else if (userInput == "sum")
    {
        int sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        Console.WriteLine();
        Console.WriteLine($"Sum = {sum}");
    }
    else if (userInput == "exit")
    {
        isActive = false;
    }                                
}  
*/

/*
  Дан массив чисел (минимум 10 чисел). Надо вывести в консоль числа отсортированы, от меньшего до большего.
  Нельзя использовать Array.Sort. Можно найти подходящий алгоритм сортировки и использовать его для задачи.

int[] array = new int[30] { 1, 2, 3, 1, 0, 1, 7, 8, 5, 4, 4, 4, 5, 5, 5, 5, 5, 5, 9, 2, 1, 3, 5, 7, 8, 9, 1, 0, 0, 6 };
int numberRepittingChecker = 1;
int repeatNumber = 0;
int maxRepittingOfNumber = 1;
int numberRepittingCheckerBase = 1;

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
}

Console.WriteLine();

for (int i = 0; i < array.Length - 1; i++)
{

    if (array[i] == array[i + 1])
    {
        numberRepittingChecker++;

        if (numberRepittingChecker > maxRepittingOfNumber)
        {
            maxRepittingOfNumber = numberRepittingChecker;
            repeatNumber = array[i];
        }
    }
    else
    {
        numberRepittingChecker = numberRepittingCheckerBase;
    }
}

Console.WriteLine();
Console.WriteLine($"Max repeat Number = {repeatNumber}. Max repeat Number count = {maxRepittingOfNumber} . ");
  */





/*
Дан массив чисел (минимум 10 чисел). Надо вывести в консоль числа отсортированы, от меньшего до большего.
Нельзя использовать Array.Sort. Можно найти подходящий алгоритм сортировки и использовать его для задачи.
int[] array = { 3, 5, 7, 4, 1, 0,9,2,4,8 };
int arrayLength = array.Length;
int numberCheck = 0;

for(int i = 0; i < arrayLength; i++)
{
    Console.Write($"{array[i]} ");
}

Console.WriteLine();

for(int i = arrayLength-1; i > 0; i--)
{

    for (int j =0; j<i; j++)
    {

        if (array[j] > array[j + 1])
        {
            numberCheck=array[j];
            array[j] = array[j + 1];
            array[j + 1] = numberCheck;
        }
    }
}

Console.WriteLine();

for (int i = 0; i < arrayLength; i++)
{
    Console.Write($"{array[i]} ");
}

Console.WriteLine();              
*/




/*

Дана строка с текстом, используя метод строки String.Split() получить массив слов, которые разделены пробелом в тексте и вывести массив, каждое слово с новой строки.

Console.WriteLine("Enter your text:");
    string line = Console.ReadLine();
    string[] lineArray = line.Split(' ');

    foreach (string word in lineArray)
    {
        Console.WriteLine(word);
    }

    Console.ReadLine();
*/



/*


Дан массив чисел. Нужно его сдвинуть циклически на указанное пользователем значение позиций влево, не используя других массивов. Пример для сдвига один раз: {1, 2, 3, 4} => {2, 3, 4, 1}
 * for(int i = 0; i < array.Length; i++)
{
    Console.Write(array[i]);
}

Console.WriteLine();
Console.WriteLine("Enter how many numbers should be move the list by");
userInput = Console.Read();

for (int i = 0; i < userInput; i++)
{
    for (int j =0; j<array.Length - 1;j++)
    {                                        
            numberChecker = array[j];
            array[j] = array[j + 1];
            array[j + 1] = numberChecker;                                            
    }
}

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i]);
}
*/





/*
  Будет 2 массива: 1) фио 2) должность.

  Описать функцию заполнения массивов досье, функцию форматированного вывода, функцию поиска по фамилии и функцию удаления досье.

  Функция расширяет уже имеющийся массив на 1 и дописывает туда новое значение.

  Программа должна быть с меню, которое содержит пункты:

  1) добавить досье

  2) вывести все досье (в одну строку через “-” фио и должность с порядковым номером в начале)

  3) удалить досье (Массивы уменьшаются на один элемент. Нужны дополнительные проверки, чтобы не возникало ошибок)

  4) поиск по фамилии

  5) выход
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
 */



/*

Разработайте функцию, которая рисует некий бар (Healthbar, Manabar) в определённой позиции. Она также принимает некий закрашенный процент.

При 40% бар выглядит так:

[####______]


 int healf = 5;
int maxHealf = 10;
int mana = 2;
int maxMana = 10;
int stamina = 7;
int maxStamina = 10;

DrawBar(healf, maxHealf, ConsoleColor.Red, 0, '#', '_');
DrawBar(mana, maxMana, ConsoleColor.Blue, 1, '#', '_');
DrawBar(stamina, maxStamina, ConsoleColor.Green, 2, '#', '_');

}

static void DrawBar(int value, int maxValue, ConsoleColor color, int position, char symbol, char symbolFull)
{
ConsoleColor defaultColor = Console.BackgroundColor;
string bar = "";

for (int i = 0; i < value; i++)
{
    bar += symbol;
}

Console.SetCursorPosition(0, position);
Console.Write("[");
Console.BackgroundColor = color;
Console.Write(bar);
Console.BackgroundColor = defaultColor;
bar = "";

for (int i = value; i < maxValue; i++)
{
    bar += symbolFull;
}

Console.Write(bar + "]");              

  */




/*
  Написать функцию, которая запрашивает число у пользователя (с помощью метода Console.ReadLine() ) и пытается сконвертировать его в тип int (с помощью int.TryParse())

Если конвертация не удалась у пользователя запрашивается число повторно до тех пор, пока не будет введено верно. После ввода, который удалось преобразовать в число, число возвращается.

P.S Задача решается с помощью циклов

P.S Также в TryParse используется модфикатор параметра out


   static void Main(string[] args)
{
Console.WriteLine(ReadInt());
}

static int ReadInt()
{
int convert = 0;
bool isConversionDone = false;

while (isConversionDone == false)
{
    Console.Write("Enter number: ");
    string input = Console.ReadLine();
    isConversionDone = int.TryParse(input, out convert);

    if (isConversionDone == false)
    {                    
        Console.WriteLine("The conversion failed. Try again");
    }
}
return convert;
}    
*/
/*
 * Сделать игровую карту с помощью двумерного массива. Сделать функцию рисования карты. Помимо этого, дать пользователю возможность перемещаться по карте и взаимодействовать с элементами (например пользователь не может пройти сквозь стену)

Все элементы являются обычными символами

Console.CursorVisible = false;
bool isPlaying = true;
bool isGameMenuActive = true;
int pacmanXPosition;
int pacmanYPosition;
int pacmanMovementX = 0;
int pacmanMovementY = 1;
string mapName = "map1";

while (isGameMenuActive)
{
    Console.WriteLine("Choose mode: \n 1 - play on the created map. \n 2 - create your own map. \n 3 - close game. \n\n Attention!!! If you want to log out during the game press Esc!!!");
    string userInput = Console.ReadLine();
    Console.Clear();

    if (userInput == "1")
    {
        mapName = "map1";
        isGameMenuActive = false;
    }
    else if (userInput == "2")
    {
        mapName = CreateMap(mapName);
        isGameMenuActive = false;
        Console.CursorVisible = false;

    }
    else if (userInput == "3")
    {
        isGameMenuActive = false;
        isPlaying = false;
    }
    else
    {
        Console.WriteLine("Invalid input.");
    }
}
char[,] map = ReadMap(mapName, out pacmanXPosition, out pacmanYPosition);
DrawMap(map);

while (isPlaying)
{
    Console.SetCursorPosition(pacmanYPosition, pacmanXPosition);
    Console.Write('@');

    if (Console.KeyAvailable)
    {
        ConsoleKeyInfo key = Console.ReadKey(true);
        ControlOfTheGame(key, ref pacmanMovementX, ref pacmanMovementY, ref isPlaying);

    }

    if (map[pacmanXPosition + pacmanMovementX, pacmanYPosition + pacmanMovementY] != '#')
    {
        Move(ref pacmanXPosition, ref pacmanYPosition, pacmanMovementX, pacmanMovementY);

    }
    System.Threading.Thread.Sleep(160);

}
}

static void ControlOfTheGame(ConsoleKeyInfo key, ref int changeXposition, ref int changeYposition, ref bool isPlaying)
{
isPlaying = true;
switch (key.Key)
{
    case ConsoleKey.UpArrow:
        changeXposition = -1;
        changeYposition = 0;
        break;
    case ConsoleKey.DownArrow:
        changeXposition = 1;
        changeYposition = 0;
        break;
    case ConsoleKey.LeftArrow:
        changeXposition = 0;
        changeYposition = -1;
        break;
    case ConsoleKey.RightArrow:
        changeXposition = 0;
        changeYposition = 1;
        break;
    case ConsoleKey.Escape:
        isPlaying = false;
        Console.Clear();
        break;
}

}

static void Move(ref int xPosition, ref int yPosition, int changeXposition, int hangeYposition)
{
Console.SetCursorPosition(yPosition, xPosition);
Console.WriteLine(" ");

xPosition += changeXposition;
yPosition += hangeYposition;

Console.SetCursorPosition(yPosition, xPosition);
Console.Write('@');

}

static void DrawMap(char[,] map)
{
for (int i = 0; i < map.GetLength(0); i++)
{
    for (int j = 0; j < map.GetLength(1); j++)
    {
        Console.Write(map[i, j]);
    }
    Console.WriteLine();
}
}

static char[,] ReadMap(string mapName, out int pacmanXPosition, out int pacmanYPosition)
{
pacmanXPosition = 0;
pacmanYPosition = 0;
string[] newFile = File.ReadAllLines($"maps/{mapName}.txt");
char[,] map = new char[newFile.Length, newFile[0].Length];

for (int i = 0; i < map.GetLength(0); i++)
{
    for (int j = 0; j < map.GetLength(1); j++)
    {
        map[i, j] = newFile[i][j];

        if (map[i, j] == '@')
        {
            pacmanXPosition = i;
            pacmanYPosition = j;
        }
    }
}
return map;
}

static string CreateMap(string mapName)
{
Console.WriteLine("Enter name for your map:");
mapName = Console.ReadLine();
bool isCreating = true;
Console.CursorVisible = true;
Console.WriteLine("Now you are available to create your own map. \n Attention!!! The borders of the map must be equal");
Console.WriteLine("Example:\n Correct:\n\n ##### \n #   # \n # # # \n #   # \n #  ## \n #####");
Console.WriteLine("Incorrect:\n\n ##### \n #   ## \n # # ### \n #  ## \n #####");
Console.WriteLine("Now you can create your map. \n Dont forget to create player sign like this @");
StreamWriter sw = new StreamWriter($"maps/{mapName}.txt");
Console.WriteLine("Enter 1 to create a new line on the map. \nEnter 2 to complete creation map.");

while (isCreating)
{
    string input = Console.ReadLine();

    if (input == "1")
    {
        string userInput = Console.ReadLine();
        sw.WriteLine(userInput);
    }
    else if (input == "2")
    {
        sw.Close();
        isCreating = false;
        Console.Clear();
    }
}
return mapName;
*/

/* 

 Реализуйте функцию Shuffle, которая перемешивает элементы массива в случайном порядке. 

 static void Main(string[] args)
{
int[] array = { 2,4,8,9 };

MixArray(array);
}

static void MixArray(int[] array)
{
Random random = new Random();

for (int i = array.Length - 1; i >= 1; i--)
{
    int randomIndex = random.Next(i + 1);
    int shuffleIndex = array[randomIndex];
    array[randomIndex] = array[i];
    array[i] = shuffleIndex;
}            

}                                       
 */


/*

Создать программу, которая принимает от пользователя слово и выводит его значение. Если такого слова нет, то следует вывести соответствующее сообщение.
 Dictionary<int, string> dictionary = new Dictionary<int, string>()
{
    {1,"A large, round, green fruit that is pink inside with a lot of black seeds" },
    {2, "A hard, round fruit with a green or red skin" },
    {3, "A type of food made with meat, vegetables, or fruit which is covered in pastry and baked" },
    {4, "A valuable, shiny, yellow metal used to make coins and jewellery (symbol Au)" }
};
const string Watermelon = "1";
const string Apple = "2";
const string Pie = "3";
const string Gold = "4";

bool isDictionaryOpen = true;

while (isDictionaryOpen)
{
    Console.WriteLine($"There are 4 words in our dictionary :Watermelon = {Watermelon},Apple = {Apple},Pie = {Pie},Gold = {Gold}.");
    Console.WriteLine("Enter the number of the word you want to know the meaning of. \n0 - Close the dictionary ");
    int userInput = Convert.ToInt32(Console.ReadLine());

    if (dictionary.ContainsKey(userInput))
    {
        Console.WriteLine(dictionary[userInput]);
        Console.Read();
    }
    else if (userInput !=0 )
    {
        Console.WriteLine("Unknown word.");
        Console.Read();
    }

    if (userInput == 0)
    {
        isDictionaryOpen = false;
    }
    else
    {
        Console.WriteLine("Incorrect input.");
        Console.Read();
    }
    Console.Clear();                
}                                       
 */



/*
В массивах вы выполняли задание "Динамический массив"
Используя всё изученное, напишите улучшенную версию динамического массива(не обязательно брать своё старое решение)
Задание нужно, чтобы вы освоились с List и прощупали его преимущество.
Проверка на ввод числа обязательна.

Пользователь вводит числа, и программа их запоминает.
Как только пользователь введёт команду sum, программа выведет сумму всех веденных чисел.

Выход из программы должен происходить только в том случае, если пользователь введет команду exit.
 * List<int> numbers = new List<int>(0);
bool isProgrammOpen = true;            
const string SumList = "sum";
const string Exit = "exit";
int addNumber = 0;

while (isProgrammOpen)
{                
    Console.WriteLine($"Enter numbers whitch you want to add to the list \nEnter {SumList} to sum numbers in the list.\nEnter {Exit} to exit the programm.");
    string userInput = Console.ReadLine();

    if (userInput == Exit)
    {                                                                                                                                           
        isProgrammOpen = false;
    }
    else if (userInput == SumList)
    {
        Sum(numbers);                   
    }
    else if (int.TryParse(userInput, out addNumber))
    {                                                        
            numbers.Add(addNumber);                    
    }

    Console.Clear();                               
}
}

static void Sum(List<int> numbers)
{
int sum = 0;

for (int i = 0; i < numbers.Count; i++)
{
    sum += numbers[i];
}

Console.WriteLine(sum);
Console.Read();
}
*/



/*
 
  В функциях вы выполняли задание "Кадровый учёт"
Используя одну из изученных коллекций, вы смогли бы сильно себе упростить код выполненной программы, ведь у нас данные, это ФИО и позиция.
Поиск в данном задании не нужен.

1) добавить досье

2) вывести все досье (в одну строку через “-” фио и должность)

3) удалить досье

4) выход
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


            /*
Есть два массива строк. Надо их объединить в одну коллекцию, исключив повторения, не используя Linq. Пример: {"1", "2", "1"} + {"3", "2"} => {"1", "2", "3"}

            int[] array1 = { 1, 2, 1, };
            int[] array2 = { 3, 2 };
            List<int> list = new List<int>();

            MergeArray(list, array1.Length, array1);
            MergeArray(list, array2.Length, array2);

            foreach (int number in list)
            {
                Console.WriteLine(number);
            }
        }

        static void MergeArray(List<int> list, int arrayLength, int[] array)
        {
            for (int i = 0; i < arrayLength; i++)
            {
                if (list.Contains(array[i]) == false)
                {
                    list.Add(array[i]);
                }
            }
        }
*/
/*
 * 
        Создать класс игрока, у которого есть поля с его положением в x,y.
Создать класс отрисовщик, с методом, который отрисует игрока.

Попрактиковаться в работе со свойствами.
        static void Main(string[] args)
        {
            Renderer renderer = new Renderer();
            Player player = new Player(10, 3);

            renderer.DrawPlayer(player.XPosition, player.YPosition);
        }
    }

    class Renderer
    {

        public void DrawPlayer(int xPosition, int yPosition, char positionSymbol = ' ')
        {
            Console.WriteLine("Enter symbol that will mark your place");
            char userSymbol = Convert.ToChar(Console.Read());
            Console.SetCursorPosition (xPosition, yPosition);            
            positionSymbol = userSymbol;
            Console.Write(positionSymbol);
        }
    }

    class Player
    {

        public int XPosition { get; private set; }

        public int YPosition { get; private set; }

        public Player(int xPosition, int yPosition)
        {
            XPosition = xPosition;
            YPosition = yPosition;
        }
    }
*/

/*
 * Реализовать базу данных игроков и методы для работы с ней.
У игрока может быть уникальный номер, ник, уровень, флаг – забанен ли он(флаг - bool).
Реализовать возможность добавления игрока, бана игрока по уникальный номеру, разбана игрока по уникальный номеру и удаление игрока.
Создание самой БД не требуется, задание выполняется инструментами, которые вы уже изучили в рамках курса. Но нужен класс, который содержит игроков и её можно назвать "База данных".
const string AddPlayer = "1";
            const string DeletePlayer = "2";
            const string Ban = "3";
            const string UnBan = "4";
            const string ShowPlayers = "5";
            const string Exit = "6";
            Database database = new Database();
            bool isWork = true;
            string userInput;
            Console.WriteLine("Press any button to start.");

            while (isWork)
            {
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine($"{AddPlayer}-Add new player.\n{DeletePlayer}-Delete player \n{Ban}-Ban player \n{UnBan}-Unban player \n{ShowPlayers}-Show all player's \n{Exit}-Exit");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case AddPlayer:
                        database.AddPlayer();
                        break;
                    case DeletePlayer:
                        database.DeletePlayer();
                        break;
                    case Ban:
                        database.BanPlayer();
                        break;
                    case UnBan:
                        database.UnBanPlayer();
                        break;
                    case ShowPlayers:
                        database.ShowData();
                        break;
                    case Exit:
                        isWork = false;
                        Console.WriteLine("Have a nice day.");
                        break;
                }
            }
        }
    }

    class Player
    {
        public string NickName { get; private set; }
        public int Level { get; private set; }
        public bool IsBanned { get; private set; }

        public Player(string nickName, int level, bool isBanned)
        {
            NickName = nickName;
            Level = level;
            IsBanned = isBanned;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Player name -{NickName} \nPlayer level - {Level} ");

            if (IsBanned == true)
            {
                Console.WriteLine("Player is banned");
            }
        }

        public void Ban()
        {
            IsBanned = true;
        }

        public void UnBan()
        {
            IsBanned = false;
        }
    }

    class Database
    {
        private Dictionary<int, Player> _players = new Dictionary<int, Player>();        
        private string _lasyNaming = "Player";
        private int _lasyNamingCount = 1;

        public void AddPlayer()
        {
            Console.WriteLine("Enter player nickname");
            string nickName = Console.ReadLine();

            if (nickName == "")
            {
                nickName = _lasyNaming + _lasyNamingCount;
                _lasyNamingCount++;
            }

            Console.WriteLine("Enter player level:");
            int level = ReadInt();            
            int indexInBase =CreatePlayerIndex();                       
            bool isBanned = false;
            _players.Add(indexInBase, new Player(nickName, level, isBanned));
        }

        public void DeletePlayer()
        {
            DeleteUser();
        }

        public void ShowData()
        {

            if (_players.Count != 0)
            {
                
                foreach (var person in _players)
                {
                    int index = person.Key;
                    _players[index].ShowInfo();
                    Console.WriteLine($"identifier:{index}");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("There is no players in database");
            }
        }

        public void BanPlayer()
        {
            BanUser();                          
        }

        public void UnBanPlayer()
        {
            UnbanUser();                                           
        }

        public int ReadInt()
        {
            bool inCorrectInput = true;
            int input = 0;

            while (inCorrectInput)
            {
                bool isNumber = int.TryParse(Console.ReadLine(), out input);

                if (isNumber == false)
                {
                    string explanation = "Incorrect input. Level must contain only numbers. \nExample: 10";
                    Console.WriteLine(explanation);
                    inCorrectInput = true;
                }
                else
                {
                    inCorrectInput = false;
                }                
            }
            return input;
        }

        public int CreatePlayerIndex()
        {
            bool inCorrectIndex = true;
            Random playerIndex = new Random();
            int minimalPlayerIndex = 1000;
            int maximalPlayerIndex = 10000;
            int indexInBase = playerIndex.Next(minimalPlayerIndex, maximalPlayerIndex);

            while (inCorrectIndex)
            {

                if (_players.ContainsKey(indexInBase))
                {
                    indexInBase = playerIndex.Next(minimalPlayerIndex, maximalPlayerIndex);
                }
                else
                {                    
                    inCorrectIndex = false;
                }
            }
            return indexInBase;
        }

        public void BanUser()
        {
            Console.WriteLine("Enter user identifier");
            bool isNumber = int.TryParse(Console.ReadLine(), out int identifier);

            if (isNumber == true & _players.ContainsKey(identifier) == true)
            {
                
                if (_players[identifier].IsBanned == false)
                {
                    _players[identifier].Ban();
                    Console.WriteLine("Player banned.");
                }
                else
                {
                    Console.WriteLine("Player is already banned.");
                }
            }
            else
            {
                Console.WriteLine("Incorrect input or the player with this number is not in the database.");
            }
        }

        public void UnbanUser()
        {
            Console.WriteLine("Enter user identifier");
            bool isNumber = int.TryParse(Console.ReadLine(), out int identifier);

            if (isNumber == true & _players.ContainsKey(identifier) == true)
            {

                if (_players[identifier].IsBanned == true)
                {
                    _players[identifier].UnBan();
                    Console.WriteLine("Player unbanned.");
                }
                else
                {
                    Console.WriteLine("Player is already unbanned.");
                }
            }
            else
            {
                Console.WriteLine("Incorrect input or the player with this number is not in the database.");
            }
        }

        public void DeleteUser()
        {
            Console.WriteLine("Enter user identifier");
            bool isNumber = int.TryParse(Console.ReadLine(), out int identifier);

            if (isNumber == true && _players.ContainsKey(identifier))
            {
                _players.Remove(identifier);
            }
            else
            {
                Console.WriteLine("Incorrect input or the player with this number is not in the database");
            }
 */


/*
 * Есть колода с картами. Игрок достает карты, пока не решит, что ему хватит карт (может быть как выбор пользователя, так и количество сколько карт надо взять). После выводиться вся информация о вытянутых картах.
Возможные классы: Карта, Колода, Игрок.

const string CommandTakeACard = "1";
            const string CommandShowHand = "2";
            const string CommandEnougth = "3";
            bool isWork = true;
            Pack pack = new Pack();
            Player player = new Player();
            string userInput;

            while (isWork)
            {
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine($"{CommandTakeACard}-Take a card. \n{CommandShowHand}-Show card's in hand. \n{CommandEnougth}-Enougth card's and exit.");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case CommandTakeACard:
                        player.TakeCard(pack);
                        break;
                    case CommandShowHand:
                        player.ShowHand();
                        break;
                    case CommandEnougth:
                        isWork = false;
                        break;
                }
            }

            player.ShowScore();
            player.ShowHand();
        }
    }

    class Player
    {
        private List<Card> _cardsInHand = new List<Card>();

        public void TakeCard(Pack pack)
        {

            if (pack.TryGetCard(out Card card))
            {
                _cardsInHand.Add(card);
                Console.WriteLine("You take 1 card.");
            }
            else
            {
                Console.WriteLine("No cards in pack.");
            }
        }

        public void ShowHand()
        {
            Console.WriteLine("\nYour cards:");

            for (int i = 0; i < _cardsInHand.Count; i++)
            {
                _cardsInHand[i].ShowInfo();
                Console.WriteLine();
            }
        }

        public void ShowScore()
        {
            int score = 0;

            for (int i = 0; i < _cardsInHand.Count; i++)
            {
                score += _cardsInHand[i].Value;
            }

            Console.WriteLine($"\nYour score:{score}");
        }
    }

    class Card
    {
        public string Name { get; private set; }
        public string Suit { get; private set; }
        public int Value { get; private set; }

        public Card(string name, string suit, int value)
        {
            Name = name;
            Suit = suit;
            Value = value;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"CardName - {Name} \nCardSuit - {Suit} \nCardValue - {Value}");
        }
    }

    class Pack
    {
        private List<Card> _cards = new List<Card>();
        private int _minimalNumberCard = 0;
        private int _cardsLeftInPack = 36;

        public Pack()
        {
            AddToPack();
        }

        public bool TryGetCard(out Card card)
        {

            if (_cards.Count > 0)
            {
                card = _cards[GetCardInPackNumber()];
                _cards.Remove(card);
                return true;
            }
            else
            {
                card = null;
                return false;
            }
        }

        private int GetCardInPackNumber()
        {
            Random random = new Random();
            int numberCard = random.Next(_minimalNumberCard, _cardsLeftInPack);
            _cardsLeftInPack--;
            return numberCard;
        }

        enum Suit
        {
            Heart,
            Diamond,
            Club,
            Spade
        }

        private void AddToPack()
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>()
            {
             { "Ace", 11},
             { "Six", 6},
             { "Seven", 7},
             { "Eigth", 8},
             { "Nine", 9},
             { "Ten", 10},
             { "Jack", 2},
             { "Queen", 3},
             { "King", 4}
            };

            for (int i = 0; i < Convert.ToInt32(Suit.Spade + 1); i++)
            {
                string suit = Convert.ToString((Suit)i);
                foreach (var card in dictionary)
                {
                    _cards.Add(new Card(card.Key, suit, card.Value));
                }
            }
 */