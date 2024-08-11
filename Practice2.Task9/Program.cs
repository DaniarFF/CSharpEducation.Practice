namespace Practice2.Task9
{
    internal class Program
    {
        /// <summary>
        /// Practice 2. Task9
        /// </summary>
        /// <param name="args"></param>   
        static void Main(string[] args)
        {
            Print(GetArray(5));
        }

        static int[] GetArray(int lenght)
        {
            var rand = new Random();
            int[] arr = new int[lenght];
            for (int i = 0; i < lenght; i++) 
            {
                arr[i] = rand.Next(10);
            }
            return arr;
        }

        static void Print(int[] arr)
        { 
            foreach(int i in arr) 
            { 
                Console.Write(i + " ");
            }
        }
    }
}
