namespace Practice2.Task17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 4;
            Switch(ref a, ref b);

            Console.WriteLine($"{a}, {b}");
        }

        static void Switch(ref int a, ref int b) 
        {
            int num = a;
            a = b;
            b = num;
        }
    }
}

