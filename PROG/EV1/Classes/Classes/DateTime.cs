using System;

namespace Classes
{
    public enum DayOfWeek
    {
        MONDAY, TUESDAY , WEDNESDAY, TRHUSDAY, FRIDAY , SATURDAY, SUNDAY
    }
    public class DateTime
    {
        private int _second;
        private int _minute;
        private int _hour;
        private int _day;
        private int _month;
        private int _year;
        public DateTime(int day, int month, int year)
        {
            _day = day;
            _month = month;
            _year = year;
        }
        public DateTime(int hour, int minute, int second, int day, int month, int year)
        {
            if (IsValid())
            {
                _second = second;
                _minute = minute;
                _hour = hour;
                _day = day;
                _month = month;
                _year = year;
            }
        }
        public int GetSecond()
        {
            return _second;
        }
        public int GetMinute()
        {
            return _minute;
        }
        public int GetHour()
        {
            return _hour;
        }
        public int GetDay()
        {
            return _day;
        }
        public int GetMonth()
        {
            return _month;
        }
        public int GetYear()
        {
            return _year;
        }
        public bool IsValid()
        {
            if(_second < 0  || _minute < 0 || _hour < 0 || _day < 0 || _month < 0 ||_year < 0)
                return false;
            while(_second >= 60)
            {
                _minute++;
                _second -= 60;
            }
            while(_minute >= 60)
            {
                _hour++;
                _minute -= 60;
            }
            while(_hour >= 24)
            {
                _day++;
                _hour -= 24;
            }
            while (_month == 2)
            {
                if (_day >= 28 && !IsLeap(_year))
                {
                    _month++;
                    _day -= 28;
                }
                if(_day > 29 && IsLeap(_year))
                {
                    _month++;
                    _day -= 29;
                }
                
            }
            while(_month == 1 || _month == 3 || _month == 5 || _month == 7 || _month == 8 || _month == 10 || _month == 12 && _day > 30)
            {
                _month++;
                _day -= 31;
            }
            while(_month == 4 || _month == 6 || _month == 9 || _month == 11 && _day > 29)
            {
                _month++;
                _day -= 30;
            }
            if(_month > 12)
            {
                _year++;
                _month -= 12;
            }

            return true;
        }
        public static bool IsLeap(int year)
        {
            return year % 4 == 0 && year % 100 != 0;
        }
        public bool Isleap()
        {
            return IsLeap(_year);
        }
        public string DateToString()
        {
            if (IsValid())
            {
                if (_hour < 10)
                    return "0" + _hour + ":" + _minute + ":" + _second + "  " + _day + "/" + _month + "/" + _year;
            }
            return _second + ":" + _minute + ":" + _hour + "  " + _day + "/" + _month + "/" + _year;
        }
        public int GetDaysCount(int year, int month)
        {
            if (month > 12)
                return -1;
 
            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
                return  31;
            if (!IsLeap(year) && month == 2)
            {
                return 28;
            }
            return 30;
        }
        public void IncrementDay()
        {
            _day++;
        }
        public void IncrementSecond()
        {
            _second++;
        }
        public DateTime Clone()
        {
            return new DateTime(_year, _month, _day); 
        }
        public bool Equals(DateTime other)
        {
            return _second == other._second &&
                _minute == other._minute &&
                _hour == other._hour &&
                _day == other._day &&
                _month == other._month &&
                _year == other._year;
        }

    }
}
