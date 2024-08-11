namespace Practice2.Task15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3 , 4, 5, 6 };

            Print(GetInvertedArray(array));
        }
        static int[] GetInvertedArray(int[] arr)
        {
            int[] result = new int[arr.Length];
            int j = 0;
            for (int i = arr.Length - 1; i >= 0; i--) 
            { 
                result[j] = arr[i];
                j++;
            }
            return result;
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


