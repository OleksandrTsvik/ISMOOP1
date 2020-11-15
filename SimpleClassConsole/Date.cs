using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassConsole
{
    public class Date
    {
        protected int Year;
        protected int Month;
        protected int Day;
        protected int Hours;
        protected int Minutes;

        public Date()
        {
            SetYear(2000);
            SetMonth(1);
            SetDay(1);
            SetHours(0);
            SetMinutes(0);
        }

        public Date(int year)
        {
            SetYear(year);
            SetMonth(1);
            SetDay(1);
            SetHours(1);
            SetMinutes(1);
        }

        public Date(int year, int month, int day)
        {
            SetYear(year);
            SetMonth(month);
            SetDay(day);
            SetHours(0);
            SetMinutes(0);
        }

        public Date(int year, int month, int day, int hours, int minutes)
        {
            SetYear(year);
            SetMonth(month);
            SetDay(day);
            SetHours(hours);
            SetMinutes(minutes);
        }

        public Date(Date obj)
        {
            Year = obj.Year;
            Month = obj.Month;
            Day = obj.Day;
            Hours = obj.Hours;
            Minutes = obj.Minutes;
        }

        public void SetYear(int year)
        {
            if (year >= 1903 && year <= 2100)
                Year = year;
            else Year = 1903;
        }

        public void SetMonth(int month)
        {
            if (month >= 1 && month <= 12)
                Month = month;
            else Month = 1;
        }

        public void SetDay(int day)
        {
            if (day >= 1 && day <= 31)
                Day = day;
            else Day = 1;
        }

        public void SetHours(int hours)
        {
            if (hours >= 0 && hours <= 23)
                Hours = hours;
            else Hours = 0;
        }

        public void SetMinutes(int minutes)
        {
            if (minutes >= 0 && minutes <= 59)
                Minutes = minutes;
            else Minutes = 0;
        }

        public int GetYear() 
        {
            return Year;
        }

        public int GetMonth()
        {
            return Month;
        }

        public int GetDay()
        {
            return Day;
        }

        public int GetHours()
        {
            return Hours;
        }

        public int GetMinutes()
        {
            return Minutes;
        }
    }
}
