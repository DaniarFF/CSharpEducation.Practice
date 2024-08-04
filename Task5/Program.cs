namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи первую фразу!");
            string firstPhrase = Console.ReadLine();

            Console.WriteLine("Введи вторую фразу!");
            string secondPhrase = Console.ReadLine();

            Console.WriteLine($"{firstPhrase} {secondPhrase}!");
        }
    }
}
