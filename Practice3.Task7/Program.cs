using System.Reflection.PortableExecutable;

namespace Practice3.Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    enum Month 
    {
        Январь = 1,
        Февраль, 
        Март,
        Апрель, 
        Май,
        Июнь, 
        Июль, 
        Август,
        Сентябрь, 
        Октябрь,
        Ноябрь, 
        Декабрь   
    }

    struct Months 
    { 
        public enum Month { } 

        public int Get(Month month) 
        {
            int i = (int)month;

            switch (i) 
            {
                case 1:
                case 3: 
                case 5:
                case 7:
                case 8:
                case 10:
                case 12: return 31;
                case 2:  return 28;
                default: return 30;               
            }
        }
    }
}
