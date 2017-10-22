using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    class Program
    {
        static void Main()
        {
            Library myLibrary = new Library(){Name = "My books", Books = new List<Book>()};
            
            int nums = int.Parse(Console.ReadLine());
            for (int i = 0; i < nums; i++)
            {
                myLibrary.Books.Add(ConvertInputToBook(Console.ReadLine()));
            }

            foreach (Book book in myLibrary.Books.OrderByDescending(x => x.Autor).Distinct())
            {
                Console.WriteLine(book.Autor);
            }
        }

        private static Book ConvertInputToBook(string inputString)
        {
            string[] arr = inputString.Split();
            Book book = new Book()
            {
                Title = arr[0], Autor = arr[1], Publisher = arr[2], ReleaseDate = DateTime.ParseExact(arr[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                ISBN = int.Parse(arr[4]), Price = double.Parse(arr[5])
            };
            return book;
        }
    }

    public class Book
    {
        public string Title { get; set; }
        public string Autor { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int ISBN { get; set; }
        public double Price { get; set; }
    }

    public class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }
}
