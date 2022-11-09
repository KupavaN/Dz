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
            const string NewBookCommand = "1";
            const string RemoveBookCommand = "2";
            const string ShowAllBooksCommand = "3";
            const string ShowBooksCommand = "4";
            const string ExitCommand = "5";
            bool isWork = true;
            Library library = new Library();

            while (isWork)
            {
                Console.Clear();
                Console.WriteLine($"Press: {NewBookCommand} to add new book to the library.\n" +
                    $"Press: {RemoveBookCommand} to remove book from the library.\n" +
                    $"Press: {ShowAllBooksCommand} to show all book in the library.\n" +
                    $"Press: {ShowBooksCommand} to search books by name and show.\n" +
                    $"Press: {ExitCommand} to close the programm.\n");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case NewBookCommand:
                        library.AddBook();
                        break;
                    case RemoveBookCommand:
                        library.DeleteBook();
                        break;
                    case ShowAllBooksCommand:
                        library.ShowBooks();
                        break;
                    case ShowBooksCommand:
                        library.ShowBooksByParameters();
                        break;
                    case ExitCommand:
                        isWork = false;
                        break;
                    default:
                        Console.WriteLine("Incorrect input\n");
                        break;
                }
            }

            Console.WriteLine("Have a nice day.");
        }
    }
    class Book
    {
        public string Name { get; private set; }
        public string Author { get; private set; }
        public int Year { get; private set; }

        public Book(string name, string author, int year)
        {
            Name = name;
            Author = author;
            Year = year;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Book - {Name} \nAuthor - {Author} \nWas written in - {Year}");
        }
    }

    class Library
    {
        private List<Book> _books = new List<Book>();

        private void ShowBooksByName()
        {
            Console.WriteLine("Enter book name:");
            string bookName = Console.ReadLine();
            bool isNameFound = false;

            if (_books.Count != 0)
            {
                for (int i = 0; i < _books.Count; i++)
                {
                    if (_books[i].Name == bookName)
                    {
                        _books[i].ShowInfo();
                        Console.WriteLine();
                        isNameFound = true;
                    }
                }

                if (isNameFound == false)
                {

                    Console.WriteLine("There is no books with this name.");
                }
            }
            else
            {
                Console.WriteLine("There is no books in the library");
            }

            Console.Read();
        }

        private void ShowBooksByAuthor()
        {
            Console.WriteLine("Enter book author:");
            string bookAuthor = Console.ReadLine();
            bool isAuthorFound = false;

            if (_books.Count != 0)
            {
                for (int i = 0; i < _books.Count; i++)
                {
                    if (_books[i].Author == bookAuthor)
                    {
                        _books[i].ShowInfo();
                        Console.WriteLine();
                        isAuthorFound = true;
                    }
                }

                if (isAuthorFound == false)
                {

                    Console.WriteLine("There is no books written by this author.");
                }
            }
            else
            {
                Console.WriteLine("There is no books in the library");
            }

            Console.Read();
        }

        private void ShowBooksByYear()
        {
            int year = ReadNumber("Enter the year when the book was written:");
            bool isYearCorrect = false;

            if (_books.Count != 0)
            {
                for (int i = 0; i < _books.Count; i++)
                {
                    if (_books[i].Year == year)
                    {
                        _books[i].ShowInfo();
                        Console.WriteLine();
                        isYearCorrect = true;
                    }
                }

                if (isYearCorrect == false)
                {
                    Console.WriteLine("No book written in this year.");
                }
            }
            else
            {
                Console.WriteLine("There is no books in the library");
            }

            Console.Read();
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

        public void AddBook()
        {
            Console.WriteLine("Enter the book name:");
            string bookName = Console.ReadLine();
            Console.WriteLine("Enter the author:");
            string autor = Console.ReadLine();
            int year = ReadNumber("Enter the year when the book was written:");

            if (bookName != "" && autor != "")
            {
                _books.Add(new Book(bookName, autor, year));
                Console.WriteLine("Book added.");
            }
            else
            {
                Console.WriteLine("Incorrect name or author.");
            }

            Console.Read();
        }

        public void ShowBooks()
        {
            if (_books.Count != 0)
            {
                for (int i = 0; i < _books.Count; i++)
                {
                    Console.WriteLine($"Book index: {_books.IndexOf(_books[i])+1}");
                    _books[i].ShowInfo();
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("There is no books in the library");
            }

            Console.Read();
        }

        public void DeleteBook()
        {
            if (_books.Count != 0)
            {                
                int bookIndex = ReadNumber("Enter the book index:");                
                bool isBookFound = false;

                for (int i = 0; i < _books.Count; i++)
                {
                    if (bookIndex== _books.IndexOf(_books[i]) + 1)
                    {
                        _books.RemoveAt(i);
                        isBookFound = true;
                        Console.WriteLine("Complitly delete.");
                        break;
                    }
                }

                if (isBookFound == false)
                {
                    Console.WriteLine("Incorrect book index");
                }
            }
            else
            {
                Console.WriteLine("There is no books in the library");
            }

            Console.Read();
        }                                

        public void ShowBooksByParameters()
        {
            const string SortByNameCommand = "1";
            const string SortByAuthorCommand = "2";
            const string SortByYearCommand = "3";
            const string BackToMenuCommand = "4";
            bool isWork = true;

            while (isWork)
            {
                Console.WriteLine($"Press: {SortByNameCommand} to search all books by name and show.\n" +
                    $"Press: {SortByAuthorCommand} to search all books by author and show.\n" +
                    $"Press: {SortByYearCommand} to search all books by year and show.\n" +
                    $"Press: {BackToMenuCommand} to back to menu.\n");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case SortByNameCommand:
                        ShowBooksByName();
                        isWork = false;
                        break;
                    case SortByAuthorCommand:
                        ShowBooksByAuthor();
                        isWork = false;
                        break;
                    case SortByYearCommand:
                        ShowBooksByYear();
                        isWork = false;
                        break;
                    case BackToMenuCommand:
                        isWork = false;
                        break;
                    default:
                        Console.WriteLine("Incorrect input\n");
                        break;
                }
            }
        }
    }
}


