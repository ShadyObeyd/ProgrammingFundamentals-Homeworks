using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Globalization;

namespace _10.BookLibraryModification
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public long ISBN { get; set; }
        public decimal Price { get; set; }

        public Book(string title, string author, string publisher, DateTime releaseDate, long isbn, decimal price)
        {
            this.Title = title;
            this.Author = author;
            this.Publisher = publisher;
            this.ReleaseDate = releaseDate;
            this.ISBN = isbn;
            this.Price = price;
        }
    }
    class BookLibraryModification
    {
        static void Main()
        {
            string[] input = File.ReadAllLines("Input.txt").Skip(1).ToArray();

            File.Delete("Output.txt");

            List<Book> books = new List<Book>();

            for (int i = 0; i < input.Length - 1; i++)
            {
                string currentBook = input[i];

                string[] tokens = currentBook.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string title = tokens[0];
                string author = tokens[1];
                string publisher = tokens[2];
                DateTime releaseDate = DateTime.ParseExact(tokens[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                long isbn = long.Parse(tokens[4]);
                decimal price = decimal.Parse(tokens[5]);

                Book book = new Book(title, author, publisher, releaseDate, isbn, price);

                books.Add(book);
            }

            DateTime inputDate = DateTime.ParseExact(input.Last(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            books =
                books
                .Where(d => d.ReleaseDate > inputDate)
                .OrderBy(d => d.ReleaseDate)
                .ThenBy(t => t.Title)
                .ToList();

            foreach (Book book in books)
            {
                string result = $"{book.Title} -> {book.ReleaseDate.ToString("dd.MM.yyyy")}" + Environment.NewLine;

                File.AppendAllText("Output.txt", result);
            }
        }
    }
}
