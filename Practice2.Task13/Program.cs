using System;

namespace Practice2.Task13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Print(GetArray(3, 3)); 
        }    

        static int[,] GetArray(int lenght1, int lenght2) 
        { 
            Random random = new Random();
            int[,] array = new int[lenght1, lenght2];
            for (int i = 0; i < lenght1; i++) 
            { 
                for (int j = 0; j < lenght2; j++) 
                {
                    array[i, j] = random.Next(10);
                }
            }
            return array;
        }

        static void Print(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.WriteLine(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
