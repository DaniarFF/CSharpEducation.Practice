using MathHelperLibrary;
using PersonLibrary;

namespace Practice4.Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 2
            int x = 5;
            int y = 10;
            MathHelper mathHelper = new MathHelper();

            mathHelper.Div(x, y);
            mathHelper.Sum(x, y);
            mathHelper.Sub(x, y);
            mathHelper.Multiply(x, y);
            
            //Task 3 

            Person jeff = new Person() 
            { 
                name = "Jeff",
                age = 35,
            };

            Person ivan = new Person()
            {
                name = "Ivan",
                age = 14
            };

            jeff.GetPerson();
            ivan.GetPerson();
        }
    }
}
