using System.Xml.Linq;
using System;

namespace Practice3.Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class Book
    {
        public string name;
        public string author;
        public DateTime Date { get; set; }

        public Book(string name) : this(name, "Неизвестно")
        {}
        public Book(string name, string author)
        {
            this.name = name;
            this.author = author;
        }
        public Book(string name, string author, DateTime date) : this(name, author)
        {
            Date = date;
        }
        public Book() { }
    }
}


