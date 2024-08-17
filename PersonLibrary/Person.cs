namespace PersonLibrary
{
    public class Person
    {
        public string name;
        public int age;

        public void GetPerson() 
        {
            Console.WriteLine($"Имя: {this.name}, Возраст: {this.age} лет");
        }
    }
}
