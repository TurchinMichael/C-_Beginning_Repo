using System;

namespace CSharp_Beginning_HW2
{
    class Program
    {
        [Flags]
        enum officesSchedule
        {
            Monday      = 0b0_000_001,
            Tuesday     = 0b0_000_010,
            Wednesday   = 0b0_000_100,
            Thursday    = 0b0_001_000,
            Friday      = 0b0_010_000,
            Saturday    = 0b0_100_000,
            Sunday      = 0b1_000_000,
            full        = 0b0_111_111
        }

        [Flags]
        enum month
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

        static void Main(string[] args)
        {
            #region periphery
            bool bcounter = false; // флаг повтора цикла

            float min; // миниамльная температура
            float max;  // максимальаня температура
            float average = 0f; // среднесуточная температура
            int numberMonth = 0; // номер месяца

            void reverce() // смена состояния
            {
                bcounter = !bcounter;
            }


            #region 5 Если пользователь указал месяц из зимнего периода, а средняя температура > 0, вывести сообщение «Дождливая зима».
            // Проверка на повышенную для зимы температуру
            void rainyWinter(float i)
            {
                if (i >= 0)
                    Console.WriteLine("Дождливая зима");
            }
            #endregion 5
            #endregion periphery


            #region 1 Запросить у пользователя минимальную и максимальную температуру за сутки и вывести среднесуточную температуру.
            while (!bcounter)
            {
                try
                {
                    Console.WriteLine("\nВведите минимальную температуру в сутки");
                    min = float.Parse(Console.ReadLine()); //  double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите максимальную температуру в сутки");
                    max = float.Parse(Console.ReadLine()); // double.Parse(Console.ReadLine());

                    average = (min + max) / 2;

                    Console.WriteLine($"Среднесуточная температура = {average}");
                    reverce();
                }
                catch
                {
                    Console.WriteLine("Не был введен номер месяца.  Введите корректное число");
                }
            }
            reverce();
            #endregion 1


            #region 2 VAR 1 Запросить у пользователя порядковый номер текущего месяца и вывести его название.
            Console.WriteLine("\nВведите номер любого месяца");
            
            while (!bcounter)
            {
                try
                {
                    numberMonth = int.Parse(Console.ReadLine());

                        switch (numberMonth)
                        {
                            case 1:
                                Console.WriteLine(Enum.GetName(typeof(month), numberMonth));
                                rainyWinter(average);
                                break;
                            case 2:
                                Console.WriteLine(Enum.GetName(typeof(month), numberMonth));
                                rainyWinter(average);
                                break;
                            case 3:
                                Console.WriteLine(Enum.GetName(typeof(month), numberMonth));
                                break;
                            case 4:
                                Console.WriteLine(Enum.GetName(typeof(month), numberMonth));
                                break;
                            case 5:
                                Console.WriteLine(Enum.GetName(typeof(month), numberMonth));
                                break;
                            case 6:
                                Console.WriteLine(Enum.GetName(typeof(month), numberMonth));
                                break;
                            case 7:
                                Console.WriteLine(Enum.GetName(typeof(month), numberMonth));
                                break;
                            case 8:
                                Console.WriteLine(Enum.GetName(typeof(month), numberMonth));
                                break;
                            case 9:
                                Console.WriteLine(Enum.GetName(typeof(month), numberMonth));
                                break;
                            case 10:
                                Console.WriteLine(Enum.GetName(typeof(month), numberMonth));
                                break;
                            case 11:
                                Console.WriteLine(Enum.GetName(typeof(month), numberMonth));
                                break;
                            case 12:
                                Console.WriteLine(Enum.GetName(typeof(month), numberMonth));
                                rainyWinter(average);
                                break;
                            default:
                                Console.WriteLine("\nМесяца находятся в диапазоне 1-12. Введите подходящее число");
                                reverce(); // лучше не придумалось :С
                            break;
                    }
                    reverce();
                }
                catch
                {
                    Console.WriteLine("\nНе был введен номер месяца. Введите корректное число");
                }
            }
            reverce();
            #endregion 2 VAR 1


            #region 2 VAR 2 Запросить у пользователя порядковый номер текущего месяца и вывести его название.
            Console.WriteLine("\nВведите номер любого месяца");

            while (!bcounter)
            {
                try
                {
                    numberMonth = int.Parse(Console.ReadLine());                    

                    if (Enum.IsDefined(typeof(month), numberMonth))
                    {
                        Console.WriteLine(Enum.GetName(typeof(month), numberMonth));

                        if (numberMonth == 1 || numberMonth == 2 || numberMonth == 12)
                        {
                            rainyWinter(average);
                        }

                        reverce();
                    }
                    else
                    {
                        Console.WriteLine("\nМесяца находятся в диапазоне 1-12. Введите подходящее число");
                    }
                }
                catch
                {
                    Console.WriteLine("\nНе был введен номер месяца");
                }
            }
            reverce();
            #endregion 2 VAR 2
            

            #region 3 Определить, является ли введённое пользователем число чётным.
            while (!bcounter)
            {
                try
                {
                    Console.WriteLine($"{(numberMonth% 2 == 0 ? "Чётное" : "Нечетное")}");
                    reverce();
                }
                catch
                {
                    Console.WriteLine("Не было введено число");
                }
            }
            reverce();
            #endregion 3
            

            #region 4 найдите любой чек, либо фотографию этого чека в интернете и схематично нарисуйте его в консоли, только за место динамических, 
            string storeName = "Детский Мир", firstPurchase = "Набор Attivio Я делаю мыло", secondPurchase = "Набор Attivio Я делаю свечи";
            int cashКegister = 7403;
            float firstPurchasepPrice = 351.91f, secondPurchasePrice = 587.19f;


            Console.WriteLine($"\n{storeName} \ndetmir.ru \nКАССОВЫЙ ЧЕК \nКасса №={cashКegister} \n{firstPurchase} - {firstPurchasepPrice} " +
                $"\n{secondPurchase} - {secondPurchasePrice} \nДата и время - {DateTime.Now}");
            #endregion 4
            

            #region 6 Явный пример - офис номер 1 работает со вторника до пятницы, офис номер 2 работает с понедельника до воскресенья и выведите его на экран консоли.
            // маски графиков
            officesSchedule Office_5_2 = officesSchedule.Monday | officesSchedule.Tuesday | officesSchedule.Wednesday | officesSchedule.Thursday | officesSchedule.Friday;
            officesSchedule Office_2_2 = officesSchedule.Monday | officesSchedule.Tuesday | officesSchedule.Friday | officesSchedule.Saturday;
            officesSchedule Office_3_3 = officesSchedule.Monday | officesSchedule.Tuesday | officesSchedule.Wednesday | officesSchedule.Sunday;
            
            // какие дни может работать кандидат
            officesSchedule candidateOneCanWork = officesSchedule.Monday | officesSchedule.Friday | officesSchedule.Thursday;
            officesSchedule candidateTwoCanWork = officesSchedule.Thursday | officesSchedule.Saturday;
            officesSchedule candidateFourCanWork = officesSchedule.Monday | officesSchedule.Tuesday | officesSchedule.Wednesday | officesSchedule.Thursday | officesSchedule.Friday;
            officesSchedule candidateFiveCanWork = officesSchedule.Monday & officesSchedule.Tuesday;
            
            Console.WriteLine($"candidateFourCanWork == Office_5_2  {Office_5_2} | {candidateFourCanWork}  =  {Office_5_2 == (Office_5_2 | candidateFourCanWork)}");
            Console.WriteLine($"candidateFourCanWork == Office_5_2  {Office_5_2} & {candidateFourCanWork}  =  {Office_5_2 == (Office_5_2 & candidateFourCanWork)}");
            Console.WriteLine($"candidateOneCanWork == Office_5_2   {Office_5_2} | {candidateOneCanWork}   =  {Office_5_2 == (Office_5_2 | candidateOneCanWork)}"); // при частичном совпадении, если хотя бы некоторые дни графика входят в необходимый график будет true | если хотя бы несколько дней из 5 2 может ходить но при условии, что у кандидата нет дней не входящих в 5 2, на пример, субботы, или воскресенья (дико тупой момент стявящий полезность под вопрос)
            Console.WriteLine($"candidateOneCanWork == Office_5_2   {Office_5_2} & {candidateOneCanWork}   =  {Office_5_2 == (Office_5_2 & candidateOneCanWork)}"); // только при полном совпадении графика с необходимым | если кандидат все дни 5 2 может работать, будет true
            #endregion 6
        }
    }
}