namespace Practice3.Task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public class Book
        {
            public string name;
            public string author;
            public string GetName(Book book) 
            { 
                return name;
            }
        }
    }
}
