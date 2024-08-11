namespace Practice3.Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    struct Point 
    { 
        public int X;
        public int Y;
        public int GetDistance(int x, int y) 
        { 
            return System.Math.Abs(x - y);
        }
    }
}


