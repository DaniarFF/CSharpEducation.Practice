namespace Practice3.Task4
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
        public Book(string name, string author) 
        { 
            this.name = name;
            this.author = author;
        }
        public Book() { }
    }
}
