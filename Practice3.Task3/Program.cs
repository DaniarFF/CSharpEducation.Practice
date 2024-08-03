namespace Practice3.Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class Calculator 
    { 
        public double Sum(double x, double y) 
        { 
            return x + y;
        }
        public double Sub(double x, double y)
        {
            return x - y;
        }
        public double Multiply(double x, double y)
        {
            return x * y;
        }
        public double Div(double x, double y)
        {
            return x / y;
        }
    }
}
