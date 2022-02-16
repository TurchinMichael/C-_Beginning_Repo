using System;
using System.Diagnostics;

namespace HW6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Написать консольное приложение Task Manager, которое выводит на экран запущенные процессы и позволяет завершить указанный процесс. 
             * Предусмотреть возможность завершения процессов с помощью указания его ID или имени процесса. 
             * В качестве примера можно использовать консольные утилиты Windows tasklist и taskkill.
             */
            Process[] processes = Process.GetProcesses();

            for (int i = 0; i < processes.Length; i++)
            {
                Console.WriteLine($"{i} - {processes[i].ProcessName}"); // раз уж мы всё равно выводим список, почему бы им не поспользоваться Process.GetProcessById решил не использовать
            }

            Console.WriteLine($"Введите номер, или наименование процесса, который хотите завершить");

            string s = Console.ReadLine();

            try // проверка на номер процесса
            {
                int z = Convert.ToInt32(s);

                if (z >= 0 && processes.Length >= z)
                { 
                    processes[Convert.ToInt32(s)].Kill(); // проверка на вхождение в массив процессов
                }
                else
                {
                    Console.WriteLine($"Данного номера процесса нет");
                }
            }
            catch (Exception ex) when (ex.GetType() == typeof(FormatException)) // проверка на наименование процесса
            {
                foreach (Process proc in Process.GetProcessesByName(s)) // try не нужен, он встроен в метод, поиск происходит за нас, вообще этот метод делает всю работу за нас
                {
                    proc.Kill();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}