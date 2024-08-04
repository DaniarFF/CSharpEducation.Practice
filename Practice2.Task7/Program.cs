namespace Practice2.Task7
{
    internal class Program
    {
        /// <summary>
        /// Practice 2. Task7
        /// </summary>
        /// <param name="args"></param>    
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string line = Console.ReadLine();

            TaskA(line);

            TaskB(line);

            TaskC(line);
        }

        static void TaskA(string line)
        {
            Console.WriteLine(line.ToUpper());
        }

        static void TaskB(string line)
        {
            Console.WriteLine(line.ToLower());
        }

        static void TaskC(string line)
        {
            line = line.ToLower();
            string result = line.Substring(0, 1).ToUpper() + line.Substring(1);
            Console.WriteLine(result);
        }
    }
}