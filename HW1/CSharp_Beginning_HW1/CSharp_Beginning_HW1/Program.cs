using System;

namespace CSharp_Beginning_HW1
{
    class Program
    {

        /// <summary>
        /// Программа первого занятия, написать программу, выводящую в консоль текст: «Привет, %имя пользователя%, сегодня %дата%»
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте! Введите имя пользователя ");

           // String tempString = Console.ReadLine(); // можно обойтись без объявления переменной, дальше ведь мы её не используем

            Console.WriteLine($"Привет, {Console.ReadLine()} сегодня - {DateTime.Now}"); // $ активирует возможность в {} скобках использовать переменные, либо запускать функции
            Console.ReadKey();
        }
    }
}
