using System.Collections.Generic;
using System;

namespace prov1
{
    public class BookSpawner
    {
        Random Generator = new Random();

        List<Book> books = new List<Book>();

        public List<Book> MakeBook()
        {
            books.Clear();
            for (int i = 0; i < Generator.Next(5); i++)
            {
                books.Add(new Book());
            }
            return books;
        }
    }
}
