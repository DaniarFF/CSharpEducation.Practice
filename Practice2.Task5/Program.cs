namespace Practice2.Task5
{
    internal class Program
    {
        /// <summary>
        /// Practice 2. Task5
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число a");
            int.TryParse(Console.ReadLine(), out int a);

            Console.WriteLine("Введите число б");
            int.TryParse(Console.ReadLine(), out int b);

            if (a == b) { Console.WriteLine("Числа равны"); }
            if (b > a) { Console.WriteLine($"Второе число больше первого на {b - a}"); }
            else { Console.WriteLine($"Первое число больше второго на {a - b}");}
        }
    }

}
