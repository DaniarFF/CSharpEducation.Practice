namespace Practice2.Task1_
{
    internal class Program
    {

        /// <summary>
        /// Задание 1. Практика 2.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int iter = 0;

            /// Task A 
            for (int i = 1; i < 10; i++) 
            { 
                Console.WriteLine($"a{i}");
            }

            /// Task B 
            while (true) 
            {
                Console.WriteLine($"b{iter++}");
                if (iter == 10) 
                {
                    iter = 0;
                    break;
                }      
            }

            /// Task C
            do
            {
                Console.WriteLine($"c{iter++}");
            }
            while (iter < 10);

            /// Task D 
            Console.WriteLine("Напишите количество слов");
            int.TryParse(Console.ReadLine(), out int count);
            string[] sentence = new string[count];

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Напишите слово:");
                sentence[i] = Console.ReadLine();

                if (i == count - 1)
                {
                    foreach (string word in sentence)
                    {
                        Console.Write(word + " ");
                    }
                    break;
                }
            }

            /// Task E
            iter = 0;
            Console.WriteLine("Напишите количество слов");
            int.TryParse(Console.ReadLine(), out int count1);
            string[] sentence1 = new string[count1];

            while (count1 > 0)
            {
                Console.WriteLine("Напишите слово:");
                sentence1[iter] = Console.ReadLine();
                count1--;
                iter++;

                if (count1 == 0)
                {
                    foreach (string word in sentence1)
                    {
                        Console.Write(word + " ");
                    }
                }
            }

            /// Task F
            iter = 0;
            Console.WriteLine("Напишите количество слов");
            int.TryParse(Console.ReadLine(), out int count2);
            string[] sentence2 = new string[count2];

            do
            {
                Console.WriteLine("Напишите слово:");
                sentence2[iter] = Console.ReadLine();
                count2--;
                iter++;

                if (count2 == 0)
                {
                    foreach (string word in sentence2)
                    {
                        Console.Write(word + " ");
                    }
                }
            }
            while (count2 > 0);
        }
    }
}
