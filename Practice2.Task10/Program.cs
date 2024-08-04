namespace Practice2.Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(args[0], out int lenght);
            int.TryParse(args[1], out int num);

            Print(GetArray(lenght, num));
        }

        static int[] GetArray(int lenght, int num)
        {
            int[] arr = new int[lenght];
            for (int i = 0; i < lenght; i++)
            {
                arr[i] = num;
            }
            return arr;
        }

        static void Print(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
        }
    }
}
