namespace Practice2.Task3
{
    internal class Program
    {
        /// <summary>
        /// Practice 2. Task3
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите a");
                double.TryParse(Console.ReadLine(), out double a);

                Console.WriteLine("Введите b");
                double.TryParse(Console.ReadLine(), out double b);

                Console.WriteLine("Введите f");
                double.TryParse(Console.ReadLine(), out double f);

                double result = (a + b) - (f / a) + f * a * a - (a + b);
                Console.WriteLine(result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка деленмя на ноль");
            }
            
        }
    }
}
