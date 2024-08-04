namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstLeg;
            double secondleg;
            double hypotenuse;
            
            firstLeg = 3;
            secondleg = 2;
            Console.WriteLine($"A: {Math.Sqrt(Math.Pow(firstLeg, 2) + Math.Pow(secondleg, 2))}");

            firstLeg = 3;
            hypotenuse = 5;
            Console.WriteLine($"B: {Math.Sqrt(Math.Pow(hypotenuse, 2) - Math.Pow(firstLeg, 2))}");
        }
    }
}
