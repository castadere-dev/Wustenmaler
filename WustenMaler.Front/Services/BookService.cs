using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using WustenMaler.Front.Interfaces;


namespace WustenMaler.Front.Services
{
    public class BookService : IBookService
    {
        private List<Book> _bookContext = new List<Book>();

        /// <summary>
        /// Constructor
        /// </summary>
        public BookService()
        {
            var books = new List<Book>
            {
                new Book {BookId = 1, Author = "Kate Atkinson", Title = "A God In Ruins", Price = 7.99m },
                new Book {BookId = 2, Author = "Renee Knight", Title = "Disclaimer", Price = 7.99m },
                new Book {BookId = 3, Author = "James Patterson", Title = "Private Sydney", Price = 7.99m },
                new Book {BookId = 4, Author = "Michael Punke", Title = "The Revenant", Price = 7.99m },
                new Book {BookId = 5, Author = "Celia Imrie", Title = "Not Quite Nice", Price = 7.99m },
                new Book {BookId = 6, Author = "Harlan Coben", Title = "The Stranger", Price = 7.99m },
                new Book {BookId = 7, Author = "Emma Donoghue", Title = "Room", Price = 8.99m },
                new Book {BookId = 8, Author = "Laura Barnett", Title = "The Versions of Us", Price = 7.99m }
            };

            _bookContext.AddRange(books);
        }


        public IEnumerable<Book> MostPopular(int numberToTake)
        {

            return _bookContext.OrderBy(b => b.BookId).Take(numberToTake);
        }

    }

    public class Book
    {
        public int BookId { get; set;}
        public string Author { get; set;}
        public string Title { get; set;}
        public decimal Price { get; set;}
    }
    
}
