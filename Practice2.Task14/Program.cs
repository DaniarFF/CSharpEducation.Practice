namespace Practice2.Task14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = args;    
           
            string[] newArr = GetEmptyArray(arr);

            for (int i = 0; i < newArr.Length; i++) 
            {
                newArr[i] = "jopa";
            }

            Print(newArr);
        }

        static string[] GetEmptyArray(string[] arr)
        {
            string[] array = new string[arr.Length];
            return array;
        }

        static void Print(string[] arr)
        {
            foreach (string word in arr)
            {
                Console.Write(word + " ");
            }
        }
    }   
}
