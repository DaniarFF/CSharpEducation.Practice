namespace Practice3.Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class Student
    {
        public string name;
        public int age;
        public double AverageScore 
        {
            get 
            { 
                return AverageScore;
            }
            set 
            { 
                if (AverageScore > 6 || AverageScore <= 0) 
                { 
                    throw new Exception("Оценка должна быть от 0 до 5"); 
                }
            } 
        }
        public void GetStudent()
        {
            Console.WriteLine($"Имя: {this.name} Возраст: {this.age} ");
        }
    }
}

