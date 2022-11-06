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
            const string NewBook = "1";
            const string RemoveBook = "2";
            const string ShowAllBooks = "3";
            const string ShowBooksByName = "4";
            const string ShowBooksByAuthor = "5";
            const string ShowBooksByYear = "6";
            const string Exit = "7";
            bool Iswork = true;
            Library books = new Library();

            while (Iswork)
            {
                Console.Clear();
                Console.WriteLine($"Press: {NewBook} to add new book to the library.\n" +
                    $"Press: {RemoveBook} to remove book from the library.\n" +
                    $"Press: {ShowAllBooks} to show all book in the library.\n" +
                    $"Press: {ShowBooksByName} to search books by name and show.\n" +
                    $"Press: {ShowBooksByAuthor} to search books by author and show.\n" +
                    $"Press: {ShowBooksByYear} to search books by year and show.\n" +
                    $"Press: {Exit} to close the programm.\n");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        books.AddBook();
                        break;
                    case "2":
                        books.DeleteBook();
                        break;
                    case "3":
                        books.ShowBooks();
                        break;
                    case "4":
                        books.SearchByName();
                        break;
                    case "5":
                        books.SearchByAuthor();
                        break;
                    case "6":
                        books.SearchByYear();
                        break;
                    case "7":
                        Iswork = false;
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
            Console.WriteLine("Enter the year when the book was written:");
            int year = 0;
            bool result = int.TryParse(Console.ReadLine(), out year);

            if (result == true && bookName != "" && autor != "")
            {
                _books.Add(new Book(bookName, autor, year));
                Console.WriteLine("Book added.");
            }
            else
            {
                Console.WriteLine("Incorrect name,author or year.");
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
            Console.WriteLine("Enter year when book was written:");
            int year;
            bool result = int.TryParse(Console.ReadLine(), out year);

            if (result == true)
            {                
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
            }
            else
            {
                Console.WriteLine("Incorrect input.");
            }

            Console.Read();
        }
    }
}


