using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Создать консольное приложение, которое при старте выводит приветствие, записанное в настройках приложения (application-scope). 
             * Запросить у пользователя имя, возраст и род деятельности, а затем сохранить данные в настройках. 
             * При следующем запуске отобразить эти сведения. 
             * Задать приложению версию и описание.
             */
            if (Properties.Settings.Default.Name == "")
            {
                Console.WriteLine($"{Properties.Resources.Greetings}");
            }
            else
            {
                Console.WriteLine($"{Properties.Resources.Greetings} \nпредыдущий пользователь - {Properties.Settings.Default.Name} \nвозраста - {Properties.Settings.Default.Age} \nзанимающийся - {Properties.Settings.Default.Metier} \nзаходил - {Properties.Settings.Default.Date}");
            }

            Console.WriteLine("\nВведите ваше имя");
            Properties.Settings.Default.Name = Console.ReadLine();

            bool x = false;

            while (!x)
            {
                Console.WriteLine("\nВведите ваш возраст");
                try
                {
                    Properties.Settings.Default.Age = Convert.ToInt32(Console.ReadLine());
                    x = !x;
                }
                catch
                {
                    Console.WriteLine("\nНе было введено число, пожалуйста повторите ввод");
                }
            }

            Console.WriteLine("\nВведите ваш род деятельности");
            Properties.Settings.Default.Metier = Console.ReadLine();

            Properties.Settings.Default.Date = DateTime.Now;
            Properties.Settings.Default.Save();
        }
    }
}
