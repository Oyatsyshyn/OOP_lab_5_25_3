using System;

namespace OOP_lab_5_25_3
{
    public class Calls : TelephoneNumber
    {
        private DateTime _date;
        private double _minutesCount;
        private double _spentMoney;

        public DateTime Date
        {
            get => _date;
            set => _date = value;
        }

        public double MinutesCount
        {
            get => _minutesCount;
            set => _minutesCount = value;
        }

        public double SpentMoney
        {
            get => _spentMoney;
            set => _spentMoney = value;
        }

        public virtual double MinuteValue()
        {
            return _spentMoney / _minutesCount;
        }

        public Calls()
        {
            base.Number = "Не вказано.";
            base.Operator = "Не вказано.";

            _date = DateTime.Parse("01.01.01");
            _minutesCount = 0;
            _spentMoney = 0;
        }

        public Calls(string Number, string Operator, DateTime Date, double MinutesCount, double SpentMoney)
        {
            base.Number = UkrainianI(Number); ;
            base.Operator = UkrainianI(Operator);

            _date = Date;
            _minutesCount = MinutesCount;
            _spentMoney = SpentMoney;
        }
    }
}
