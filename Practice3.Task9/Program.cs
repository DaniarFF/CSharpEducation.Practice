namespace Practice3.Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        public class Student
        {
            public string name;
            public int age;
            public void MakeStudentAnonymous(Student student)
            {
                student.name = "Аноним";
            }
        }
    }
}
