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
            books.Clear(); //clears the list so only new books can arrive
            for (int i = 0; i < Generator.Next(5); i++)
            {
                books.Add(new Book()); //adds a new book
            }
            return books;   //returns the new books to be used in the game
        }
    }
}
