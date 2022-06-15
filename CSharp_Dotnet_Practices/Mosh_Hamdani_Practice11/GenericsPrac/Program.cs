using System;
using System.Collections.Generic;

namespace GenericsPrac
{
    public class GenericDictionary<TKey, TValue>
    {
        public void Add(TKey key, TValue value)
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //var book = new Book {Isbn = "1111", Title = "C# Advance"};

            //var numbers = new List();
            //numbers.Add(10);

            //var books = new BookList();
            //book.Add(book);

            var numbers = new GenericList<int>();
            numbers.Add(10);

            var books = new GenericList<Book>();
            books.Add(new Book());

            var dictionary = new GenericDictionary<string, book>();
            dictionary.Add();

            
        }
    }
}
