namespace Practice2.Task12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> sentence = new List<string>();  // Попытался сделать так, что бы заранее не было известно, сколько слов введет пользователь.
            string word = "default";

            while (word != String.Empty)
            { 
                Console.WriteLine($"Введите {sentence.Count + 1} слово");
                word = Console.ReadLine();
                sentence.Add(word); 
            }

            Print(sentence);
        }

        static void Print(List<string> list)
        {
            foreach (string i in list)
            {
                Console.Write(i + " ");
            }
        }
    }
}

