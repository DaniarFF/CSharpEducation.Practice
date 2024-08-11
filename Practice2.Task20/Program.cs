namespace Practice2.Task20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int row = 5; 
            int col = 5; 

            int[,] array = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    array[i, j] = rand.Next(100);
                }
            }

            int diff =  array.Cast<int>().Max() - array.Cast<int>().Min(); // можно линку использовать или переписать без нее? 
        }
    }
}

