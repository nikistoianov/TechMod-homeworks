﻿using System;
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
            
            var result = new SortedDictionary<string, double>();
            foreach (string autor in myLibrary.Books.Select(x => x.Autor).Distinct())
            {
                double sum = myLibrary.Books.Where(x => x.Autor == autor).Sum(x => x.Price);
                result.Add(autor, sum);
            }

            foreach (var item in result.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{item.Key} -> {item.Value:0.00}");
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
