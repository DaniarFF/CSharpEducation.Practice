namespace Practice2.Task2
{
    internal class Program
    {
        /// <summary>
        /// Practice 2. Task2
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Введите метры");
            double.TryParse(Console.ReadLine(), out double metres);
            Console.WriteLine($"Километры: {metres / 1000}");

            Console.WriteLine("Введите значение километров");
            double.TryParse(Console.ReadLine(), out double kilo);
            Console.WriteLine($"Сантиметры: {kilo / 100000}");

            Console.WriteLine("Введите значение м/с");
            double.TryParse(Console.ReadLine(), out double speed);
            Console.WriteLine($"Км/ч: {speed * 3,6}");

            Console.WriteLine("Введите значение градусов");
            double.TryParse(Console.ReadLine(), out double grad);
            Console.WriteLine($"Фаренгейт: {((grad * 9) / 5) + 32}");
        }
    }
}

