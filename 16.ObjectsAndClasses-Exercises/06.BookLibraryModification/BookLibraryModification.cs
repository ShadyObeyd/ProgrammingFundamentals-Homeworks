using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _05.BookLibrary
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public long ISBN { get; set; }
        public double Price { get; set; }

        public Book(string title, string author, string publisher, DateTime releaseDate, long isbn, double price)
        {
            this.Title = title;
            this.Author = author;
            this.Publisher = publisher;
            this.ReleaseDate = releaseDate;
            this.ISBN = isbn;
            this.Price = price;
        }
    }

    class BookLibrary
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<Book> books = new List<Book>();

            for (int i = 0; i < n; i++)
            {
                string[] inputTokens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string title = inputTokens[0];
                string author = inputTokens[1];
                string publisher = inputTokens[2];
                DateTime releaseDate = DateTime.ParseExact(inputTokens[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                long isbn = long.Parse(inputTokens[4]);
                double price = double.Parse(inputTokens[5]);

                Book book = new Book(title, author, publisher, releaseDate, isbn, price);

                books.Add(book);
            }

           DateTime dateInput = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            books = books
                .Where(b => b.ReleaseDate > dateInput)
                .OrderBy(d => d.ReleaseDate)
                .ThenBy(t => t.Title)
                .ToList();

            foreach (Book book in books)
            {

                Console.WriteLine($"{book.Title} -> {book.ReleaseDate.ToString("dd.MM.yyyy")}");
            }
        }
    }
}
