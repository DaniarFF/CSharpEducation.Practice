namespace Practice2.Task6
{
    internal class Program
    {
        /// <summary>
        /// Practice 2. Task6
        /// </summary>
        /// <param name="args"></param>        
        static void Main(string[] args)
        {           
            string word =  args[0];

            char symbol = args[1].ToCharArray()[0];

            int iter = 0;
            foreach (char c in word) 
            { 
                if(c == symbol) {iter++;}
            }

            double result = (iter / Convert.ToDouble(word.Length)) * 100;
            Console.WriteLine($"Процент вхождения символа в строку: {result}%");

            TaskA();
            TaskB();
        }

        static void TaskA() 
        {
            string word = "ананас";
            char symbol = 'а';

            int iter = 0;
            foreach (char c in word)
            {
                if (c == symbol) { iter++; }
            }

            double result = (iter / Convert.ToDouble(word.Length)) * 100;
            Console.WriteLine($"Процент вхождения символа в строку: {result}%");
        }

        static void TaskB()
        {
            Console.WriteLine("Введите строку");
            string word = Console.ReadLine();

            Console.WriteLine("Введите символ");
            char[] symbols = Console.ReadLine().ToCharArray();
            char symbol = symbols[0];

            int iter = 0;
            foreach (char c in word)
            {
                if (c == symbol) { iter++; }
            }

            double result = (iter / Convert.ToDouble(word.Length)) * 100;
            Console.WriteLine($"Процент вхождения символа в строку: {result}%");
        }
    }
}
