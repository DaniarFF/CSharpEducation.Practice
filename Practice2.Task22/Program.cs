namespace Practice2.Task22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите год!");
            int.TryParse(Console.ReadLine(), out int year);

            if (year % 400 == 0 || year % 4 == 0) 
            { 
                Console.WriteLine("Год високосный"); 
            }
            if (year % 100 != 0)
            {
                Console.WriteLine("Год високосный");
            }
            else { Console.WriteLine("Год невисокосный"); }
        }
    }
}

