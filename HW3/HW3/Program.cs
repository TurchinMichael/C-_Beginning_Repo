using System;

namespace HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1 Написать программу, выводящую элементы двухмерного массива по диагонали.

            var rand = new Random();
            int[,] intArr = new int[10, 10];
            string escape = "";

            for (int i = 0; i < intArr.GetLength(0); i++)
            {
                for (int j = 0; j < intArr.GetLength(1); j++)
                {
                    intArr[i, j] = rand.Next(10); // до 10, чтобы смотрелось красиво

                    escape = escape + " ";

                    Console.WriteLine($"{escape}{intArr[i, j]}");
                }
            }

            #endregion
            Console.Write("\n\n\n");


            #region 2 Написать программу — телефонный справочник — создать двумерный массив 5*2, хранящий список телефонных контактов: первый элемент хранит имя контакта, второй — номер телефона/e-mail.

            string[,] namePhone = new string [2, 5];
            const string nameChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; // шаблон для имен

            for (int j = 0; j < namePhone.GetLength(1); j++) // заполняю имена / телефоны
            {
                for (int i = 0; i < rand.Next(4, 13); i++) // размер имени
                {
                    namePhone[0, j] = namePhone[0, j] + nameChars[rand.Next(0, 26)]; // набираю имя
                }
                namePhone[1, j] = $"+7 {rand.Next(100, 999)} {rand.Next(100, 999)} {rand.Next(1000, 9999)}"; // заполняю телефоны

                Console.WriteLine($"Пользователь № {j+1}\nИмя | {namePhone[0, j]} \nТелефон | {namePhone[1, j]}\n");
            }

            #endregion
            Console.Write("\n\n");
            

            #region 3 Написать программу, выводящую введенную пользователем строку в обратном порядке (olleH вместо Hello).

            string hello = "Hello";

            for (int i = hello.Length-1; i >= 0; i--) // заполняю имена / телефоны
            {
                Console.Write(hello[i]);
            }

            #endregion
            Console.Write("\n\n\n\n");


            #region 4 «Морской бой» — вывести на экран массив 10х10, состоящий из символов X и O, где Х — элементы кораблей, а О — свободные клетки.

            const string shapeShips = "XO"; // шаблон для имен
            string[,] arrShips = new string[10, 10];

            for (int i = 0; i < arrShips.GetLength(0); i++) // размер имени
            {
                for (int j = 0; j < arrShips.GetLength(1); j++) // заполняю имена / телефоны
                {
                    arrShips[i, j] = arrShips[i, j] + shapeShips[rand.Next(2)];

                    Console.Write($"{arrShips[i, j]} ");
                }
                Console.WriteLine();
            }

            #endregion
        }
    }
}