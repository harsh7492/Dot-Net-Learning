using System;
using System.Collections.Generic;
using System.Text;

namespace Day_4_Assignment
{
    class LibraryItem
    {
        private int id;
        private string title;
        public int setID(int id)
        {
            this.id = id;
            return this.id;
        }
        public string setTitle(string t)
        {
            this.title = t;
            return this.title;
        }
    }
    class Book:LibraryItem
    {
        public void DisplayInfo(int id ,string title)
        {
            Console.WriteLine($"Book ID={id}\nBook Name={title}");
        }
    }
    class Magazine: LibraryItem
    {
        public void DisplayInfo(int id,string title)
        {
            Console.WriteLine($"Magazine ID={id}\nMagazine Name={title}");
        }
    }
    internal class Third
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            Magazine magazine = new Magazine();
            book.DisplayInfo(book.setID(1), book.setTitle("Java"));
            magazine.DisplayInfo(magazine.setID(1), magazine.setTitle("Forbes"));
            
            
        }
    }
}
