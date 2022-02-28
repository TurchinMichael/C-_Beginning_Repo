using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace HW5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            #region Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл.
            Console.WriteLine("Введите данные");
            string filename = "first_task.txt";
            File.WriteAllText(filename, Console.ReadLine()); // записываем в файл строку
            #endregion

            #region Написать программу, которая при старте дописывает текущее время в файл «startup.txt».
            File.AppendAllText("startup.txt", Environment.NewLine + DateTime.Now.ToString()); // вставляем перенос строки
            #endregion
            


            
            #region Ввести с клавиатуры произвольный набор чисел(0...255) и записать их в бинарный файл.
            Console.WriteLine("Введите через пробел числа, которые хотите ввести в бинарный файл");

            File.WriteAllBytes("bytes.bin", GetByteArrayFromString(Console.ReadLine())); // записываем в файл
            byte[] fromFile = File.ReadAllBytes("bytes.bin"); // читаем из файла

            static byte[] GetByteArrayFromString(string numbersWithSpace)
            {
                string numberWithoutSpace = "";
                int counter = 0;
                byte[] arr = new byte[0];

                for (int i = 0; i < numbersWithSpace.Length; i++)
                {
                    numberWithoutSpace += numbersWithSpace[i]; // заполняем числа введенные без пробела

                    if (numbersWithSpace[i].ToString() == " " || i == numbersWithSpace.Length - 1)
                    {
                        try
                        {
                            counter++;

                            byte[] tmparr = new byte[arr.Length]; // делаю временный массив

                            tmparr = arr; // записываю значения основного массива во временный

                            arr = new byte[counter]; // увеличиваю основной массив на 1 слот

                            arr[counter-1] = Convert.ToByte(numberWithoutSpace); // сую в последний слот основного массива новое значение
                            
                            for (int j = 0; j < tmparr.Length; j++) // записываю все предыдущие слоты из временного массива в основной
                            {
                                arr[j] = tmparr[j];
                            }
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

                return arr; // возвращаем заполненный основной массив
            }
            #endregion
            

            
            #region (*) Сохранить дерево каталогов и файлов по заданному пути в текстовый файл — с рекурсией и без.
            string workDir = @"G:\ExampleDir";

            string[] entries = Directory.GetFileSystemEntries(workDir, "*", SearchOption.AllDirectories);

            File.WriteAllText("fourTask.txt", ""); // записываем в файл строку
            foreach (string i in entries)
                File.AppendAllText("fourTask.txt", Environment.NewLine + i);

            travelDirectory(workDir, 2);


            static string travelDirectory(string beginningPath, int deepLevel)
            {
                if (deepLevel <= 0)
                {
                    return beginningPath; // если уперся в необходимый уровень
                }

                if (Directory.GetDirectories(beginningPath).Length > 0)
                {
                    return travelDirectory(Directory.GetDirectories(beginningPath)[0], deepLevel--); // если нужно идти глубже
                }

                return travelDirectory(beginningPath, 0); // если нет вложенных папок
            }

            #endregion
            



            #region (*) Список задач(ToDo-list):

            /*
             * написать приложение для ввода списка задач;
             * задачу описать классом ToDo с полями Title и IsDone;
             * на старте, если есть файл tasks.json / xml / bin(выбрать формат), загрузить из него массив имеющихся задач и вывести их на экран;
             * если задача выполнена, вывести перед её названием строку «[x]»;
             * вывести порядковый номер для каждой задачи;
             * при вводе пользователем порядкового номера задачи отметить задачу с этим порядковым номером как выполненную;
             * записать актуальный массив задач в файл tasks.json/xml/bin.
             */

             /*
            ToDo toDoOne = new ToDo(false, "Sleep");
            ToDo toDoTwo = new ToDo(false, "Work");
            ToDo toDoThree = new ToDo(false, "Eat");
            ToDo toDoFour = new ToDo(false, "Relax");
            ToDo toDoFive = new ToDo(false, "Play");

            string fileXMLName = "tasks.xml";

            if (File.Exists(fileXMLName))
            {
                StringWriter stringWriter = new StringWriter();
                XmlSerializer serializer = new XmlSerializer(typeof(ToDo));

                serializer.Serialize(stringWriter, toDoOne);
                serializer.Serialize(stringWriter, toDoTwo);
                serializer.Serialize(stringWriter, toDoThree);
                serializer.Serialize(stringWriter, toDoFour);
                serializer.Serialize(stringWriter, toDoFive);
                string xml = stringWriter.ToString();
                File.WriteAllText(fileXMLName, xml); // WriteAllText
            }
            else
            {
                File.Create(fileXMLName);
            }

            
                string xmlText = File.ReadAllText(fileXMLName);
                StringReader stringReader = new StringReader(xmlText);
                XmlSerializer serializer1 = new XmlSerializer(typeof(ToDo));

                ToDo house = (ToDo)serializer1.Deserialize(stringReader);
                
            System.Console.WriteLine(house.Title); //

            System.Console.ReadKey(); //
        }
        */

        #endregion
    }

    public class ToDo
    {
        public ToDo() { } // обязательный конструктор для возможности сериализации в XML

        string title;
        bool isDone;
        
        public string Title
        {
            get 
            { 
                return title; 
            }
            set 
            { 
                title = value; 
            }
        }

        public bool IsDone
        {
            get
            {
                return isDone;
            }
            set
            {
                isDone = value;
            }
        }

        public ToDo (bool isDone, string title)
        {
            Title = title;
            IsDone = isDone;
        }
    }
}


