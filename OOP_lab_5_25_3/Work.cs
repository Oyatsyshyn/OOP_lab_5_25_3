using System;
using System.IO;

namespace OOP_lab_5_25_3
{
    class Work
    {
        public static void Add()
        {
            StreamWriter file = new StreamWriter("base.txt", true);

            Console.WriteLine("\nВведiть новi данi");

            Console.Write("Номер: ");

            file.WriteLine(Console.ReadLine());

            Console.Write("Оператор: ");

            file.WriteLine(Console.ReadLine());

        RetryDate:
            Console.Write("Дата: ");

            try
            {
                file.WriteLine(DateTime.Parse(Console.ReadLine()));
            }
            catch (SystemException)
            {
                Console.WriteLine("Неправильно вказана дата!");

                goto RetryDate;
            }

        RetryMinutesCount:
            Console.Write("Кiлькiсть хвилин: ");

            try
            {
                file.WriteLine(int.Parse(Console.ReadLine()));
            }
            catch (SystemException)
            {
                Console.WriteLine("Кiлькiсть хвилин має бути вказана лише числом!");

                goto RetryMinutesCount;
            }

        RetrySpentMoney:
            Console.Write("Витраченi грошi: ");

            try
            {
                file.WriteLine(int.Parse(Console.ReadLine()));
            }
            catch (SystemException)
            {
                Console.WriteLine("Кiлькiсть витрачених грошей має бути вказана лише числом!");

                goto RetrySpentMoney;
            }

            file.Close();

            Input.ReadBase();
        }

        public static void Remove()
        {
            Console.WriteLine();

            Output.Write();

            Console.Write("Порядковий номер запису для видалення: ");

            bool[] remove = new bool[Program.abonents.Length];

            for (int i = 0; i < remove.Length; ++i)
            {
                remove[i] = false;
            }

            try
            {
                remove[int.Parse(Console.ReadLine()) - 1] = true;
            }
            catch (SystemException)
            {
                Console.WriteLine("Такого запису не iснує!");
                return;
            }

            StreamWriter file = new StreamWriter("base.txt");

            for (int i = 0; i < Program.abonents.Length; ++i)
            {
                if (!remove[i])
                {
                    file.WriteLine(Program.abonents[i].Number);
                    file.WriteLine(Program.abonents[i].Operator);
                    file.WriteLine(Program.abonents[i].Date.ToShortDateString());
                    file.WriteLine(Program.abonents[i].MinutesCount);
                    file.WriteLine(Program.abonents[i].SpentMoney);
                }
            }

            Console.Write("Видалено.\n");

            file.Close();

            Input.ReadBase();
        }

        public static void Edit()
        {
            Console.WriteLine();

            Output.Write();

            Console.Write("Порядковий номер запису для редагування: ");

            bool[] edit = new bool[Program.abonents.Length];

            for (int i = 0; i < edit.Length; ++i)
            {
                edit[i] = false;
            }

            try
            {
                edit[int.Parse(Console.ReadLine()) - 1] = true;
            }
            catch (SystemException)
            {
                Console.WriteLine("Такого запису не iснує!");
                return;
            }

            StreamWriter file = new StreamWriter("base.txt");

            for (int i = 0; i < Program.abonents.Length; ++i)
            {
                if (edit[i])
                {
                    Console.WriteLine("Введiть новi данi");

                    Console.Write("Номер: ");

                    file.WriteLine(Console.ReadLine());

                    Console.Write("Оператор: ");

                    file.WriteLine(Console.ReadLine());

                RetryDate:
                    Console.Write("Дата: ");

                    try
                    {
                        file.WriteLine(DateTime.Parse(Console.ReadLine()));
                    }
                    catch (SystemException)
                    {
                        Console.WriteLine("Неправильно вказана дата!");

                        goto RetryDate;
                    }

                RetryMinutesCount:
                    Console.Write("Кiлькiсть хвилин: ");

                    try
                    {
                        file.WriteLine(int.Parse(Console.ReadLine()));
                    }
                    catch (SystemException)
                    {
                        Console.WriteLine("Кiлькiсть хвилин має бути вказана лише числом!");

                        goto RetryMinutesCount;
                    }

                RetrySpentMoney:
                    Console.Write("Витраченi грошi: ");

                    try
                    {
                        file.WriteLine(int.Parse(Console.ReadLine()));
                    }
                    catch (SystemException)
                    {
                        Console.WriteLine("Кiлькiсть витрачених грошей має бути вказана лише числом!");

                        goto RetrySpentMoney;
                    }             
                }
                else
                {
                    file.WriteLine(Program.abonents[i].Number);
                    file.WriteLine(Program.abonents[i].Operator);
                    file.WriteLine(Program.abonents[i].Date.ToShortDateString());
                    file.WriteLine(Program.abonents[i].MinutesCount);
                    file.WriteLine(Program.abonents[i].SpentMoney);
                }
            }

            Console.Write("Змiни внесено.\n");

            file.Close();

            Input.ReadBase();
        }

        public static void InitialiseBase(int n)
        {
            Program.abonents = new Calls[n];
        }

        public static void Average()
        {
            Console.Write("\nСередня платня в день: ");

            double sum = 0;

            for (int i = 0; i < Program.abonents.Length; ++i)
            {
                sum += Program.abonents[i].SpentMoney;
            }

            Console.WriteLine(sum / Program.abonents.Length);
        }

        public static void Above()
        {
            Console.WriteLine("\nКiлькiсть хвилин: ");

            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Днi, коли кiлькiсть хвилин була бiльшою за вказане значення: ");

            Console.WriteLine(Output.Format, "Номер", "Оператор", "Дата", "Кiлькiсть хвилин", "Використанi кошти");

            for (int i = 0; i < Program.abonents.Length; ++i)
            {
                if (Program.abonents[i].MinutesCount % 2 == 0)
                {
                    Console.WriteLine(Output.Format, Program.abonents[i].Number, Program.abonents[i].Operator, Program.abonents[i].Date.ToShortDateString(), Program.abonents[i].MinutesCount, Program.abonents[i].SpentMoney);
                }
            }
        }

        public static void Odd()
        {
            Console.WriteLine("\nДнi, коли кiлькiсть хвилин була парна: ");

            Console.WriteLine(Output.Format, "Номер", "Оператор", "Дата", "Кiлькiсть хвилин", "Використанi кошти");

            for (int i = 0; i < Program.abonents.Length; ++i)
            {
                if (Program.abonents[i].MinutesCount % 2 == 0)
                {
                    Console.WriteLine(Output.Format, Program.abonents[i].Number, Program.abonents[i].Operator, Program.abonents[i].Date.ToShortDateString(), Program.abonents[i].MinutesCount, Program.abonents[i].SpentMoney);
                }
            }
        }
    }
}
