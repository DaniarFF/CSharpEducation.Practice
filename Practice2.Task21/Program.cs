namespace Practice2.Task21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int value = random.Next(100);
            int attempts = 10;

            Console.WriteLine("Угадай число!");
            int userValue = 101;

            while (attempts > 0) 
            {
                Console.WriteLine($"Осталось {attempts} попыток!");
                int.TryParse(Console.ReadLine(), out userValue);

                if (userValue > value)
                {
                    Console.WriteLine("Загаданное число меньше!");
                }
                if (userValue < value)
                {
                    Console.WriteLine("Загаданное число больше!");
                }

                if (userValue == value) 
                { 
                    Console.WriteLine("Молодец!");
                    break; 
                }
                Console.WriteLine("Попробуй еще!");
                attempts--;
            }        
        }
    }
}
