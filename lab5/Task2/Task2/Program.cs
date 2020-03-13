using System;
using System.Collections.Generic;

namespace Task2
{ 
    public class Program
    {
        static List <BookInLibrary> books = new List<BookInLibrary>();
        
        private static void FindBookByCode(String code) 
        {
            if (books.Count == 0)
            {
                Console.WriteLine("List of books is empty");
                return;
            }
            BookInLibrary book = books.Find(library => code.Equals(library.Code));
            if (book == null)
            {
                Console.WriteLine("There are no book with such code");
                return;
            }
            Console.WriteLine($"Book with code : {code} " + book.ToString());
        }
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Test#1");
            FindBookByCode("code");
            books.Add(new BookInLibrary("Pushkin", "Ruslan and Ludmila", "Ik-1212", 1820, 180, "Poem"));
            books.Add(new BookInLibrary("Taras Schevchenko", "Kobhzar", "Ik-121123", 1828, 150, "Collections of poems"));
            books.Add(new BookInLibrary("Artur konan doyl", "Scherlok Holms", "Ik-1244", 1899, 200, "PLAY"));
            books.Add(new BookInLibrary("TestBook", "TestBook", "Ik-1212", 1111, 111, "TestBook"));
            books.Add(new BookInLibrary("Rowling", "Ruslan and Ludmila", "Ik-1212", 1820, 150, "Poem"));

            Console.WriteLine("Test#1");
            FindBookByCode("Ik-121123");
            
            Console.WriteLine("Test#1");
            FindBookByCode("code");
        }
    }
}