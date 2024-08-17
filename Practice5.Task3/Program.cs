namespace Practice5.Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Пес", 2);
            dog.MakeSound();
            Cat cat = new Cat("Дефолтная кошка", 2);
            cat.MakeSound();
            Parrot parrot = new Parrot("Папугей", 2);
            parrot.MakeSound();
            parrot.MakeSound("А я знаю что ты строчишь");
        }
    }
    
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public void Sleep() 
        { 
            Console.WriteLine($"Animal is sleeping");
        }
        public void Eat()
        {
            Console.WriteLine($"Animal is eating");
        }
        public virtual void MakeSound() 
        {
            Console.WriteLine($"Some generic animal sound");
        }
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }   
    }
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Woof!");
        }
        public Dog(string name, int age) : base(name, age) 
        { 
            Console.WriteLine("Собакен has spawned");
        }
    }
    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow!");
        }
        public Cat(string name, int age) : base(name, age)
        {
            Console.WriteLine("Кот has spawned");
        }
    }
    public class Parrot : Animal
    {
        public string Color {  get; set; }
        public new void MakeSound()
        {
            Console.WriteLine("Parrot is talking");
        }
        public void MakeSound(string words) 
        {
            Console.WriteLine($"Попугай сказал :{words}");
        }
        public Parrot(string name, int age) : base(name, age)
        {

        }
    }
}