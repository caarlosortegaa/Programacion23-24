

namespace Classes
{
    public enum DayOfWeek
    {
        MONDAY, TUESDAY , WEDNESDAY, TRHUSDAY, FRIDAY , SATURDAY, SUNDAY
    }
    public class DateTime
    {
        private int _second, _minute, _hour, _day, _month, _year;
        DayOfWeek _dayOfWeek;

        public DateTime(int second, int minute, int hour, int day, int month, int year)
        {
            _second = second;
            _minute = minute;
            _hour = hour;
            _day = day;
            _month = month;
            _year = year;
        }
        public DateTime(int day , int month , int year)
        {
            _day = day;
            _month = month;
            _year = year;
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
        public DayOfWeek GetDayOfWeek()
        {
            return _dayOfWeek;
        }
        //public DateTime Clone()
        //{
        //}
        public bool IsValid()
        {
            if(_second < 0 || _minute < 0 || _hour < 0 || _day < 0 || _month < 0 ||_year < 0)
                return false;
            return true;
        }
        public static bool IsLeap(int year)
        {
            return year % 4 == 0 && year % 100 != 0 ? true : false;
        }
        public string DateToString()
        {
            return  _day + "/" + _month + "/" + _year;
        }
        public int GetDaysCount(int year, int month)
        {
            int count = 0;
            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
                count += 31;
            if (month == 4 || month == 6 || month == 9 || month == 11)
                count += 30;
            if (!IsLeap(year) && month == 2)
                count += 28;
            if (IsLeap(year) && month == 2)
                count += 29;
            return count;
            
        }



    }
}
