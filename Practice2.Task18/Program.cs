using System.Runtime.Serialization.Formatters;

namespace Practice2.Task18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, -2, 3, 4, 5, 6, 7, -8 };

            GetArray(array, out int[] newArray, out int countOfDeleted);
        }

        static void GetArray(int[] array, out int[] newArray, out int countOfDeleted)
        {
            List<int> list = new List<int>();
            int count = 0;
            foreach (int i in array) 
            { 
                if (i >= 0) 
                { 
                    list.Add(i);
                }
                else 
                { 
                    count++;
                }
            }

            int[] result = new int[list.Count()];           
            for (int i = 0; i < result.Length; i++) 
            {
                result[i] = list[i];
            }

            newArray = result;
            countOfDeleted = count;
        }
    }
}

