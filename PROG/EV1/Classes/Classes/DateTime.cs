using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public enum DayOfWeek
    {
        MONDAY, TUESDAY , WEDNESDAY, TRHUSDAY, FRIDAY , SATURDAY, SUNDAY
    }
    public class DateTime
    {
        private int _second, _minute, _hour, _day, _month, _year;

        public DateTime(int second, int minute, int hour, int day, int month, int year)
        {
            _second = second;
            _minute = minute;
            _hour = hour;
            _day = day;
            _month = month;
            _year = year;
        }
        public int Second()
        {
            return _second;
        }
        public int Minute()
        {
            return _minute;
        }
        public int Hour()
        {
            return _hour;
        }
        public int Day()
        {
            return _day;
        }
        public int Month()
        {
            return _month;
        }
        public int Year()
        {
            return _year;
        }
        public bool IsValid()
        {
            if(_second < 0 || _minute < 0 || _hour < 0 || _day < 0 || _month < 0 ||_year < 0)
                return false;
            return true;
        }



    }
}
