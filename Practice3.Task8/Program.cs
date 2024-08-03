namespace Practice3.Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    public struct Rectangle
    {
        public double width, height;

        public double GetSquare(Rectangle rectangle) 
        { 
            return width * height;
        }
    }
}
