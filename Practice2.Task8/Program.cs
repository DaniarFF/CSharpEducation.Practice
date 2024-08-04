namespace Practice2.Task8
{
    internal class Program
    {
        /// <summary>
        /// Practice 2. Task8
        /// </summary>
        /// <param name="args"></param>   
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out var a);
            int.TryParse(Console.ReadLine(), out var b);
            int.TryParse(Console.ReadLine(), out var c);

            if((a == b) || (b == c) || (a == c)) 
            {
                a += 5;
                b += 5;
                c += 5;

                Console.WriteLine($"{a} {b} {c}");
            }
            else 
            {
                Console.WriteLine($"Равных нет");
            }
        }
    }
}

