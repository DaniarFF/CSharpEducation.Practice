using System.Security.Cryptography;
using System;

namespace Practice2.Task24_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите число от 1 до 7");
            int.TryParse(Console.ReadLine(), out int day);
            Week dayofWeek = (Week)day;

            Console.WriteLine(dayofWeek);
        }
        enum Week 
        {
            Понедельник = 1,
            Вторник,
            Среда,
            Четверг,
            Пятница,
            Суббота,
            Воскресение
        }
    }
}
