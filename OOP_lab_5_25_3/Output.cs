using System;

namespace OOP_lab_5_25_3
{
    class Output
    {
        public const string Format = "{0, -20} {1, -15} {2, -15} {3, -30} {4, -20}";

        public static void Write()
        {
            Console.WriteLine(Format, "Номер", "Оператор", "Дата", "Кiлькiсть хвилин", "Використанi кошти");

            for (int i = 0; i < Program.abonents.Length; ++i)
            {
                Console.WriteLine(Format, Program.abonents[i].Number, Program.abonents[i].Operator, Program.abonents[i].Date.ToShortDateString(), Program.abonents[i].MinutesCount, Program.abonents[i].SpentMoney);
            }
        }
    }
}
