using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptsPoo
{
    public class Date
    {
        private int _Year;
        private int _Month;
        private int _Day;

        //public int Day { get; set; }
        //public int Month { get; set; }
        //public int Year { get; set; }
        public Date(int day, int month, int year)
        {
            _Year = year;
            _Month = CheckMonth(month);
            _Day = CheckDay(day, month, year);
        }

        public Date()
        {
        }

        private int CheckDay(int day, int month, int year)
        {
            if (month == 2 && day == 29 && isLeapYear(year))
            {
                return day;
            }
            int[] daysPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (day >= 1 && day <= daysPerMonth[month])
            {
                return day;
            }
            throw new DayException("Invalid Day ! ");
        }

        private bool isLeapYear(int year)
        {
            return year % 400 == 0 || year % 4 == 0 && year % 100 != 0;
        }

        private int CheckMonth(int month)
        {
            if (month >0 && month < 13)
            {
                return month;
            }
            else
            {
                throw new MonthException("Invalid Month");
            }


        }
        public override string ToString()
        {
            return $"{_Day:00}/{_Month:00}/{_Year}";
        }
    }
}
