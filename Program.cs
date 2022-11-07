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
            const string SearchBookCommand = "4";
            const string ExitCommand = "5";
            bool isWork = true;
            Library library = new Library();

            while (isWork)
            {
                Console.Clear();
                Console.WriteLine($"Press: {NewBookCommand} to add new book to the library.\n" +
                    $"Press: {RemoveBookCommand} to remove book from the library.\n" +
                    $"Press: {ShowAllBooksCommand} to show all book in the library.\n" +
                    $"Press: {SearchBookCommand} to search books by name and show.\n" +
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
                    case SearchBookCommand:
                        library.SearchBook();
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

        public void AddBook()
        {
            Console.WriteLine("Enter the book name:");
            string bookName = Console.ReadLine();
            Console.WriteLine("Enter the author:");
            string autor = Console.ReadLine();
            int year = ReadNumber();

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
                Console.WriteLine("Enter book name:");
                string bookName = Console.ReadLine();
                Console.WriteLine("Enter book author:");
                string bookAuthor = Console.ReadLine();
                int bookFound = 0;

                for (int i = 0; i < _books.Count; i++)
                {
                    if (_books[i].Name == bookName && _books[i].Author == bookAuthor)
                    {
                        _books.RemoveAt(i);
                        bookFound++;
                        Console.WriteLine("Complitly delete.");
                        break;
                    }
                }

                if (bookFound == 0)
                {
                    Console.WriteLine("Incorrect book name or author.");
                }
            }
            else
            {
                Console.WriteLine("There is no books in the library");
            }

            Console.Read();
        }

        public void SearchByName()
        {
            Console.WriteLine("Enter book name:");
            string bookName = Console.ReadLine();
            int nameChecker = 0;

            if (_books.Count != 0)
            {
                for (int i = 0; i < _books.Count; i++)
                {
                    if (_books[i].Name == bookName)
                    {
                        _books[i].ShowInfo();
                        Console.WriteLine();
                        nameChecker++;
                    }
                }

                if (nameChecker == 0)
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
        public void SearchByAuthor()
        {
            Console.WriteLine("Enter book author:");
            string bookAuthor = Console.ReadLine();
            int authorChecker = 0;

            if (_books.Count != 0)
            {
                for (int i = 0; i < _books.Count; i++)
                {
                    if (_books[i].Author == bookAuthor)
                    {
                        _books[i].ShowInfo();
                        Console.WriteLine();
                        authorChecker++;
                    }
                }

                if (authorChecker == 0)
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

        public void SearchByYear()
        {
            int year = ReadNumber();
            int yearChecker = 0;

            if (_books.Count != 0)
            {
                for (int i = 0; i < _books.Count; i++)
                {
                    if (_books[i].Year == year)
                    {
                        _books[i].ShowInfo();
                        Console.WriteLine();
                        yearChecker++;
                    }
                }

                if (yearChecker == 0)
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

        public int ReadNumber()
        {
            int input = 0;
            bool isWork = true;

            while (isWork)
            {
                Console.WriteLine("Enter the year when the book was written:");
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

        public void SearchBook()
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
                        SearchByName();
                        isWork = false;
                        break;
                    case SortByAuthorCommand:
                        SearchByAuthor();
                        isWork = false;
                        break;
                    case SortByYearCommand:
                        SearchByYear();
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


