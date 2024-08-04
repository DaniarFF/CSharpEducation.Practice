namespace Practice3.Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public class Car 
        {
            public string brand;
            public void PrintBrand (Car car) 
            { 
                Console.WriteLine(car.brand);
            }
        }
    }
}
