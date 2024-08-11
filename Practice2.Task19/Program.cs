namespace Practice2.Task19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++) 
            {
                array[i] = random.Next(100);
            }

            int diff = array.Max() - array.Min();
            Console.WriteLine(diff);       
        }
    }
}

