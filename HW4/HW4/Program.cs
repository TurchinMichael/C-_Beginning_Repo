using System;

namespace HW4
{
    class Program
    {
        enum Season
        {
            Winter,
            Spring,
            Summer,
            Autumn
        }

        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            string patronymic;
            string numbers;

            #region 1 Написать метод GetFullName(string firstName, string lastName, string patronymic), принимающий на вход ФИО в разных аргументах и возвращающий объединённую строку с ФИО.Используя метод, написать программу, выводящую в консоль 3–4 разных ФИО.
            Console.WriteLine("Введите свое имя");
            firstName = Console.ReadLine();

            Console.WriteLine("\nВведите свою фамилию");
            lastName = Console.ReadLine();

            Console.WriteLine("\nВведите свое отчество");
            patronymic = Console.ReadLine();

            Console.WriteLine(GetFullName(firstName, lastName, patronymic)+"\n");

            static string GetFullName(string lastName, string firstName,  string patronymic)
            {
                return $"\nЗдравствуйте, {firstName} {lastName} {patronymic}";
            }
            #endregion

            #region 2 Написать программу, принимающую на вход строку — набор чисел, разделенных пробелом, и возвращающую число — сумму всех чисел в строке.Ввести данные с клавиатуры и вывести результат на экран.
            Console.WriteLine("Введите числа, сумму которых вы хотите получить через пробел");
            numbers = Console.ReadLine();
            Console.WriteLine($"Сумма введенных чисел равна = {GetSumm(numbers)}");

            static int GetSumm (string numbersWithSpace)
            {
                string numberWithoutSpace = "";
                int sum = 0;
                
                for (int i = 0; i < numbersWithSpace.Length; i++)
                {
                    numberWithoutSpace += numbersWithSpace[i];

                    if (numbersWithSpace[i].ToString() == " " || i == numbersWithSpace.Length - 1)
                    {
                        try
                        {
                            sum = sum + Convert.ToInt32(numberWithoutSpace);
                        }
                        catch
                        {
                            Console.WriteLine($"{numbersWithSpace[i]} - не число, введите строку корректно");
                            numbersWithSpace = Console.ReadLine();
                            i = -1;
                        }

                        numberWithoutSpace = "";
                    }
                }
                return sum;
            }
            #endregion

            #region 3 Написать метод по определению времени года. На вход подаётся число – порядковый номер месяца.На выходе — значение из перечисления(enum) — Winter, Spring, Summer, Autumn.Написать метод, принимающий на вход значение из этого перечисления и возвращающий название времени года(зима, весна, лето, осень). Используя эти методы, ввести с клавиатуры номер месяца и вывести название времени года.Если введено некорректное число, вывести в консоль текст «Ошибка: введите число от 1 до 12».
            static Season GetSeason (int numberMonth)
            {
                switch ((numberMonth % 12) / 3) // какой-то гений додумался, чтобы получить номер сезона от номера месяца - остаток от деления месяца на их макс количество, с округлением в большую сторону, потом это делится на 3, и округляется при нулевом разряде
                {
                    case 0:
                        return Season.Winter;
                    case 1:
                        return Season.Spring;
                    case 2:
                        return Season.Summer;
                    default: return Season.Autumn;
                }
            }

            Console.WriteLine("\nВведите номер месяца, сезон которого, вы хотите узнать");

            int numberMonth;
            bool control = true;

            while (control)
            {
                try
                {
                    numberMonth = Convert.ToInt32(Console.ReadLine());

                    if (numberMonth < 0 || numberMonth > 12)
                    {
                        Console.WriteLine($"\nМесяца находсятся в диапозоне 1-12, вы ввели - {numberMonth} введите корректное число");
                    }
                    else
                    {
                        Console.WriteLine($"\nМесяц под номером {numberMonth} относится к сезону - {Enum.GetName(typeof(Season), GetSeason(numberMonth))}"); // GetSeason(numberMonth)
                        control = !control;
                    }
                }
                catch
                {
                    Console.WriteLine("\nНе было введдено число, введите номер месяца корректно");
                }
            }
            #endregion

            #region 4 (*) Написать программу, вычисляющую число Фибоначчи для заданного значения рекурсивным способом.
            control = !control;
            Console.WriteLine("\nВведите число, значение Фибонначчи которого, вы хотите узнать");
            int numberFibonacci;

            static int GetFibonacci (int nowCounter, int previousSum, int numberFibonacci)
            {
                if (numberFibonacci == 0)
                {
                    Console.Write($"{nowCounter}");
                    return nowCounter;
                }

                Console.Write($"{nowCounter},");

                return GetFibonacci(previousSum, nowCounter + previousSum, numberFibonacci - 1);
            }

            while (control)
            {
                try
                {
                    numberFibonacci = Convert.ToInt32(Console.ReadLine());

                    if (numberFibonacci < 0)
                    {
                        Console.WriteLine($"\nДанная программа выводит только поолжительные числа Фибоначчи, вы ввели - {numberFibonacci} введите подходящее число");
                    }
                    else
                    {
                        Console.WriteLine($"\n\nРезультат рассчета числа Фибоначчи для цифры - {numberFibonacci} равняется - {GetFibonacci(0, 1, numberFibonacci)}"); // очень тупо, что приходится "хардкодить" 0 1 на начальные шаги
                        control = !control;
                    }
                }
                catch
                {
                    Console.WriteLine("\nНе было введдено число, введите цифру корректно");
                }
            }
            #endregion
        }
    }
}